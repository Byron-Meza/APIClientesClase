﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades.Excepciones
{
    public class EntityExistsException : Exception
    {
        public EntityExistsException(string message) : base(message)
        {

        }
    }
}
