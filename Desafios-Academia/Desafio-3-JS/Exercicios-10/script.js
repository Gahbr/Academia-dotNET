//10 - Crie um formulário de cadastro de cliente. O formulário deve conter os campos Nome (text), Pessoa (Física/Jurídica– radio), CPF (text), CNPJ (text), data de nascimento, endereço (text), cep (text), telefone (text), email. O formulário deve ativar o campo CPF apenas se o RadioButton de pessoa física estiver ativo e o campo de CNPJ no caso de pessoa jurídica. O campo data de nascimento também só deve estar ativo no caso de pessoa física ser selecionado e deve aceitar que somente números sejam digitados. O campo CEP também só deve aceitar número.

const form = document.getElementById('form');

const radioElements = document.getElementsByName("pessoa");

form.addEventListener('input', () => {
  const radio = document.querySelector('input[name="pessoa"]:checked').value;
  if (radio =="fisica"){
    document.getElementById('divCpf').hidden = false;
    document.getElementById('divCnpj').hidden = true;
  } else if (radio == "juridica"){
    document.getElementById('divCnpj').hidden = false;
    document.getElementById('divCpf').hidden = true;
  } 

});

form.addEventListener('submit', (event) => {
   event.preventDefault();
   document.getElementById('demo').innerHTML= "Formulário enviado!";
   });