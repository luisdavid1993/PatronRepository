using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TT.Dto
{
   public class CP_VozIncidentDto
    {
        public Nullable<int> _IdAsunto { get; set; }
        public Nullable<int> _IdProducto { get; set; }
        public Nullable<int> _CodigoEnlace { get; set; }
        public string _Producto { get; set; }
        public string _Comentarios { get; set; }
    }
}
