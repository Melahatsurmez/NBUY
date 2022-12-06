$(document).ready(function () {
    //datatable burada başlıyor
    $('#categoriesTable').DataTable({ //Datatabledan aldıgımız kodlar

        dom: "<'row'<'col-sm-3'l><'col-sm-6 text-center'B><'col-sm-3'f>>" +
            "<'row'<'col-sm-12'tr>>" +
            "<'row'<'col-sm-5'i><'col-sm-7'p>>",
        buttons: [
            {
                text: 'Ekle',
                attr: {
                    id: 'btnAdd'
                },
                action: function (e, dt, node, config) {

                },
                className: 'btn btn-success'
            },
            { //yenileye tıklanınca çıkan alert kısmı burası
                text: 'Yenile',
                action: function (e, dt, node, config) {
                    //Burada yenile butonuna basıldıgında Ajax ile içeriğimizi yenileyeceğiz.
                    $.ajax({
                        type: 'GET',//Yapacagımız işlemin get işlemi oldugunu söyleyip
                        url: '/Admin/Category/GetAllCategories/',//Hangi kategorinin çalıştıgı ve neyin içinde bulundugu , @ ;c# kodu burda çalışmayacagı için değiştirdik
                        contentType: 'application/json', // Jsonla çalışacagımızı söyledik
                        beforeSend: function () {
                            //Get işlemi başarılıysa ondan hemen önce bu işlemi yapıcak
                            $('#categoriesTable').fadeOut(1000); // bu tabloyu gizlemesi, hocada hide();
                            $('.spinner-border').show(); // spinner gösterme işlemi
                        },
                        success: function (data) { //data ismi istediğimiz isim
                            const categoryListDto = jQuery.parseJSON(data);
                            if (categoryListDto.ResultStatus === 0) { // eger categoryListDto dönen 0 sa yani successse, succcess demedik çünkü o c# da
                                let tableBody = ''; // oluşturacagımız tablo temizlendi
                                $.each(categoryListDto.Categories.$values, //neyin içinde oldugu
                                    function (index, category) //neyin içinde dönüp değerlere nasıl ulaşacağı kısmı,index kaçıncı kez döndüğü bilgisi
                                    {
                                        tableBody += `
                                                    <tr name="${category.Id}">
                                                    <td>${category.Id}</td> 
                                                    <td>${category.Name}</td>
                                                    <td>${category.Description}</td>
                                                    <td>${convertFirstLetterToUpperCase(category.IsActive)}</td>
                                                     <td>${convertToShortDate(category.CreatedDate)}</td>
                                                    <td>${category.CreatedByName}</td>
                                                    <td>
                                                        <button class="btn btn-warning btn-sm btn-update" data-id="${category.Id}"><span class="fas fa-edit text-white"></span></button>
                                                        <button class="btn btn-danger btn-sm btn-delete" data-id="${category.Id}"><span class="fas fa-minus-circle"></span></button> 
                                                    </td>
                                                    </tr>
                                                `;
                                    });
                                $('#categoriesTable > tbody').replaceWith(tableBody); //categorires t body sini tablebody ile doldur
                                 // yukarda button yanındaki comment: data id hangi id li category i silecegini göstermek için , tıklanılan şey btn delete mi onu kontrol etmek için btn delete verdik*@
                                $('.spinner-border').hide(); //
                                $('#categoriesTable').fadeIn(1000);
                            } else { //eğer 0 yani success çalışmazsa ama çalışacağı bu hata mesajı şuan için görülmez 
                                toastr.error(`${categoryListDto.Message}`, 'İşem Başarısız!');
                            }
                        },
                        error: function (err) {
                            console.log(err);
                            toastr.error(err, 'Başarısız İşlem!')
                        }
                    });
                },
                className: 'btn btn-warning'
            }
        ],
        language: {
            url: 'http://cdn.datatables.net/plug-ins/1.13.1/i18n/tr.json'
        }
    }); //Bu sayfa yüklemesini tamamlandıgında bu çalışsın
    //Datataable burada bitiyor

    $(function () {
        const url = '/Admin/Category/Add/'; //gidilecek olan link
        const placeHolderDiv = $('#modalPlaceHolder');
        //Ajax'la partial Viewımızı ekrana getirdik
        $('#btnAdd').click(function () {
            $.get(url).done(function (data) {
                placeHolderDiv.html(data);
                placeHolderDiv.find(".modal").modal('show');
                //ekrana  ekle form kısmının gelmesi 
            });
        });
        //Ajax'la (GET) partial Viewımızı ekrana getirme BİTTİ

        //Ajax'la POST İşlemleri yani o kartın doldurulması işlemi
        placeHolderDiv.on('click', '#btnSave', function (event) { //btns save olana click yapıldıgında -partialviewdaki
            event.preventDefault(); //submit oldugunda sayfanın refresh yapılmaması
            const form = $('#form-category-add')// _categoryAddPartialdaki form-category-add id si
            const actionUrl = form.attr('action'); //actionurl: addpartialda add actionlu ama posta gider
            const dataToSend = form.serialize(); //form içindeki inputları json aalmış olucak
            $.post(actionUrl, dataToSend).done(function (data) { //post url  istiyor,datatosend girilen verileri şu actiona yolla ,sorun yoksa gönderdiği datalarla şu functionu yap
                const categoryAddAjaxModel = jQuery.parseJSON(data); // veritabanının jsonda dönüşümü
                const newFormBody = $('.modal-body', categoryAddAjaxModel.CategoryAddPartial);
                placeHolderDiv.find('.modal-body').replaceWith(newFormBody);
                const isValid = newFormBody.find('[name="IsValid"]').val() === 'True'; 
                if (isValid) {
                    //Id Name gibi istediğimiz bilgileri tabloya bu şekilde ekliyoruz
                    const newTableRow = `
                        <tr name="${categoryAddAjaxModel.CategoryDto.Category.Id}">
                            <td>${categoryAddAjaxModel.CategoryDto.Category.Id} </td>
                            <td>${categoryAddAjaxModel.CategoryDto.Category.Name} </td>
                            <td>${categoryAddAjaxModel.CategoryDto.Category.Description} </td>
                            <td>${convertFirstLetterToUpperCase(categoryAddAjaxModel.CategoryDto.Category.IsActive)} </td>
                            <td>${convertToShortDate(categoryAddAjaxModel.CategoryDto.Category.CreatedDate)} </td>
                            <td>${categoryAddAjaxModel.CategoryDto.Category.CreatedByName} </td>
                            <td>
                                <button class="btn btn-warning btn-sm btn-update" data-id="${categoryAddAjaxModel.CategoryDto.Category.Id}"><span class="fas fa-edit text-white"></span></button>
                                <button class="btn btn-danger btn-sm btn-delete" data-id="${categoryAddAjaxModel.CategoryDto.Category.Id}"><span class="fas fa-minus-circle"></span></button> 
                            </td>
                        </tr>
                                                                                `;
                    //girdiğimiz bilgiler doğruysa aşağıdaki kodlar çalışacak ve bilgilerin aşağıdaki kodda verildiği gibi istenilen sürede ekrana yavaş bir şekilde gelmesini sağlayacak ve sağ üst köşede işlemin başarıyla oluştuğu gösterilecek kısım kodu
                    const newTableRowObject = $(newTableRow);
                    newTableRowObject.hide();
                    $('#categoriesTable').append(newTableRowObject);
                    newTableRowObject.fadeIn(1000);
                    toastr.success(`${categoryAddAjaxModel.CategoryDto.Message} `, 'Başarılı!');
                    placeHolderDiv.find(".modal").modal('hide');
                } else { //isvalid false ise;
                    //Eğer istenilen koşullara uygun değilse de (karakter sayısı vb. gibi) yine sağ üst keşede hangi koşula uymadıgı yazılacak kod kısmı
                    let summaryText = '<br>';
                    $('#validation-summary > ul > li').each(function () {
                        let liText = $(this).text();
                        summaryText += `* ${liText} <br><br>`;
                    });
                    console.log(summaryText); //Sayfanın sağ üst köşesinde gösterilen etiketi yazdırıyoruz.
                    toastr.warning(summaryText, 'Dikkat'); //tastr ın bize sağlamış oldugu warning kodu ile başlık gbi bir yazı ekliyoruz.
                }
            });
        });
        //Ajax'la POST İşlemleri Bitti

        //Ajax'la DELETE İşlemleri
        $(document).on('click', '.btn-delete', function (event) { //document sayfanın kendisi click yapıldığında  (classı btn delete olan) bu functionu çalıştır (
            event.preventDefault(); //burada buttonumuzuntipi submit olmadıgı için bunu kullanmasak da olur.Alışkanlık olması için yzdık
            const id = $(this).attr('data-id'); //this demek neye tıklanıldıysa o demek, attr ulaşmak istiyoruz(data id olan)
            Swal.fire({
                title: 'Silmek istediğinizden emin misiniz?',
                text: "İlgili kategori silinecektir!",
                icon: 'warning',
                showCancelButton: true,
                confirmButtonColor: '#3085d6',
                cancelButtonColor: '#d33',
                confirmButtonText: 'Evet',
                cancelButtonText: 'Hayır'
            }).then((result) => {
                if (result.isConfirmed) {
                    //Burada kategorinin silinme işlemleri yapılacak artından silinmiştir mesajı gösterilecektir.
                    $.ajax({
                        type: 'POST',
                        dataType: 'json', // jsondan göndericez ,veri çekerken application json veri update ederken bu şekşlde yapzılır.
                        data: { categoryId: id }, // 2 sonra bunu alacak , değeri id olan
                        url: '/Admin/Category/Delete/', //1 ilk buraya gidicek
                        success: function (data) {
                            const result = jQuery.parseJSON(data); //gelen datayı sonucun içinde atın jsonda parse
                            if (result.ResultStatus === 0) //geriye dönen result değeri varsa ve 0 sa burası çalışacak
                            {
                                Swal.fire({
                                    title: 'İşlem başarılı!',
                                    text: 'İlgili kategori silinmiştir.',
                                    icon: 'success',
                                    confirmButtonText: 'Tamam'
                                }); //silinme işlemi yazısı çıktıktan sonra aşagıda silme işlemi kısmı yapılacak
                                const tableRow = $(`[name="${id}"]`);
                                tableRow.fadeOut(1000);
                            } else {
                                Swal.fire({
                                    title: 'Hata Oluştu!',
                                    text: `${result.Message}`,
                                    icon: 'error',
                                    confirmButtonText: 'Tamam'
                                });
                            }
                        },
                        error: function (err) {
                            toastr.error(err.statusText, 'Hata!')
                        }
                    })
                }
            })

        });
    });
    $(function () {
        const url = '/Admin/Category/Update/';
        
        const placeHolderDiv = $('#modalPlaceHolder');
        //Category update Partial View Getirme
        $(document).on('click', '.btn-update', function (event) {
            event.preventDefault();
            const id = $(this).attr('data-id');
            $.get(url, { categoryId: id })
                .done(function (data) { //kendisinden önceki işlem başarılıysa 
                    placeHolderDiv.html(data);
                    placeHolderDiv.find('.modal').modal('show');
                })
                .fail(function () {
                    toastr.error('Bir hata oluştu!');
                });
        });
         //Category update Partial View Getirme Bitti

        
        placeHolderDiv.on('click', '#btnUpdate', function (event) {
            event.preventDefault();
            const form = $('#form-category-update'); //bu id li formu bul
            const actionUrl = form.attr('action'); //bu actionu seç
            const dataToSend = form.serialize();
            $.post(actionUrl, dataToSend)
                .done(function (data) {
                    const categoryUpdateAjaxModel = jQuery.parseJSON(data);
                    const newFormBody = $('.modal-body', categoryUpdateAjaxModel.CategoryUpdatePartial);
                    placeHolderDiv.find('.modal-body').replaceWith(newFormBody);
                    const isValid = newFormBody.find('[name="IsValid"]').val() === 'True';
                    if (isValid) {
                        placeHolderDiv.find('.modal').modal('hide');
                        const currentCategoryTableRow = $(`[name="${categoryUpdateAjaxModel.CategoryDto.Category.Id}"]`); //name i kaç olan isteniyorsa onu bul.
                        if (!categoryUpdateAjaxModel.CategoryDto.Category.IsDeleted) {
                            const newTableRow = `
                    <tr name="${categoryUpdateAjaxModel.CategoryDto.Category.Id}">
                            <td>${categoryUpdateAjaxModel.CategoryDto.Category.Id} </td>
                            <td>${categoryUpdateAjaxModel.CategoryDto.Category.Name} </td>
                            <td>${categoryUpdateAjaxModel.CategoryDto.Category.Description} </td>
                            <td>${convertFirstLetterToUpperCase(categoryUpdateAjaxModel.CategoryDto.Category.IsActive)} </td>
                            <td>${convertToShortDate(categoryUpdateAjaxModel.CategoryDto.Category.CreatedDate)} </td>
                            <td>${categoryUpdateAjaxModel.CategoryDto.Category.CreatedByName} </td>
                            <td>
                                <button class="btn btn-warning btn-sm btn-update" data-id="${categoryUpdateAjaxModel.CategoryDto.Category.Id}"><span class="fas fa-edit text-white"></span></button>
                                <button class="btn btn-danger btn-sm btn-delete" data-id="${categoryUpdateAjaxModel.CategoryDto.Category.Id}"><span class="fas fa-minus-circle"></span></button> 
                            </td>
                        </tr>
                    `;
                            const newTableRowObject = $(newTableRow);
                            newTableRowObject.hide();
                            currentCategoryTableRow.replaceWith(newTableRowObject);
                            newTableRowObject.fadeIn(1000);
                            toastr.success(`${categoryUpdateAjaxModel.CategoryDto.Message}`, 'İşlem Başarılı!');
                        } else {
                            currentCategoryTableRow.fadeOut(1000);
                            toastr.success(`${categoryUpdateAjaxModel.CategoryDto.Category.Name} adlı kategori silindi`, 'İşlem başarılı!');
                        }
                    } else {
                        let summaryText = '<br>';
                        $('#validation-summary > ul > li').each(function () {
                            let text = $(this).text();
                            toastr.error(text); 
                        });
                         //Sayfanın sağ üst köşesinde gösterilen etiketi yazdırıyoruz.                       
                    }

                })
            
        })
    })



});