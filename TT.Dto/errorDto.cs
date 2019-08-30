using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TT.Dto
{
   public class errorDto
    {
        public string vchUsuario { get; set; }
        public DateTime dFechaCreacion { get; set; }
        public string vchMetodo { get; set; }
        public string vchMessageError { get; set; }
        public string vchInnerTracerError { get; set; }
    }
}
