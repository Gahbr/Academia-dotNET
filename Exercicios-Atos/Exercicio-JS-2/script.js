const Button = document.querySelector('#btn');
const Form = document.getElementById('form');
const Form2 = document.getElementById('form2');


function handleForm(event){
    event.preventDefault();
    nome =  document.getElementById('nome').value;
    idade =  document.getElementById('idade').value;
    
    document.getElementById('demo').innerHTML = `<h1>${nome} tem ${idade} anos</h1>`;

    if(idade>= 18){
        document.getElementById('demo2').innerHTML = `${nome} é maior de idade`;
    } else {
        document.getElementById('demo2').innerHTML = `${nome} é menor de idade`;
    }
}

function handleForm2(event){
    event.preventDefault();
    valor1 = Number( document.getElementById('valor1').value);
    valor2 = Number(document.getElementById('valor2').value);
    const soma = valor1 + valor2;

    document.getElementById('demo2').innerHTML = `<h1> A soma é: ${soma}</h1>`;
  
    if(soma % 2 == 0){
        document.getElementById("btn2").style.backgroundColor = "lightblue";
    }else {
        document.getElementById("btn2").style.backgroundColor = "green";
    }
}

Form.addEventListener('submit', handleForm);
Form2.addEventListener('submit', handleForm2);