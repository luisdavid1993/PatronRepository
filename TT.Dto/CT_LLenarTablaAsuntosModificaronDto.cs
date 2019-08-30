using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TT.Dto
{
   public class CT_LLenarTablaAsuntosModificaronDto
    {
        public int iDatosProductoId { get; set; }
        public int iIncidentId { get; set; }
        public DateTime dtFechaModificacion { get; set; }
        public string vchDesc1 { get; set; }
        public string vchParameterDesc { get; set; }
        public string vchParameterDescProducto { get; set; }
    }
}
