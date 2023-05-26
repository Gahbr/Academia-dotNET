1 - Criar uma classe chamada Pessoa com 2 construtores, um que receba o nome e a idade da pessoa e 
outro recebendo apenas a idade. Solicite ao usu�rio qual dos construtores ele gostaria de utilizar 
na instancia��o da classe. Al�m de receber par�metros, os construtores imprimem na tela o conte�do 
dos par�metros recebidos.

2 - Criar uma classe chamada Aluno com 3 construtores, sendo que o primeiro recebe o nome e a matr�cula
do aluno, o segundo recebe apenas a data de nascimento do aluno e o terceiro construtor recebe o nome
do aluno, a data de nascimento e o ano em que o aluno ingressou na faculdade.
Crie uma classe principal, com 3 objetos, cada um instanciando a classe com um construtor diferente.

3 - Crie uma classe ContaCorrente que obede�a � descri��o abaixo: A classe possui o atributo saldo do tipo 
double e os m�todos definirSaldoInicial, depositar e sacar. O m�todo definirSaldoInicial deve atribuir o
valor passado por par�metro ao atribuito saldo O m�todo depositar, deve adicionar o valor passado por
par�metro ao atributo saldo O m�todo sacar deve reduzir o valor passado por par�metro do saldo j� 
existente Necess�rio verificar a condi��o de o valor do saldo ser insuficiente para o saque que se deseja
fazer. O valor de retorno deve ser true (verdadeiro) quando for poss�vel realizar o saque e false (falso)
quando n�o for poss�vel

4 - Crie uma classe chamada Pessoa que tenha as propriedades Nome e Idade. Utilize o encapsulamento para garantir 
que o nome n�o seja vazio e que a idade seja maior que zero.

5 - Crie uma classe chamada Conta que tenha as propriedades N�mero, Saldo e Limite. Utilize o encapsulamento para 
garantir que o saldo nunca seja menor que zero e que o limite seja positivo e que o N�mero da conta n�o possa
ser alterado.

6 - Crie classes chamadas Fabricante e Produto. Fabricante que tenha as propriedades Nome, Endere�o e Cidade. 
Produto que tenha as propriedades Nome, Fabricante e Preco. Utilize o encapsulamento para garantir que o nome n�o
seja vazio e que o pre�o seja positivo. 

7 - Crie uma classe chamada Livro que tenha as propriedades Titulo e Autor (outra classe). Utilize o encapsulamento 
para garantir que o t�tulo e o autor n�o sejam vazios.

8 - Crie uma classe chamada Aluno que tenha as propriedades Nome e Matricula. Utilize o encapsulamento para garantir 
que o nome n�o seja vazio (utilize fun��o nativa) e que a matr�cula seja positiva.

9 - Crie uma classe chamada ContaBancaria que tenha as propriedades NumeroConta, Titular, Saldo e Limite. Crie tamb�m
um m�todo chamado Depositar, que recebe um valor e adiciona ao saldo da conta, e um m�todo Sacar, que recebe um 
valor e verifica se o saldo � suficiente para a opera��o.

10 - Crie uma classe chamada Animal que tenha as propriedades Nome, Especie e Idade. Crie tamb�m um m�todo chamado
EmitirSom, que imprime na tela o som do animal.


11 - Crie uma classe "Aluno" com os atributos "nome", "nota1", "nota2" e "nota3". Os atributos devem ser privados e
acessados atrav�s de propriedades. Em seguida, crie um m�todo para calcular a m�dia e verificar se o aluno est� aprovado 
ou reprovado (se a nota for maior ou igual a 6, est� aprovado, sen�o est� reprovado).

12 - Crie uma classe "Carro" com os atributos "modelo", "ano" e "velocidade". Em seguida, crie um m�todo para acelerar o carro
(aumentando a velocidade em 10) e outro para frear o carro (diminuindo a velocidade em 10, mas nunca deixando a 
velocidade negativa).

13 - Crie uma classe autor. Em seguida, crie uma classe "Livro" com os atributos "titulo" e "autor". O atributo autor, deve ser 
uma instancia de uma classe Autor. Crie um m�todo para exibir as informa��es do livro.

14 - Crie uma classe Agenda que pode armazenar 10 pessoas e que seja capaz de realizar as seguintes opera��es:
  void armazenaPessoa(String nome, int idade, float altura);
  void removePessoa(String nome);
  Pessoa buscaPessoa(String nome); // retorna a pessoa com o nome informado
  void imprimeAgenda(); // imprime os dados de todas as pessoas da agenda