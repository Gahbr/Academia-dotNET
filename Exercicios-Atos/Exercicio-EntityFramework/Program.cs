using Exercicio_EntityFramework.DataModels;
using Microsoft.EntityFrameworkCore;

namespace Exercicio_EntityFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite:\n" +
                  "1 para criar uma pessoa\n" +
                  "2 para alterar o nome da pessoa\n" +
                  "3 para inserir um email\n" +
                  "4 para excluir uma pessoa\n" +
                  "5 para consultar TUDO\n" +
                  "6 para consultar pelo ID"
                  );

            int op = int.Parse(Console.ReadLine());
            Context contexto = new Context();


            switch (op)
            {
                case 1:
                    try
                    {
                        Console.WriteLine("Insera o nome da pessoa:");
                        Pessoa p = new Pessoa();
                        p.nome = Console.ReadLine();

                        Console.WriteLine("Insira um email:");
                        string emailTemp = Console.ReadLine();
                        p.email = emailTemp;
                        p.Emails = new List<Email>()
                        {
                            new Email()
                            {
                                email = emailTemp
                            }
                        };

                        contexto.Pessoas.Add(p);
                        contexto.SaveChanges();

                        Console.WriteLine("Pessoa inserida com sucesso!");

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                    break;
                case 2:
                    Console.Clear();
                    try
                    {
                        Console.WriteLine("Informe o ID da pessoa: ");
                        int idPessoa = int.Parse(Console.ReadLine());

                        Pessoa? pAlt = contexto.Pessoas.Find(idPessoa);

                        if (pAlt == null)
                        {
                            Console.WriteLine("Id não encontrado! Pressione qualquer tecla para voltar");
                            Console.ReadKey();
                            break;
                        }

                        Console.WriteLine("\nID: " + pAlt.id + "\nNome Atual: " + pAlt.nome);
                        Console.WriteLine("\nInforme o nome correto: ");
                        pAlt.nome = Console.ReadLine();

                        contexto.Pessoas.Update(pAlt);
                        contexto.SaveChanges();
                        Console.WriteLine("Alterações Feitas com Sucesso");
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                    break;
                case 3:
                    Console.Clear();
                    try
                    {
                        Console.WriteLine("Informe o ID da pessoa:");
                        int id = int.Parse(Console.ReadLine());

                        Pessoa? p = contexto.Pessoas.Find(id);

                        Console.WriteLine("Informe o novo email:");

                        Email e = new Email();
                        e.email = Console.ReadLine();

                        p.Emails.Add(e);

                        contexto.Pessoas.Update(p);
                        contexto.SaveChanges();

                        Console.WriteLine("Email inserido com sucesso!");
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                    break;
                case 4:
                    try
                    {
                        Console.WriteLine("Informe o ID para exclusão:");
                        int id = int.Parse(Console.ReadLine());
                        Pessoa p = contexto.Pessoas.Find(id);

                        Console.WriteLine("Confirmar a exclusão de " + p.nome);
                        Console.WriteLine("E dos seus emails?");

                        foreach (Email item in p.Emails)
                        {
                            Console.WriteLine("\t" + item.email);
                        }

                        Console.WriteLine("1 para SIM e 2 para NÃO");

                        if (int.Parse(Console.ReadLine()) == 1)
                        {
                            contexto.Pessoas.Remove(p);
                            contexto.SaveChanges();
                            Console.WriteLine("Excluido com sucesso!");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case 5:
                    List<Pessoa> pessoas = (from Pessoa p in contexto.Pessoas select p)
                                    .Include(pes => pes.Emails).ToList<Pessoa>();

                    foreach (Pessoa item in pessoas)
                    {
                        Console.WriteLine(item.id + " - " + item.nome);

                        foreach (Email itemE in item.Emails)
                        {
                            Console.WriteLine("\t" + itemE.email);
                        }

                        Console.WriteLine();
                    }
                    break;
                case 6:
                    Console.WriteLine("Informe o ID da Pessoa:");
                    int idP = int.Parse(Console.ReadLine());

                    //Pessoa pessoa = contexto.Pessoas.Include(p=> p.emails)
                    //    .Where(p => p.id == id).FirstOrDefault();

                    Pessoa pessoa = contexto.Pessoas.Include(p => p.Emails)
                                        .FirstOrDefault(x => x.id == idP);

                    Console.WriteLine(pessoa.id + " - " + pessoa.nome);

                    foreach (Email item in pessoa.Emails)
                    {
                        Console.WriteLine("\t" + item.email);
                    }

                    break;
                default:
                    break;
            }
        }
    }
}