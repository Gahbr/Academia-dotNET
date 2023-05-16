//1) Implemente um programa em C# no qual o usuário deverá informar o nome e o poder (0 a 10) de três personagens. 
//O programa deverá informar o nome do personagem que possuir o maior poder.

//Regras que deverão ser seguidas para a implementação do algoritmo:

//É obrigatório o uso de classe para representar um Personagem e a mesma deverá possuir como propriedades (características) um nome e um poder.
//A classe também deverá possuir um método chamado ExibirDados. Esse método deverá exibir o nome e o poder do personagem em questão.
//Ao implementar a classe é obrigatório implementar dois construtores (Sobrecarga), um que não recebe parâmetro algum e outro que 
//irá receber o nome e o poder de um personagem
namespace ListaExercicios_8_Lista_Dicionario
{
    internal class Personagem
    {
        public string Nome { get; set; }
        public int Poder { get; set; }

        public Personagem() { }
        public Personagem(string nome, int poder)
        {
            Nome = nome;
            Poder = poder;
        }
        public void ExibirDados()
        {
            Console.WriteLine($"Nome : {Nome} - Poder : {Poder}");
        }

        public static string GetPersonagemMaisPoderoso(List<Personagem> personagens)
        {
            Personagem personagemMaisPoderoso = personagens[0]; // Assume the first personagem has the highest poder

            foreach (var personagem in personagens)
            {
                if (personagem.Poder > personagemMaisPoderoso.Poder)
                {
                    personagemMaisPoderoso = personagem;
                }
            }

            return $"Personagem mais poderoso:\nNome:{personagemMaisPoderoso.Nome} - Poder: {personagemMaisPoderoso.Poder}";
        }
    }
}
