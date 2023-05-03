const Button = document.querySelector('#btn');
const Button2 = document.querySelector('#btn2');
const Button3 = document.querySelector('#btn3');
const Button4 = document.querySelector('#btn4');


function handleButton(a, event){
    event.preventDefault();
    document.querySelector("body").style.backgroundColor = a;
}
