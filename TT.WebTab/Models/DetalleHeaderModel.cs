using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TT.WebTab.Models
{
    public class DetalleHeaderModel
    {
        public int IDATOSPRODUCTOID { get; set; }
        public string CHPRODUCTNUMBER { get; set; }
        public string IPRODUCTID { get; set; }
        public bool BENVIOPUBLICOLOCAL { get; set; }
        public bool BENVIOPUBLICOLD { get; set; }
        public bool BENVIOCORPLOCAL { get; set; }
        public bool BENVIOCORPLD { get; set; }
        [Display(Name = "Comentarios")]
        public string VCHCOMENTARIOS { get; set; }
        public byte TIRECORDSTATUS { get; set; }
        [Display(Name = "Id Venta")]
        public Nullable<int> IVENTAID { get; set; }
        [Display(Name = "Id Cliente")]
        public Nullable<int> ICOMPANYID { get; set; }
        [Display(Name = "Cliente")]
        public string VCHCOMPANYNAME { get; set; }
        [Display(Name = "Sede")]
        public Nullable<int> ICOMPANYIDLOCAL { get; set; }
        [Display(Name = "Dirección")]
        public string VCHCOMPANYNAMELOCAL { get; set; }
        [Display(Name = "Codigo")]
        public string VCHDATAVALUECIUDAD { get; set; }
        [Display(Name = "Ciudad")]
        public string VCHPARAMETERDESCCIUDAD { get; set; }
        [Display(Name = "Id Estrado")]
        public int IESTRATOCIUDADID { get; set; }
        [Display(Name = "Estrato")]
        public string VCHNOMBREESTRATO { get; set; }
        [Display(Name = "Enlace")]
        public int IUSOSERVICIOID { get; set; }
        [Display(Name = "Uso")]
        public string VCHDESCRIPCIONUSO { get; set; }
        [Display(Name = "Codigo")]
        public string VCHCODIGOREGION { get; set; }
        public string TIPOTELEFONIA { get; set; }
    }
}