using System;
using System.Collections.Generic;

#nullable disable

namespace Entidades
{
    public partial class TbPersona
    {
        public string Id { get; set; }
        public int TipoId { get; set; }
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public DateTime FechaNac { get; set; }
        public string Direccion { get; set; }

        public virtual TbCliente TbCliente { get; set; }
    }
}
