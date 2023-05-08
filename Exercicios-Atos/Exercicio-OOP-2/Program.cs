namespace Exercicio_OOP_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Paciente p = new Paciente("asdjasd", "asdad", "asdasd", "asdasd");
            p.DataNascimento = "data";
            Console.WriteLine(p.DataNascimento);
        }
    }
}