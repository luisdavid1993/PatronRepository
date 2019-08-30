using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TT.Dto;

namespace TT.Repository.Dao.Interfaces
{
    public interface IcolEstratosRepository
    {
        List<CP_ConsultarUsoDto> ConsultarUso();
    }
}
