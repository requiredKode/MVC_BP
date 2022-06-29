using System;
using System.Collections.Generic;

namespace ORM.Entities
{
    public partial class Proveedores
    {
        public Proveedores()
        {
            Articulos = new HashSet<Articulos>();
        }

        public int IdProveedor { get; set; }
        public string CodProveedor { get; set; }
        public string Nombre { get; set; }
        public string Estado { get; set; }
        public string Cedula { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }

        public virtual ICollection<Articulos> Articulos { get; set; }
    }
}
