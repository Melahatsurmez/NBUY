// function selamVer(){
//     console.log('Merhaba JS');
// }

// selamVer();//Öncesinede sonrasınada yazılır.

// function selamVer(isim='Dünya'){
//     console.log('Merhaba ' + isim);
// }
// selamVer('Engin');
// selamVer('Sema ve arkadaşları');
// selamVer();


// function yasHesapla(dogumYili){
//    return console.log(new Date().getFullYear()-dogumYili);
// }
// console.log(yasHesapla(1975));
// let yas=yasHesapla(2000);
// if (yas<30) {
//     console.log('Yaşınız uygun değil!');
// }else{
//     console.log('Kabul edildiniz.');
// }

//Bir tutar bilgisi alıp, bu tutarın kdvsini hesaplayıp geri döndüren function

// function kdvHesapla(tutar){
//     let sonuc = tutar * 0.18;
//     sonuc = sonuc.toFixed(2);
//     return sonuc;
// }
// console.log(kdvHesapla(117));


// function kdvHesapla(){
//     for (let i = 0; i < arguments.length; i++) {
//     console.log(arguments[i]*0.18);        
//     }
// }
// kdvHesapla(100,200,1000);

//Kendisine gönderilecek tutar bilgisini kullanarak kdv leri hesaplayıp, geriye hesaplanmış kdv leri içinde barındıran bir dizi döndüren function

function kdvHesapla(){
    let sonuc= [];
    let kdv=0;
    for (let i = 0; i < arguments.length; i++) {
        kdv=arguments[i]*0.18;
        kdv=kdv.toFixed(2);
        sonuc.push(kdv);
        // sonuc[i]=kdv;
    }
    return sonuc;
}
console.log(kdvHesapla(100,400,1000));