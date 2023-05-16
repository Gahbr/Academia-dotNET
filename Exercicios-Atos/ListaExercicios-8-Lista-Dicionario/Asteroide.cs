//3) Imagine um jogo com asteroides e uma nave de ataque, que deve destruir os asteróides que voam em todas as direções. Dessa forma, crie um programa em C# que represente
//uma lista de asteroides que deveriam ser 'inseridos' no jogo. Para isso, faça uma classe que contenha os atributos (privados) posição x, posição y (do asteroide em
//um plano cartesiano), tamanho do asteroide (1 a 10), velocidade do asteroide (1 a 5) e energia(1 a 5). Para esses atributos privados, gerar os métodos de acesso
//(propriedades getter e setter). Além disso, implementar 3 construtores (sobrecarga): um vazio, outro passando todos os parâmetros de um objeto tipo Asteroide, e um 
//terceiro que constrói um asteroide com posição x e posição y. 
//O programa principal (main) deve conter a lista de Asteroides, preenchida pelo usuário. Nesse programa principal, construir um método de classe que exiba todos os
//asteróides da lista.

namespace ListaExercicios_8_Lista_Dicionario
{
    internal class Asteroide
    {
        public int PosicaoY { get; set; }
        public int PosicaoX { get; set; }
        public int Tamanho { get; set; }
        public int Velocidade { get; set; }
        public int Energia { get; set; }

        public Asteroide() { }
        public Asteroide(int posicaoX, int posicaoY, int tamanho, int velocidade, int energia) 
        {
            PosicaoY = posicaoY;
            PosicaoX = posicaoX;
            Tamanho = tamanho;
            Velocidade = velocidade;
            Energia = energia;
        }
        public Asteroide(int posicaoY, int posicaoX)
        {
            PosicaoY = posicaoY;
            PosicaoX = posicaoX;
        }

        public static void ListarAsteroides(List<Asteroide> asteroides)
        {
            foreach (var item in asteroides)
            {
                Console.WriteLine("---Asteróide---");
                Console.WriteLine($" Posicao X: {item.PosicaoX}");
                Console.WriteLine($" Posicao Y: {item.PosicaoY}");
                Console.WriteLine($" Velocidade: {item.Velocidade}");
                Console.WriteLine($" Energia: {item.Energia}");
                Console.WriteLine($" Tamanho: {item.Tamanho}");

            }
        }
    }
}
