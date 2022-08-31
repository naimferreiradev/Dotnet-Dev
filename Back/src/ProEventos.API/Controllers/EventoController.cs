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

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {

       
    
        public IEnumerable <Eventos>_eventos = new Eventos[] {
           new Eventos() {
        
            EventoId = 1,
            Tema = "Angular",
            Local = "BH",
            Lote = "1º lote",
            QtdPessoa = 250, 
            DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
            ImagemURL = "foto.png"
                },

                 new Eventos() {
        
            EventoId = 2,
            Tema = "dotnet",
            Local = "SP",
            Lote = "2º lote",
            QtdPessoa = 350, 
            DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
            ImagemURL = "foto1.png"
                }
        };

         public EventoController()
        {
        }

        [HttpGet]
        public IEnumerable<Eventos> Get() 
        {
            return _eventos;
        }

        [HttpGet("{id}")]
        public IEnumerable<Eventos> GetById(int id)
        {
            return _eventos.Where(eventos => eventos.EventoId == id);
        }


        }
}