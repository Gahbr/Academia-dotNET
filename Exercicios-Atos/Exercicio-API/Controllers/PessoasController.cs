using Exercicio_API.DataModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Exercicio_API.Controllers;

[ApiController]
public class PessoasController : ControllerBase
{
    [HttpGet]
    [Route("pessoas")]
    public async Task<IActionResult> getAllAsync([FromServices] Context contexto)
    {
        var pessoas = await contexto
            .Pessoas
            .AsNoTracking()
            .ToListAsync();

        return pessoas == null ? NotFound() : Ok(pessoas);
    }


    [HttpPost]
    [Route("pessoas")]
    public async Task<IActionResult> PostAsync
        (
        [FromServices] Context contexto,
        [FromBody] Pessoa pessoa
        )
    {
        try
        {
            contexto.Pessoas.AddAsync(pessoa);
            await contexto.SaveChangesAsync();
            return Created($"api/pessoas/{pessoa.id}", pessoa);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPut]
    [Route("pessoas/{id}")]
    public async Task<IActionResult> PutAsync
        (
        [FromServices] Context contexto,
        [FromBody] Pessoa pessoa,
        [FromRoute] int id
        )
    {
        if(!ModelState.IsValid) return BadRequest("Model invalida");

        var p = await contexto.Pessoas.FirstOrDefaultAsync(x => x.id == id);

        if (p == null) return BadRequest("Pessoa nao encontrada");

        try
        {
            p.nome = pessoa.nome;
            p.email = pessoa.email;

            contexto.Pessoas.Update(p);
            await contexto.SaveChangesAsync();
            return Ok();
        }catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpDelete]
    [Route("pessoas/{id}")]
    public async Task<IActionResult> DeleteAsync
    (
    [FromServices] Context contexto,
    [FromRoute] int id
    )
    {
        if (!ModelState.IsValid) return BadRequest("Model invalida");

        var p = await contexto.Pessoas.FirstOrDefaultAsync(x => x.id == id);

        if (p == null) return BadRequest("Pessoa nao encontrada");

        try
        {
            contexto.Pessoas.Remove(p);
            await contexto.SaveChangesAsync();
            return Ok();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
