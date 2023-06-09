using Microsoft.AspNetCore.Mvc;
using prueba.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace prueba2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class conversorController : ControllerBase
    {
        public readonly IConversor _conversor;
        public conversorController(IConversor conversor)
        {
            _conversor = conversor;
        }
        // GET api/<conversorController>/5
        [HttpGet("{valor}")]
        public double Get(double valor)
        {
            double result = _conversor.GetConversor(valor);

            return result;
        }

      
    }
}
