using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using prueba.Model;
using prueba.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace prueba2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class diccionarioController : ControllerBase
    {
        public readonly IDiccionario _diccionario;
        public diccionarioController(IDiccionario diccionario)
        {
            _diccionario= diccionario;
        }
        // GET api/<diccionarioController>/5
        [HttpGet("{palabra}")]
        public string Get(string palabra)
        {
           var respuesta = _diccionario.GetMeanings(palabra).ToString();
            return  respuesta;
        }
    }
}
