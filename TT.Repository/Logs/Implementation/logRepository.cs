using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TT.AdoNetEntity;
using TT.Dto;
using TT.Repository.Logs.Interfaces;

namespace TT.Repository.Logs.Implementation
{
    public class logRepository : IlogRepository
    {
        public void error(errorDto _error) {
            Task.Run(() => insertarLogError(_error));
        }

        public void trazaApi(errorDto _error)
        {
            throw new NotImplementedException();
        }

        private void insertarLogError(errorDto _error) {
            try{
                using (OnyxEntities db = new OnyxEntities()){
                    db.CP_LogErrorTabTelefonia_Insertar(_error.vchUsuario, _error.vchMetodo,_error.vchMessageError,_error.vchInnerTracerError);
                }
            }
            catch (Exception ex){
                throw ex;
            }

        }
    }
}
