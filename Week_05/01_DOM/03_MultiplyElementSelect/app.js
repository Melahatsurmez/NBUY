let sonuc;
//getElementByClassName -->geriye bir çok sonuç döndürür
sonuc=document.getElementsByClassName('card-header');
sonuc=document.getElementsByClassName('task');
sonuc=document.getElementsByClassName('task')[0].innerText;
sonuc=document.getElementsByClassName('task')[2].innerText;
sonuc=document.getElementsByClassName('task');
// for (let i = 0; i < sonuc.length; i++) {
//     console.log(sonuc[i].innerText);    
// }
let taskList=document.getElementsByClassName('task');

// for (const task of taskList) {
//     task.style.color='red';
//     task.style.fontSize='60px';
//     task.innerText='ITEM'
// }

let taskList2=document.getElementById('task-list-2');//geriye tek bir değer döndürürü yukarıdan aşagı ilk karşılaştırıgını döndürür.
sonuc=taskList2.getElementsByClassName('task');
sonuc=taskList2.getElementsByTagName('li');//geriye birden çok sonuç döndürür

taskList2=document.querySelectorAll('#task-list-2 li')//geriye birden çok sonuç döndürür.
for (const task of sonuc) {
    task.style.backgroundColor='navy';
    task.style.color='white';
}
console.log(sonuc);