//1)// let saniye = parseInt(prompt('Lütfen saniye değerini giriniz: '));
// console.log('Girilen saniye değeri: ' + saniye);
// let dakika= parseInt(saniye / 60);
// saniye = saniye % 60;
// console.log(dakika + ' dakika ' + saniye + ' saniye.');

let sayi;
let sayiDurum=true;
do {
    sayi = parseInt(prompt("100'den büyük bir sayı giriniz"));
} while (sayi <= 100 && sayi!=NaN);





//3)// let n=prompt('Bir sayı giriniz: ');
// let asalMi;
// for (let i = 2; i <= n; i++) {
//     asalMi=true;
//     for (let j = 2; j < i; j++) {
        
//         if (i%j===0) {
//             asalMi=false;
//         }
//     }
//     if(asalMi===true){
//         console.log(i);
//     }
// }
//3)//2.çözüm
// let n=prompt('Bir sayı giriniz: ');
// nextPrime:
// for (let i = 2; i <=n; i++) {
//     for (let j = 2; j < i; j++) {
//         if (i%j===0) {
//             continue nextPrime;
//         }
        
//     }
//     console.log(i);
// }



