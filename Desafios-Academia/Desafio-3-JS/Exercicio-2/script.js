//Crie uma página com 4 links (tag a), cada um representando o nome de uma cor, que, utilizando o evento onmouseover altere a cor do plano de fundo para cor correspondente.
const Link = document.querySelector('#link');

function handleMouseOver(a, event){
    event.preventDefault();
    document.querySelector("body").style.backgroundColor = a;
}