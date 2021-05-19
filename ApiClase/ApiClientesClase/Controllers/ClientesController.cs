using Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Utilidades.Interface;

namespace ApiClientesClase.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        
        private readonly IGenericaServicios<TbCliente> context;

        public ClientesController(IGenericaServicios<TbCliente> _context)
        {
            context = _context;
        }

        //GET : api/
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var lista = await context.obtenerLista(1);

            return Ok(lista);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            try
            {
                if(id != string.Empty)
                {
                    TbCliente cliente = new TbCliente();
                    cliente.Id = id;

                    var lista = await context.obtenerPorID(cliente);
                    return Ok(lista);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
       
    }
}
