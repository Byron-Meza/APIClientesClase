using Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidades.Interface;

namespace CapaDatos
{
    public class ClienteDatos:IGenericaDatos<TbCliente>
    {
        private readonly dbMyBusAppContext context;

        public ClienteDatos(dbMyBusAppContext _context)
        {
            context = _context;
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
            return await context.TbClientes.ToListAsync();
        }

        public async Task<TbCliente> obtenerPorID(TbCliente entidad)
        {
            return await context.TbClientes.Include("TbPersona").AsNoTracking()
                .Where(x => x.Id == entidad.Id).SingleOrDefaultAsync();
        }
    }
}
