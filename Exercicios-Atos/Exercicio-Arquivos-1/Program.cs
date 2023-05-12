namespace Exercicio_Arquivos_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> listaPessoas = new List<Pessoa>();
            string arquivo = "D:\\Programação\\CSharp\\Academia-dotNET\\Exercicios-Atos\\Exercicio-Arquivos-1\\ex.txt";

            Persistencia.popularArquivoLista(arquivo, listaPessoas);

           //Persistencia.gravarListaArquivo(listaPessoas, "D:\\Programação\\CSharp\\Academia-dotNET\\Exercicios-Atos\\Exercicio-Arquivos-1\\ex2.txt");
           //Persistencia.exibirLista(listaPessoas);

            int opcao;
            string nome, dataNascimento, email;
            Pessoa pessoa;
            while (true)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1 - Cadastrar pessoa(controle de duplicidade: email)");
                Console.WriteLine("2 - Listar pessoas");
                Console.WriteLine("3 - Pesquisar pessoa(atributo nome)");
                Console.WriteLine("4 - Excluir pessoa");
                Console.WriteLine("5 - Sair");
                Console.Write("Opção: ");

                opcao = int.Parse(Console.ReadLine());

                if(opcao == 1) 
                {
                    Console.Write("Nome: ");
                    nome = Console.ReadLine();
                    Console.Write("Data de nascimento: ");
                    dataNascimento = Console.ReadLine();
                    pessoa = new Pessoa(nome, dataNascimento);

                    Persistencia.AdicionarPessoaArquivo(listaPessoas, pessoa, arquivo);
                }

                if (opcao == 2) Persistencia.exibirLista(listaPessoas);

                if (opcao == 3)
                {
                    Console.Write("Nome: ");
                    Persistencia.procuraNomeLista(Console.ReadLine(), listaPessoas);
                }
                
                if(opcao == 4)
                {
                    Console.Write("Email da pessoa que irá ser deletada: ");
                    email = Console.ReadLine();
                    Persistencia.deletarPessoaArquivo(listaPessoas, email, arquivo);
                   
                }

                if(opcao == 5) {  break; }

            }              
        }
    }
}