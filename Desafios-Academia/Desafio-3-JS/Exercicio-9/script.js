//9 - Crie um formulário com os campos para cadastrar o usuário de um sistema (login, senha e confirmar senha). Permita que a página seja submetida apenas se todos os campos estiverem preenchidos, se os campos senha e confirma senha forem iguais e a senha possuir entre 6 e 10 caracteres.

const form = document.getElementById('form');
const Botao = document.getElementById('btn');

form.addEventListener('input', () => {
  const login = document.getElementById('loginInput').value;
  const senha = document.getElementById('senhaInput').value;
  const confirmarSenha = document.getElementById('confirmaInput').value;

  if (login && senha && confirmarSenha) {
    if (senha === confirmarSenha) {
      if (senha.length >= 6 && senha.length <= 10) {
        Botao.disabled = false; 
        return;
      }
    }
  }
  Botao.disabled = true; 
});

form.addEventListener('submit', (event) => { event.preventDefault(); });