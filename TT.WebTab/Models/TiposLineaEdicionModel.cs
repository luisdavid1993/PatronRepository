using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TT.WebTab.Models
{
    public class TiposLineaEdicionModel
    {
        public int IdVenta { get; set; }
        [Display(Name ="Producto")]
        public int IdProducto { get; set; }
        [Display(Name ="Nombre Producto")]
        public string NombreProducto { get; set; }
        public int IdTipoLinea { get; set; }
        public bool TipoLineaSelected { get; set; }
        [Display(Name = "Tipo linea")]
        public string TipoDeLinea { get; set; }
        [Display(Name ="1")]
        public int CampoUno { get; set; }
        [Display(Name ="Canales Activos")]
        public int CanalesActivos { get; set; }
        [Display(Name ="1")]
        public int CampoDos { get; set; }
        [Display(Name ="2")]
        public int CampoTres { get; set; }
        [Display(Name ="Direccion IP")]
        public string DireccionIp { get; set; }
        [Display(Name = "Ciudad")]
        public string Ciudad { get; set; }
        public string SubRed { get; set; }
        public bool Publicar { get; set; }
        [Display(Name ="Comparte Numeracion")]
        public bool ComparteNumeracion { get; set; }
        [Display(Name ="Modelo Equipo")]
        public string ModeloEquipo { get; set; }
        [Display(Name = "Entrada / Salida")]
        public bool Entrada { get; set; }
        public string Puerto { get; set; }
        [Display(Name ="Numero Inicial")]
        public int NumeroInicial { get; set; }
        [Display(Name ="Numero Final")]
        public int NumeroFinal { get; set; }
        public int Troncal { get; set; }
        [Display(Name = "Número Corto")]
        public int ShortNumber { get; set; }
        public bool Exento { get; set; }
        [Display(Name ="Solicitud Opercion")]
        public string SolicitudOperacion { get; set; }
        [Display(Name ="Resultado Operacion")]
        public string ResultadoOpercion { get; set; }
        [Display(Name ="Comentario resultado")]
        public string ComentarioResultado { get; set; }
        [Display(Name ="Canales Entrantes")]
        public int CanalesEntrantes { get; set; }
        [Display(Name ="Canales Salientes")]
        public int CanalesSalientes { get; set; }

    }
}