using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TT.AdoNetEntity;
using TT.Dto;
using TT.Repository.Dao.Interfaces;
using TT.Uils.MapperBase;

namespace TT.Repository.Dao.Implementation
{
    public class claClienteTelefoniaRepository : IclaClienteTelefoniaRepository
    {
        public List<CT_LLenarTablaAsuntosModificaronDto> LLenarTablaAsuntosModificaron(int DetailId)
        {
            try {
                using (OnyxEntities db = new OnyxEntities()){
                    List<CT_LLenarTablaAsuntosModificaronDto> _LLenarTablaAsuntosModificaron = MapperConfigurationCentral<CP_LLenarTablaAsuntosModificaron_Result, CT_LLenarTablaAsuntosModificaronDto>.MapListList(db.CP_LLenarTablaAsuntosModificaron(DetailId).ToList());
                    return _LLenarTablaAsuntosModificaron;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<CP_ConsultarClienteTelefoniaDto> MetConsultarxCliente(Nullable<int> iCompanyId)
        {
            try {
                using (OnyxEntities db = new OnyxEntities()){
                    List<CP_ConsultarClienteTelefoniaDto> CP_ConsultarClienteTelefoniavalues = MapperConfigurationCentral<CP_ConsultarClienteTelefonia_Result,CP_ConsultarClienteTelefoniaDto>.MapListList(db.CP_ConsultarClienteTelefonia(iCompanyId).ToList());
                    return CP_ConsultarClienteTelefoniavalues;
                }
            }
            catch (Exception ex) {
                throw ex;
            }
        }
    }
}
