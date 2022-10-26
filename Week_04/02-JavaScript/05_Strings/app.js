let ders='Bahçeşehir üniversitesi Wissen Akademie Iğdır';
let sonuc;
sonuc=ders.toLowerCase();
sonuc=ders.toLocaleLowerCase();
sonuc=ders.toUpperCase();
sonuc=ders.toLocaleUpperCase();

sonuc=ders.length;
sonuc=ders[0];
sonuc=ders[44];
sonuc=ders.slice(0,10);
sonuc=ders.slice(20,25);
sonuc=ders.slice(10);
sonuc=ders.substring(20,0);
sonuc=ders.substring(20,5);
sonuc=ders.substring(20,25);
sonuc=ders.substring(25,20);

sonuc=ders.replace('Iğdır','İstanbul');
sonuc=ders.replace(' ','-');
sonuc=ders.trim();//boşlukları kaldırır baştaki ve sondaki

sonuc=ders.trimStart(); //başdaki boşluğu alır end sondaki boşlugu alır.

sonuc=ders.indexOf('A');
sonuc=ders.toLocaleLowerCase().indexOf('A');

sonuc=ders.split(' ')
// console.log(sonuc[3]);
sonuc=ders.includes('Akademie');
sonuc=ders.startsWith('H');
sonuc=ders.endsWith('Iğdır');


console.log(sonuc);


//kullanıcının girdiği bir cümlenin kaç sözcükten oluştugunu bulunuz.
// let cumle=prompt('Bir cümle giriniz:')
// let sozcukDizisi=cumle.split(' ');
// console.log(sozcukDizisi.length);
