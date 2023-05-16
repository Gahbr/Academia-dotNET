//3) Imagine um jogo com asteroides e uma nave de ataque, que deve destruir os asteróides que voam em todas as direções. Dessa forma, crie um programa em C# que represente
//uma lista de asteroides que deveriam ser 'inseridos' no jogo. Para isso, faça uma classe que contenha os atributos (privados) posição x, posição y (do asteroide em
//um plano cartesiano), tamanho do asteroide (1 a 10), velocidade do asteroide (1 a 5) e energia(1 a 5). Para esses atributos privados, gerar os métodos de acesso
//(propriedades getter e setter). Além disso, implementar 3 construtores (sobrecarga): um vazio, outro passando todos os parâmetros de um objeto tipo Asteroide, e um 
//terceiro que constrói um asteroide com posição x e posição y. 
//O programa principal (main) deve conter a lista de Asteroides, preenchida pelo usuário. Nesse programa principal, construir um método de classe que exiba todos os
//asteróides da lista.

using System;

namespace ListaExercicios_8_Lista_Dicionario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Chame o exercicio aqui
            Exercicio04();
        }

        static void Exercicio01()
        {
            string nome;
            int poder;
            Personagem p;
            List<Personagem> list = new List<Personagem>();

            Console.WriteLine("Informe o nome e poder de 3 personagens");
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"--Personagem {i}--");
                Console.Write("Nome: ");
                nome = Console.ReadLine();
                Console.Write("Poder: ");
                poder = int.Parse(Console.ReadLine());
                p = new Personagem(nome, poder);
                list.Add(p);
            }
            
            var personagemMaisPoderoso = Personagem.GetPersonagemMaisPoderoso(list);
            Console.WriteLine(personagemMaisPoderoso);
        }

        static void Exercicio02()
        {
            string nome, tipo;
            int qtdGatos = 0, qtdCachorros = 0, qtdPeixes = 0;

            Console.WriteLine("Informe o nome e o tipo de 5 animais de estimação");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"--Animal {i}--");
                Console.Write("Nome: ");
                nome = Console.ReadLine();
                while (true)
                {
                    Console.Write("Tipo do animal - Cachorro, Gato, ou Peixe: ");
                    tipo = Console.ReadLine();

                    if (tipo.ToUpper() == "CACHORRO")
                    {
                        qtdCachorros++;
                        break;
                    }
                    if (tipo.ToUpper() == "GATO")
                    {
                        qtdGatos++;
                        break;
                    }
                    if (tipo.ToUpper() == "PEIXE")
                    {
                        qtdPeixes++;
                        break;
                    }
                }
            }
            Console.WriteLine($"Quantidade de Cachorros: {qtdCachorros}\nQuantidade de Gatos: {qtdGatos}\nQuantidade de Peixes: {qtdPeixes}");
        }

        static void Exercicio03()
        {
            List<Asteroide> lista = new List<Asteroide>();

            while (true)
            {
                Console.WriteLine("Insira os dados do asteróide");
                Console.Write("Posicao X:");
                int posicaoX = int.Parse(Console.ReadLine());

                Console.Write("Posicao Y:");
                int posicaoY = int.Parse(Console.ReadLine());

                Console.Write("Tamanho do asteróide (1 a 10): ");
                int tamanho = int.Parse(Console.ReadLine());
                Console.Write("Velocidade do asteróide (1 a 5):");
                int velocidade = int.Parse(Console.ReadLine());

                Console.Write("Energia do asteróide (1 a 5):");
                int energia = int.Parse(Console.ReadLine());

                lista.Add(new Asteroide(posicaoX, posicaoY, tamanho, velocidade, energia));

                Console.WriteLine("Deseja inserir outro asteróide? (Sim ou Não)");
                string opt = Console.ReadLine();
                if (opt.ToUpper() == "NÃO" || opt.ToUpper() == "NAO")
                {
                    break;
                }
            }

            Console.WriteLine("listando asteróides");
            Asteroide.ListarAsteroides(lista);
        }

        static void Exercicio04()
        {
            Console.WriteLine("Cenário");
            Console.Write("Insira a descrição do cenário:");
            string descricao = Console.ReadLine();

            Console.Write("Insira a altura do cenário:");
            float altura = float.Parse(Console.ReadLine());

            Cenario c = new Cenario(descricao, DateTime.Now, altura);

            DateTime dateTime = DateTime.Parse("2022-01-01 00:00:00");
            c.CalculoTempoCriacao(new DateTime(2022,01,20));

        }
    }
}