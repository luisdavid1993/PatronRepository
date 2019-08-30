using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TT.WebTab.Models
{
    public class DetalleDatosProductoModel{
        public DetalleHeaderModel _DetalleHeaderProductsModel { get; set; }
        public TiposLineaEdicionModel _TiposLineaEdicion { get; set; }
        public List<TiposLineaEdicionModel> _ListTiposLineaEdicion { get; set; }
        public TiposLineaModel _TiposLinea { get; set; }
    }
}