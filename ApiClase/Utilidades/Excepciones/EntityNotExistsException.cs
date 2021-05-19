using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades.Excepciones
{
    public class EntityNotExistsException : Exception
    {
        public EntityNotExistsException(string message) : base(message)
        {

        }
    }
}
