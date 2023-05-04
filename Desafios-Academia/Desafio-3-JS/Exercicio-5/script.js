//Crie um formulário de seleção de itens com checkbox. O formulário deve possuir um botão desabilitado. O botão só se torna clicável quando tiver pelo menos 2 checkboxs marcado.let isShowing = true;

const checkboxs = document.querySelectorAll('input[type="checkbox"]');
const Botao = document.getElementById('btn');

function botao() {
    const numChecked = document.querySelectorAll('input[type="checkbox"]:checked').length;
    Botao.disabled = numChecked < 2;
  }
  
  checkboxs.forEach((checkbox) => {
    checkbox.addEventListener('change', botao);
  });