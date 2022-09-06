using System.Reflection.Emit;
using System.Net;
using System.Collections;
using System.Runtime.Serialization;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Reflection;
using System.Diagnostics.Tracing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.Domain;
using  ProEventos.Persistence;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventosController : ControllerBase
    {
        private readonly ProEventosContext _context;

         public EventosController( ProEventosContext context)
        {
                _context = context;
        }

        [HttpGet]
        public IEnumerable<Evento> Get() 
        {
            return _context.Evento;
        }

        [HttpGet("{id}")]
        public Evento Get(int id)
        {
            return _context.Eventos.FirstOrDefault(
                evento => evento.Id == id);
        }

        [HttpPost]
        public string Post() 
        {
            return "Exemplo de Post";
        }

        }


}