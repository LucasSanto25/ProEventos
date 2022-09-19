using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {


        private readonly ILogger<EventoController> _logger;

        public IEnumerable<Evento> _evento = new Evento[]
        {
                new Evento(){
                EventoId = 1,
                Tema = "Angular 11 e .NET 5",
                Local = "Belo Horizonte",
                Lote = "1° lote",
                QtdPessoa = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                ImagemUrl = "Foto.png"
                },
                new Evento(){
                EventoId = 2,
                Tema = "Angular 11 e .NET 5 Ex2",
                Local = "Belo Horizonte",
                Lote = "1° lote",
                QtdPessoa = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                ImagemUrl = "Foto.png"
                }
        };


        public EventoController()
        {

        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }
        [HttpGet("{id}")]
        public IEnumerable<Evento> Get(int Id)
        {
            return _evento.Where(evento => evento.EventoId == Id);
        }




        [HttpPost]
        public String Post()
        {
            return "exemplo de post";
        }
    }
}
