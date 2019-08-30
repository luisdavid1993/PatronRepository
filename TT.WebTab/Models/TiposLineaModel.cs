using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TT.WebTab.Models
{
    public class TiposLineaModel
    {
        [Required]
        [Display(Name = "Call Source")]
        public string CallSource { get; set; }
        [Required]
        [Display(Name = "Grupo Centrex")]
        public string GrupoCentrex { get; set; }
        public List<string> AuxCallSource { get; set; }
        public List <string> AuxGrupoCentrex { get; set; }
    }
}