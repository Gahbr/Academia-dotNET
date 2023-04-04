namespace Exercicio_Idade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Digite a idade e informe se é maior de idade ou não;
            Console.WriteLine("Insira a idade: ");
            int age = int.Parse(Console.ReadLine());

            if(age >= 18)
            {
                Console.WriteLine("É maior de idade");
            } else
            {
                Console.WriteLine("é menor de idade");
            }
           
            
        }

    }
}