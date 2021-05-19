using System;
using Utilidades.Interface;
using Entidades;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Servicios
{
    public class ClienteServicios:IGenericaServicios<TbCliente>
    {
        private readonly IGenericaDatos<TbCliente> context;

        public ClienteServicios(IGenericaDatos<TbCliente> _context)
        {
            this.context = _context;
        }

        public Task<TbCliente> eliminar(TbCliente entidad)
        {
            throw new NotImplementedException();
        }

        public Task<TbCliente> guardar(TbCliente entidad)
        {
            throw new NotImplementedException();
        }

        public Task<TbCliente> modificar(TbCliente entidad)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<TbCliente>> obtenerLista(int estado)
        {
            return await context.obtenerLista(estado);
        }

        public async Task<TbCliente> obtenerPorID(TbCliente entidad)
        {
            return await context.obtenerPorID(entidad);
        }
    }
}
