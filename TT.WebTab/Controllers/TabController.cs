using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TT.Dto;
using TT.Negocio;
using TT.WebTab.Models;
using TT.Uils.MapperBase;
using TT.Negocio.Logs;
using TT.WebTab.Security;

namespace TT.WebTab.Controllers
{
    public class TabController : Controller
    {

        [HttpPost]
        public ActionResult VozIncident(VozIncidentModel modelo)
        {
            try
            {
                int CodigoTelefonia = new claDatosProducto().BuscarTelefonia(modelo._IdAsunto);
                CP_ConsultarDatosProductoDto CP_ConsultarDatosProductoModel = null;
                if (ModelState.IsValid) {
                    CP_ConsultarDatosProductoModel = new claDatosProducto().MetConsultar(CodigoTelefonia);
                    CP_ConsultarDatosProductoModel.VCHCOMENTARIOS = modelo._Comentarios;
                    TempData["CP_ConsultarDatosProductoModel"] = CP_ConsultarDatosProductoModel;
                }
            } catch (Exception ex)
            {
                log.error(ex, "EJT4940A", "TabController - VozIncident");
                ViewBag.eror = new ErrorGeneralModel() { lugarError = "TabController - VozIncident" };
            }
            return RedirectToAction("DetalleDatosProducto");
        }
        
         public ActionResult DetalleDatosProducto(CP_UsersLogTabTelefonia _usersLogTabTelefonia) {
            CP_ConsultarDatosProductoDto CP_ConsultarDatosProductoModelBase = TempData["CP_ConsultarDatosProductoModel"] as CP_ConsultarDatosProductoDto;
            DetalleHeaderModel _DetalleHeaderModel = null;
            _DetalleHeaderModel = MapperConfigurationCentral<CP_ConsultarDatosProductoDto, DetalleHeaderModel>.MapEntity(CP_ConsultarDatosProductoModelBase);
            DetalleDatosProductoModel CP_ConsultarDatosProductoModelView = new DetalleDatosProductoModel();
            CP_ConsultarDatosProductoModelView._DetalleHeaderProductsModel = _DetalleHeaderModel;
            if (CP_ConsultarDatosProductoModelView._DetalleHeaderProductsModel == null){
                if (_usersLogTabTelefonia.vchDetailId == 0){
                    ViewBag._VozIncidentDto = MapperConfigurationCentral<CP_VozIncidentDto, VozIncidentModel>.MapEntity(new claClienteTelefonia().MetVozIncident(_usersLogTabTelefonia));
                }
                else if (_usersLogTabTelefonia.vchDetailId != 0 && !string.IsNullOrEmpty(_usersLogTabTelefonia.vchAlternateId)) {
                    // return redireciconar al controlador que pinte la pantalla segundaria 
                }
            }
            return View(CP_ConsultarDatosProductoModelView);

        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult DetalleDatosProducto(DetalleDatosProductoModel model)
        {
           if(String.IsNullOrEmpty(model._DetalleHeaderProductsModel.VCHDESCRIPCIONUSO) && String.IsNullOrEmpty(model._DetalleHeaderProductsModel.VCHNOMBREESTRATO))
            {
                //mensaje "Debe configurar el estrato y uso de servicio."
            }
            int respuesta = 0;
            CP_ConsultarDatosProductoDto ConsultarDatosProductoDto = null;
            ConsultarDatosProductoDto = MapperConfigurationCentral<DetalleDatosProductoModel,
                CP_ConsultarDatosProductoDto>.MapEntity(model);
            if(ConsultarDatosProductoDto.IPRODUCTID == null)
                ConsultarDatosProductoDto.IPRODUCTID = "0";

            if(ConsultarDatosProductoDto.CHPRODUCTNUMBER == null)
                ConsultarDatosProductoDto.CHPRODUCTNUMBER = "0";
            if (model._DetalleHeaderProductsModel.IDATOSPRODUCTOID == 0)
                respuesta = new claDatosProducto().MetInsertar(ConsultarDatosProductoDto);
           else
                respuesta = new claDatosProducto().MetActualizar(ConsultarDatosProductoDto);
           
            return View(model);

        }

        public ActionResult TiposLinea(DetalleDatosProductoModel model) {
            // para activar la parcial de tiposLinea

            var ObjetoNegocioTipoLinea = new TiposLinea();
            model._TiposLinea = new TiposLineaModel
            {
                AuxGrupoCentrex = ObjetoNegocioTipoLinea.ConsultaGrupoCentrex(),
                AuxCallSource = ObjetoNegocioTipoLinea.ConsultavchCallSource()
            };

            //Se hace un parseo de List a SelectListItem para enviarlo a la vista y pueda ser leido por el DropDawnList
            //model._TiposLinea.GrupoCentrex = auxGrupoCentrex.Select(x => new SelectListItem()
            //{
            //    Value = x,
            //    Text = x
            //}).ToList();

            //model._TiposLinea.CallSource = new List<SelectListItem>();
            //List<string> auxCallSource = ObjetoNegocioTipoLinea.ConsultavchCallSource();
            //foreach (string call in auxCallSource)
            //{
            //    model._TiposLinea.CallSource.Add(new SelectListItem
            //    {
            //        Text = call,
            //        Value = call
            //    });
            //}



            TiposLineaEdicionModel _TiposLineaEdicion = new TiposLineaEdicionModel();
            List<TiposLineaEdicionModel> listaLinea = new List<TiposLineaEdicionModel>();

            // Lleno una lista para que esta sea mostrada en la tabla
            listaLinea.Add(new TiposLineaEdicionModel
            {
                IdTipoLinea = 111,
                TipoLineaSelected = false,
                IdVenta = 1,
                CampoUno = 2,
                CanalesActivos = 3,
                CampoDos = 4,
                CampoTres = 5,
                DireccionIp = "123.0.0.1",
                Ciudad = "Bogota",
                SubRed = "23.56.89.12",
                Publicar = true,
                ComparteNumeracion = false,
                ModeloEquipo = "New",
                Entrada = true,
                Puerto = "9090",
                NumeroInicial = 1,
                NumeroFinal = 99,
                Troncal = 45,
                ShortNumber = 34,
                Exento = true,
                SolicitudOperacion = "New",
                ResultadoOpercion = "Old",
                ComentarioResultado = "No apply",
                CanalesEntrantes = 2,
                CanalesSalientes = 3
            });
            listaLinea.Add(new TiposLineaEdicionModel
            {
                IdTipoLinea = 222,
                TipoLineaSelected = false,
                IdVenta = 2,
                CampoUno = 2,
                CanalesActivos = 3,
                CampoDos = 4,
                CampoTres = 5,
                DireccionIp = "123.0.0.1",
                Ciudad = "Bogota",
                SubRed = "23.56.89.12",
                Publicar = true,
                ComparteNumeracion = false,
                ModeloEquipo = "New",
                Entrada = true,
                Puerto = "9090",
                NumeroInicial = 1,
                NumeroFinal = 99,
                Troncal = 45,
                ShortNumber = 34,
                Exento = true,
                SolicitudOperacion = "New",
                ResultadoOpercion = "Old",
                ComentarioResultado = "No apply",
                CanalesEntrantes = 2,
                CanalesSalientes = 3
            });
            listaLinea.Add(new TiposLineaEdicionModel
            {
                IdTipoLinea = 333,
                TipoLineaSelected = false,
                IdVenta = 3,
                CampoUno = 2,
                CanalesActivos = 3,
                CampoDos = 4,
                CampoTres = 5,
                DireccionIp = "123.0.0.1",
                Ciudad = "Bogota",
                SubRed = "23.56.89.12",
                Publicar = true,
                ComparteNumeracion = false,
                ModeloEquipo = "New",
                Entrada = true,
                Puerto = "9090",
                NumeroInicial = 1,
                NumeroFinal = 99,
                Troncal = 45,
                ShortNumber = 34,
                Exento = true,
                SolicitudOperacion = "New",
                ResultadoOpercion = "Old",
                ComentarioResultado = "No apply",
                CanalesEntrantes = 2,
                CanalesSalientes = 3
            });

            model._ListTiposLineaEdicion = listaLinea;

            model._TiposLineaEdicion = _TiposLineaEdicion;
            return View(model);
        }

        [HttpPost]
        public ActionResult TiposLinea(TiposLineaModel tipos)
        {
            
            if (ModelState.IsValid)
            {
                
            }
            return View(tipos);
        }
    }
}