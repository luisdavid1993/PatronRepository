using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TT.WebTab.Models
{
    public class VozIncidentModel
    {
        [Required]
        [Display(Name ="Id asunto :")]
        public Nullable<int> _IdAsunto { get; set; }
        public Nullable<int> _IdProducto { get; set; }
        public Nullable<int> _CodigoEnlace { get; set; }
        public string _Producto { get; set; }
        public string _Comentarios { get; set; }
    }
}