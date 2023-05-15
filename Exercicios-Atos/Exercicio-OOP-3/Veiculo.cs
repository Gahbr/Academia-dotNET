//Criar uma classe Veiculo que contém as propriedades Marca e Modelo. Criar duas classes derivadas, Carro e Moto, que herdam de Veiculo. A classe Carro deve ter uma propriedade adicional QuantidadeDePortas, enquanto a classe Moto deve ter uma propriedade adicional Cilindrada. Criar um método Dirigir na classe Veiculo que imprime "Dirigindo o <marca> <modelo>". Em seguida, criar um método Dirigir na classe Carro que imprime "Dirigindo o <marca> <modelo> com <quantidadeDePortas> portas" e um método Dirigir na classe Moto que imprime "Dirigindo a <marca> <modelo> com <cilindrada> cilindradas".

namespace Exercicio_OOP_3
{
    internal class Veiculo
    {
       public string Marca { get; set; }
       public string Modelo { get; set; }
        public virtual void Dirigir()
        {
            Console.WriteLine($"Dirigindo o {Marca} {Modelo}");
        }
    }
}
