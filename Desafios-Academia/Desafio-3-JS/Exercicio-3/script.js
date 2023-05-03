// Crie uma página com uma lista (select - radioButton) com 4 opções de cores. Ao selecionar uma opção de cor, altere o plano de fundo da página para a cor específica.
function handleSelect(event){
    var cor = document.querySelector('select').value;
    event.preventDefault();
    document.querySelector("body").style.backgroundColor = cor;
}
