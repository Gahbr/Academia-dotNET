// Crie um parágrafo (p) com um texto como conteúdo. Adicione um botão que, ao ser clicado, oculte ou mostre o texto do parágrafo.
let isShowing = true;

function toggleText(event){
    event.preventDefault();
    const paragrafo =  document.querySelector("#paragrafo");
    const botao = document.querySelector("#btn");

    if(isShowing){
        botao.innerText= 'Mostrar'
        paragrafo.style.display = 'none';
        isShowing = false;
        console.log(isShowing);

    }else {
        botao.innerText= 'Ocultar'
        paragrafo.style.display = 'block';
        isShowing = true;
        console.log(isShowing);
    }
   
}
