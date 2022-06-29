using System;
using System.Collections.Generic;

namespace ORM.Entities
{
    public partial class Articulos
    {
        public int IdArticulo { get; set; }
        public string CodArticulo { get; set; }
        public string Nombre { get; set; }
        public string Estado { get; set; }
        public decimal? Costo { get; set; }
        public int IdProveedor { get; set; }

        public virtual Proveedores IdProveedorNavigation { get; set; }
    }
}
