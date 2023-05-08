namespace Exercicio_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //Pessoa p = new Pessoa();
            //p.nome = Console.ReadLine();
            //Console.WriteLine("Digite a idade:");
            //p.idade = int.Parse(Console.ReadLine());

            //Console.WriteLine("A pessoa instanciada é " + p.nome);
            //Console.WriteLine($"E tem {p.idade} anos.");


            ////Exercicio 1
            //Carro c = new Carro();
            //Carro c2 = new Carro();

            //Console.WriteLine("Insira o carro 1 ");
            //Console.Write("insira a marca do carro 1:");
            //c.marca = Console.ReadLine();

            //Console.Write("insira o modelo do carro 1:");
            //c.modelo = Console.ReadLine();
            //Console.Write("insira o ano de fabricação do carro 1:");
            //c.anoFabricacao= int.Parse(Console.ReadLine());
            //c.exibeDados();

            //Console.WriteLine("Insira o carro 2 ");
            //Console.Write("insira a marca do carro 2:");
            //c2.marca = Console.ReadLine();

            //Console.Write("insira o modelo do carro 2:");
            //c2.modelo = Console.ReadLine();
            //Console.Write("insira o ano de fabricação do carro 2:");
            //c2.anoFabricacao = int.Parse(Console.ReadLine());

            //c2.exibeDados();
            //------------------------

            ////Exercício 2
            //Computador c1 = new Computador();
            //Computador c2 = new Computador();

            //Console.WriteLine("Insira o computador 1 ");
            //Console.Write("insira a marca do computador 1:");
            //c1.marca = Console.ReadLine();

            //Console.Write("insira o modelo do computador 1:");
            //c1.modelo = Console.ReadLine();
            //Console.Write("insira o preço do computador 1:");
            //c1.preco = double.Parse(Console.ReadLine());
            //c1.exibeDados();

            // Console.WriteLine("--Computador 2--");
            //c2.marca = "positivo";
            //c2.modelo = "Pc da xuxa";
            //c2.preco = 2555.00;
            //c2.exibeDados();

            ////Exercicio 3
            ////TODO - Solicite ao usuário qual dos construtores ele gostaria de utilizar na instanciação da classe. Além de receber parâmetros, os construtores imprimem na tela o conteúdo dos parâmetros recebidos.
            //Console.WriteLine("Qual dos construtores você deseja utilizar?\n1- para receber idade\n2- para receber idade e nome");
            //Pessoa p;
            //int input = int.Parse(Console.ReadLine());
            //if(input == 1)
            //{
            //    Console.WriteLine("Insira a idade:");
            //    p = new Pessoa(int.Parse(Console.ReadLine()));
            //    p.exibeIdade();

            //} else if (input == 2)
            //{
            //    Console.WriteLine("Insira o nome:");
            //    string nome = Console.ReadLine();
            //    Console.WriteLine("Insira a idade:");
            //    int idade = int.Parse(Console.ReadLine());

            //    p = new Pessoa(nome,idade);
            //    p.exibeDados();
            //    }

            //Exercicio 4 
            //Aluno a1 = new Aluno("20/01/2000");
            //Aluno a2 = new Aluno("Josilnelix", 928191);
            //Aluno a3 = new Aluno("Miltonilelison", "05/02/1969",2020);

           Carro c = new Carro();
            c.Marca = "VW";
            c.AnoFabricacao = 1999;
            c.Modelo = "Gol";
            c.Motor = new Motor();
            c.Motor.Cilindradas = 1500;
            c.LigarCarro();

        }
    }
}