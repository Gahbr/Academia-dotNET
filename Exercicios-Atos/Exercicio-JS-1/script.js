const Button = document.querySelector('#btn');
var count=0;

//Adaptar esse exemplo para ele mostrar quantas vezes o botão foi clicado. Quando atingir 5 cliques, não mostra mais mensagens.
function handleClick(){
    count++;
    if (count <= 5) document.getElementById('demo').innerHTML=`O botão foi clicado ${count} vezes.`
    
    if (count === 6) {
        btn.disabled = true;
        alert('Você atingiu o limite de cliques.');
    }
}

Button.addEventListener('click', handleClick);