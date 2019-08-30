using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TT.Dto;
using TT.Repository.Logs.Implementation;
using TT.Repository.Logs.Interfaces;

namespace TT.Negocio.Logs
{
  public static class log
    {
        public static void error(Exception ex,string usuario, string metodo) {
            errorDto _error = new errorDto();
            _error.vchUsuario = usuario;
            _error.vchMetodo = metodo;
            _error.vchMessageError = ex.Message;
            _error.vchInnerTracerError = ex.StackTrace.ToString();
            IlogRepository _logError = new logRepository();
            _logError.error(_error);
        }
    }
}
