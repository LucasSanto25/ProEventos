using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Data;
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
        #region Variaveis
        private readonly DataContext _context;
        private readonly ILogger<EventoController> _logger;
        #endregion
        

        public EventoController(DataContext context)
        {
            _context = context;

        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _context.Eventos ;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> Get(int Id)
        {
            return _context.Eventos.Where(evento => evento.EventoId == Id);
        }

        [HttpPost]
        public String Post()
        {
            return "exemplo de post";
        }
    }
}
