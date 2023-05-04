//6 – Crie um parágrafo com um texto como conteúdo. Crie 4 botões. Dois para trocar a cor da fonte, de branco para preto e vice-versa e outros dois para fazer o mesmo com o fundo do parágrafo. Use divs se julgar necessário.
//7-  Crie um botão + (mais) e outro – (menos) na mesma página do exercício anterior. Esses botões aumentam e diminuem o tamanho da fonte respectivamente.
//8 – Ainda continuando no exercício 6, faça um botão que transforme todo o texto do parágrafo em maiúscula, e outro em minúscula.

let paragrafo = document.querySelector("#paragrafo");
var fontSize = 14;

function handleButton(button) {
  switch (button) {
    case "bBackground":
      paragrafo.style.backgroundColor = "black";
      break;
    case "wBackground":
      paragrafo.style.backgroundColor = "white";
      break;
    case "wFont":
      paragrafo.style.color = "white";
      break;
    case "bFont":
      paragrafo.style.color = "black";
      break;
    case "upperCase":
      paragrafo.style.textTransform = "uppercase";
      break;
    case "lowerCase":
      paragrafo.style.textTransform = "lowercase";
      break;
    case "plus":
      fontSize += 2;
      paragrafo.style.fontSize = `${fontSize}px`;
      break;
    case "minus":
      fontSize -= 2;
      paragrafo.style.fontSize = `${fontSize}px`;
      break;
    default:
      break;
  }
}
