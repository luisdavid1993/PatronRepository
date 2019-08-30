using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TT.Dto
{
    public class CP_ConsultarDatosProductoDto
    {
        public int IDATOSPRODUCTOID { get; set; }
        public string CHPRODUCTNUMBER { get; set; }
        public string IPRODUCTID { get; set; }
        public bool BENVIOPUBLICOLOCAL { get; set; }
        public bool BENVIOPUBLICOLD { get; set; }
        public bool BENVIOCORPLOCAL { get; set; }
        public bool BENVIOCORPLD { get; set; }
        public string VCHCOMENTARIOS { get; set; }
        public byte TIRECORDSTATUS { get; set; }
        public Nullable<int> IVENTAID { get; set; }
        public Nullable<int> ICOMPANYID { get; set; }
        public string VCHCOMPANYNAME { get; set; }
        public Nullable<int> ICOMPANYIDLOCAL { get; set; }
        public string VCHCOMPANYNAMELOCAL { get; set; }
        public string VCHDATAVALUECIUDAD { get; set; }
        public string VCHPARAMETERDESCCIUDAD { get; set; }
        public int IESTRATOCIUDADID { get; set; }
        public string VCHNOMBREESTRATO { get; set; }
        public int IUSOSERVICIOID { get; set; }
        public string VCHDESCRIPCIONUSO { get; set; }
        public string VCHCODIGOREGION { get; set; }
        public string TIPOTELEFONIA { get; set; }   
    }
}
