using System;
using System.Collections.Generic;

#nullable disable

namespace Entidades
{
    public partial class ClientesPersona
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNac { get; set; }
        public int Membresia { get; set; }
    }
}
