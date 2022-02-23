using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FilmesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmeController : ControllerBase
    {
        private static List<Filme> filmes = new List<Filme>();
        private static int id = 1;

        [HttpPost]
        public IActionResult AdicionaFilme([FromBody] Filme filme)
        {
            filme.Id = id++;
            filmes.Add(filme);

            return CreatedAtAction(nameof(RecuperaFilme), new { Id = filme.Id }, filme);
        }

        [HttpGet]
        public IActionResult RecuperaFilme()
        {
            return Ok(filmes);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaFilmeById(int id)
        {
            var filme = filmes.FirstOrDefault(filme => filme.Id == id);

            if(filme != null)
            {
                return Ok(filme);
            }

            return NotFound();
        }
    
    }
}
