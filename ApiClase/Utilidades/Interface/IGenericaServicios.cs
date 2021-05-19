using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades.Interface
{
    public interface IGenericaServicios<E>
    {
        Task<E> obtenerPorID(E entidad);
        Task<E> guardar(E entidad);
        Task<IEnumerable<E>> obtenerLista(int estado);
        Task<E> eliminar(E entidad);
        Task<E> modificar(E entidad);
    }
}
