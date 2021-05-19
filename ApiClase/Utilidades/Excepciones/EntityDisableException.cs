using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades.Excepciones
{
    public class EntityDisableException : Exception
    {
        public EntityDisableException(string message) : base(message)
        {

        }
    }
}
