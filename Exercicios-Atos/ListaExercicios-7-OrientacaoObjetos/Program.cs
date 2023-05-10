


namespace Exercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual dos contrutores você gostaria de utilizar ? ");
            Console.WriteLine("1 - Para Pessoa(string nome) ");
            Console.WriteLine("2 - Para Pessoa(int idade) ");
            Pessoa p;
            int input = int.Parse(Console.ReadLine());

            if(input == 1) p = new Pessoa(Console.ReadLine());
            else if (input == 2) p = new Pessoa(int.Parse(Console.ReadLine()));
            else Console.WriteLine("Insira um número válido!");

            Aluno a = new Aluno(new DateTime());
            a.DataIngresso = DateTime.Now;

            Produto prod = new Produto("pc", 7000, new Fabricante("positivo","c19239" ,"fodase town"));
            Console.WriteLine(prod.Nome);
            Console.WriteLine(prod.Fabricante.Cidade);
            Console.WriteLine(prod.Fabricante.Endereco);
            Console.WriteLine(prod.Fabricante.Nome);
        }
    }
}