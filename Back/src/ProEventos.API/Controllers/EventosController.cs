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
using ProEventos.API.Models;
using  ProEventos.API.Data;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventosController : ControllerBase
    {
        private readonly DataContext _context;

         public EventosController( DataContext context)
        {
                _context = context;
        }

        [HttpGet]
        public IEnumerable<Eventos> Get() 
        {
            return _context.Eventos;
        }

        [HttpGet("{id}")]
        public Eventos Get(int id)
        {
            return _context.Eventos.FirstOrDefault(
                evento => evento.EventosId == id);
        }

        [HttpPost]
        public string Post() 
        {
            return "Exemplo de Post";
        }

        }


}