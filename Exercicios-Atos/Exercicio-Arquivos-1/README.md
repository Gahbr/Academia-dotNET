- Orienta��o a Objetos
    - Heran�a: sobreescrita
    - Listas e cole��es (Listas, Filas, Pilhas, Arvores, Grafos, Hash....)
    - m�todos e atributos (inst�ncia/objeto ou classe)
        Console.WriteLine()
        String frase = "alexandre zamberlan;08/08/1974;masculino";
        String[] vetor = frase.Split(";");
- Arquivo texto
    - plain text
        - JSON ->  REST
        - XML -> SOAP
        - CSV
Sistema 
    - Backend ------> Frontend
        BD ====== Regras Negocio ====== N�vel do usu�rio

Desafio: Programa em C# no modo terminal, tendo como base o seguinte MENU.

Menu
1 - Cadastrar pessoa (controle de duplicidade: email)
2 - Listar pessoa
3 - Pesquisar pessoa (atributo nome)
4 - Excluir pessoa
5 - Sair
Op��o: 


Elementos necess�rios:
    Classe Pessoa(nome, email, dataNascimento(string))
        - m�todo para gerar o email da pessoa automaticamente: sobrenome_nome@ufn.edu.br
    Lista de Pessoas
        - ordena��o (Sort)
    Arquivo
        - texto puro -> csv ou seja, separado por ;
        - StreamReader (classe leitora)
        - StreamWriter (classe escritora)


    Cadastrar -> nome e dataNascimento -> constroi objeto com email gerado -> joga na lista -> atualizar arquivo
    Listar -> mostrar a lista
    Pesquisar -> percorrer a lista a procura de alguma pessoa
    Excluir -> pesquisar -> retirar da lista -> atualizar arquivo