using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using TT.Negocio.Logs;
using TT.WebTab.Models;

namespace TT.WebTab.Security
{
    public class CustAuthFilter : AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            //try {
            //    var _queryString = filterContext.HttpContext.Request.QueryString;
            //    if (_queryString.Keys[0] == "code") {
            //        VozIncidentModel v = new VozIncidentModel() { _IdAsunto = 1233446 };
            //        filterContext.HttpContext.Session["ParametrosEntradaIncidente"] = v;
            //    }
            //    else {
            //        if (filterContext.HttpContext.Session["ParametrosEntradaIncidente"] == null) {
            //            // redireccionar a otro lado 
            //            //o 
            //            //crear pop up diciendo que no tiene permisos para realizar acciones en tab de telefonia
            //        }
            //    }
            //}catch (Exception ex) {
            //    log.error(ex, "EJT4940A", "TabController - VozIncident");
            //}
            
        }
            
      }
    }
