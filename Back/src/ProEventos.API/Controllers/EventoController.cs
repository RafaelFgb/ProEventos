using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public EventoController()
        {
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return new Evento[]
            {
                new Evento()
                {
                    EventoId = 1,
                    Local = "Belo Horizonte",
                    DataEvento = DateTime.Now.ToString(),
                    Tema = "Angular 11 e .NET 5",
                    QtdPessoas = 250,
                    Lote = "1º Lote",
                    ImagemURL = "foto.jpg"
                },
                new Evento()
                {
                    EventoId = 2,
                    Local = "Fortaleza",
                    DataEvento = DateTime.Now.ToString(),
                    Tema = "Angular 11 e suas novidades",
                    QtdPessoas = 350,
                    Lote = "2º Lote",
                    ImagemURL = "foto.jpg"
                }
            };
        }

        [HttpPost]
        public string Post()
        {
            return "exemplo de POST";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return "exemplo de PUT com id = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return "exemplo de DELETE com id = {id}";
        }
    }
}
