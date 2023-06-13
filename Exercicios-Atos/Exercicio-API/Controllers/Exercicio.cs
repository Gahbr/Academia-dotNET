using Microsoft.AspNetCore.Mvc;

namespace Exercicio_API.Controllers;
[ApiController]
public class Exercicio :ControllerBase
{
    [HttpGet("nome")]
    public string Nome()
    {
        return "Meu nome é Gabriel";
    }

    [HttpGet("idade")]
    public int Idade()
    {
        return 26;
    }

    [HttpGet("nome/{nome}")]
    public string RetornaNome(string nome)
    {
        return $"Meu nome é {nome}";
    }

    [HttpGet("nome/{nome}/idade/{idade}")]
    public string NomeIdade(string nome, int idade)
    {
        string mensagem = idade >= 18 ? $"{nome} é maior de idade" : $"{nome} é menor de idade";

        return mensagem;
    }
}
