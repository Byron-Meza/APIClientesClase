using System;
using System.Collections.Generic;

#nullable disable

namespace Entidades
{
    public partial class TbCliente
    {
        public string Id { get; set; }
        public int TipoId { get; set; }
        public int Membresia { get; set; }
        public int TipoCliente { get; set; }
        public bool? Estado { get; set; }

        public virtual TbPersona TbPersona { get; set; }
    }
}
