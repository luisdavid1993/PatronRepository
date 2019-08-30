using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TT.Dto;

namespace TT.Repository.Dao.Interfaces
{
 public  interface IclaClienteTelefoniaRepository
    {
        List<CP_ConsultarClienteTelefoniaDto> MetConsultarxCliente(Nullable<int> iCompanyId);

        List<CT_LLenarTablaAsuntosModificaronDto> LLenarTablaAsuntosModificaron(int DetailId);

    }
}
