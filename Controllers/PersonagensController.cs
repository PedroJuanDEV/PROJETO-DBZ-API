using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI.Data;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonagensController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public PersonagensController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Personagem personagem)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            {
            _appDbContext.Personagens.Add(personagem);
            await _appDbContext.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = personagem.Id }, personagem);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Personagem>>> Get()
        {
            var personagens = await _appDbContext.Personagens.ToListAsync();
            return Ok(personagens);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Personagem personagemAtualizado)
        {
            var personagemExistente = await _appDbContext.Personagens.FindAsync(id);

            if (personagemExistente == null)
            {
                return NotFound("Personagem não encontrado");
            }

            personagemExistente.Nome = personagemAtualizado.Nome;
            personagemExistente.Tipo = personagemAtualizado.Tipo;

            await _appDbContext.SaveChangesAsync();

            return Ok(personagemExistente);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var personagem = await _appDbContext.Personagens.FindAsync(id);

            if (personagem == null)
            {
                return NotFound("Personagem não encontrado");
            }

            _appDbContext.Personagens.Remove(personagem);
            await _appDbContext.SaveChangesAsync();

            return NoContent();
        }
    }
}