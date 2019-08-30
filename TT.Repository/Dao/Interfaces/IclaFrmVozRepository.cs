using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TT.Dto;

namespace TT.Repository.Dao.Interfaces
{
    interface IclaFrmVozRepository{
        CT_LLenarTablaAsuntosModificaronDto ConsultaLLenarTablaAsuntosModificaron(int DetailId);
    }
}
