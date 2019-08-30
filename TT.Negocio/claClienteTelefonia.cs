using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TT.Dto;
using TT.Repository.Dao.Implementation;
using TT.Repository.Dao.Interfaces;

namespace TT.Negocio
{
   public class claClienteTelefonia
    {
        public List<CP_ConsultarClienteTelefoniaDto> MetConsultarxCliente(Nullable<int> iCompanyId) {
            IclaClienteTelefoniaRepository _claClienteTelefoniaRepository = new claClienteTelefoniaRepository();
            return _claClienteTelefoniaRepository.MetConsultarxCliente(iCompanyId);
        }
        /// <summary>
        /// Opcion 1 cuando no se ha realizado la configuracion el tab de telefonia
        /// </summary>
        /// <param name="_usersLogTabTelefonia"></param>
        /// <returns></returns>
        public CP_VozIncidentDto MetVozIncident(CP_UsersLogTabTelefonia _usersLogTabTelefonia) {
            try { 
                CP_VozIncidentDto _VozIncidentDto = new CP_VozIncidentDto();
                if (!string.IsNullOrEmpty(_usersLogTabTelefonia.vchAlternateId)){
                    if (_usersLogTabTelefonia.vchAlternateId.Substring(0, 3) == "CRM")
                    {
                        _VozIncidentDto._IdAsunto = Convert.ToInt32(_usersLogTabTelefonia.vchAlternateId.Substring(3, (_usersLogTabTelefonia.vchAlternateId.Length - 3)));
                        _VozIncidentDto._IdProducto = null;
                        _VozIncidentDto._CodigoEnlace = null;
                    }
                }
                return _VozIncidentDto;
            } catch (Exception ex) {
                    throw ex;
            }
        }

        /// <summary>
        /// Llena la tabla de asuntos que se pueden editar
        /// </summary>
        /// <param name="DetailId"></param>
        /// <returns></returns>
        public List<CT_LLenarTablaAsuntosModificaronDto> LLenarTablaAsuntosModificaron(int DetailId)
        {
            try{
                IclaClienteTelefoniaRepository _claClienteTelefoniaRepository = new claClienteTelefoniaRepository();
                return _claClienteTelefoniaRepository.LLenarTablaAsuntosModificaron(DetailId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
