using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ORM.SP
{
    //modelado del stored procedure de la base de datos de los datos que se necesitan obtener
    public partial class sp_lista_articulos_activos
    {
        [Key] /* Obligatorio una llave */
        public string cod_articulo { get; set; }
        public string nombreA { get; set; }
        public decimal costo { get; set; }
        public string cod_proveedor { get; set; }
        public string nombreP { get; set; }

    }
}
