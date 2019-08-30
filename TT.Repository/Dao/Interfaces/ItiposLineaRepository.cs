using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TT.Repository.Dao.Interfaces
{
   public interface ItiposLineaRepository
    {
        List<string> CP_ConsultavchCallSource();
        List<string> CP_ConsultaGrupoCentrex();
    }
}
