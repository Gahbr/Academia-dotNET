1) Implemente um programa em C# no qual o usu�rio dever� informar o nome e o poder (0 a 10) de tr�s personagens. 
O programa dever� informar o nome do personagem que possuir o maior poder.

Regras que dever�o ser seguidas para a implementa��o do algoritmo:

� obrigat�rio o uso de classe para representar um Personagem e a mesma dever� possuir como propriedades (caracter�sticas) um nome e um poder.
A classe tamb�m dever� possuir um m�todo chamado ExibirDados. Esse m�todo dever� exibir o nome e o poder do personagem em quest�o.
Ao implementar a classe � obrigat�rio implementar dois construtores (Sobrecarga), um que n�o recebe par�metro algum e outro que 
ir� receber o nome e o poder de um personagem


2) Crie um programa em C# no qual o usu�rio dever� informar o nome e o tipo de cinco animais de estima��o. 
O programa dever� exibir na tela para o usu�rio quantos Cachorros, Gatos e Peixes foram informados.

Regras que dever�o ser seguidas para a implementa��o do programa:

Os �nicos tipos de animais v�lidos s�o Cachorro, Gato, Peixe.
Caso seja informado um tipo diferente o programa repetir at� o usu�rio digitar um tipo v�lido.
� obrigat�rio criar uma classe para representar o Animal.
A classe dever� possuir dois dados privados (propriedades) para representar as caracter�sticas do animal.
A classe dever� possuir m�todos de acesso (propriedade getter e setter) para permitir que o usu�rio armazene/leia os dados dos dois dados privados (propriedades).

3) Imagine um jogo com asteroides e uma nave de ataque, que deve destruir os aster�ides que voam em todas as dire��es. Dessa forma, crie um programa em C# que represente
uma lista de asteroides que deveriam ser 'inseridos' no jogo. Para isso, fa�a uma classe que contenha os atributos (privados) posi��o x, posi��o y (do asteroide em
um plano cartesiano), tamanho do asteroide (1 a 10), velocidade do asteroide (1 a 5) e energia (1 a 5). Para esses atributos privados, gerar os m�todos de acesso
(propriedades getter e setter). Al�m disso, implementar 3 construtores (sobrecarga): um vazio, outro passando todos os par�metros de um objeto tipo Asteroide, e um 
terceiro que constr�i um asteroide com posi��o x e posi��o y. 
O programa principal (main) deve conter a lista de Asteroides, preenchida pelo usu�rio. Nesse programa principal, construir um m�todo de classe que exiba todos os
aster�ides da lista.

4) Crie uma classe para representar um item de cen�rio, com os atributos privados de:
    * descri��o (string), 
    * data de cria��o (date - https://docs.microsoft.com/en-us/dotnet/api/system.datetime.date?view=net-6.0) e
    * altura (float). 

Crie os m�todos p�blicos necess�rios para sets e gets, o construtor b�sico e tamb�m um m�todo para imprimir 
todos dados de um item de cen�rio. 
Por fim, crie um m�todo para calcular a quanto tempo o item foi criado, al�m de um programa em C# para testar
a classe criada.

5) Crie uma classe para representar um objeto em um Plano Cartesiano. Todo objeto no plano cartesiano
tem como atributos 'x' e 'y'. Dessa forma, crie os getters e setter de 'x' e 'y', o construtor b�sico e
um m�todo para exibir um objeto (x,y).
Por fim, crie um programa em C# que cadastre 'n' objetos em uma lista (List), um m�todo de que exiba
os objetos da lista.

6) Crie uma classe para funcion�rio. Ele deve ter o nome do funcion�rio, o departamento onde trabalha, seu sal�rio (double), a data de entrada no banco (String), seu RG (String) e um valor booleano que indique se o
funcion�rio ainda est� ativa na empresa no momento ou se j� foi mandado embora.
Voc� deve criar alguns m�todos de acordo com sua necessidade. Al�m deles, crie um m�todo bonifica que aumenta o salario do funcion�rio de acordo com o par�metro passado como argumento. Crie, tamb�m, um
m�todo demite, que n�o recebe par�metro algum, s� modifica o valor booleano indicando que o funcion�rio n�o trabalha mais aqui.
Crie uma lista de funcion�rios e fa�a um menu iterativo onde voc� pode inserir e consultar todos os funcion�rios cadastratos.

Utilizando o exerc�cio anterior, fa�a um m�todo abstrato na classe funcion�rio chamado "ExecutaTrabalho". Haver� duas implementa��es da classe Funcionario chamada de Gerente e Operador. 
Nos metodos de cada uma das classes Gerente e Operador dever� aparecer a mensagem informando qual � a fun��o desempenhada pelo funcion�rio

7) Crie um dicion�rio que fa�a o armazenamento de Livros. Os dados para serem armazenados ser�o o nome do livro e a quantidade de p�ginas. Em um menu inicial, possibilite que o usu�rio do sistema possa cadastrar, consultar todos livros cadastrados ou pesquisar pelo nome do livro.