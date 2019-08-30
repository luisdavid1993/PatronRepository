using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TT.Repository.Dao.Implementation;
using TT.Repository.Dao.Interfaces;

namespace TT.Negocio
{
   public class TiposLinea{

        public List<string> ConsultaGrupoCentrex()
        {
            try {
                ItiposLineaRepository _tiposLineaRepository = new tiposLineaRepository();
                return _tiposLineaRepository.CP_ConsultaGrupoCentrex();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<string> ConsultavchCallSource()
        {
            ItiposLineaRepository _tiposLineaRepository = new tiposLineaRepository();
            return _tiposLineaRepository.CP_ConsultavchCallSource();
        }
    }
}
