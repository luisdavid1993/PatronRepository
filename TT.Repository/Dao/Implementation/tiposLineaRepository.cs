using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TT.AdoNetEntity;
using TT.Repository.Dao.Interfaces;

namespace TT.Repository.Dao.Implementation
{
    public class tiposLineaRepository : ItiposLineaRepository
    {
        public List<string> CP_ConsultaGrupoCentrex(){
            try
            {
                using (OnyxEntities db = new OnyxEntities()){
                    List<string> _GrupoCentrex = db.CP_ConsultaGrupoCentrex().ToList();
                    return _GrupoCentrex;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<string> CP_ConsultavchCallSource()
        {
            using (OnyxEntities db = new OnyxEntities()) {
                List<string> _vchCallSource = db.CP_ConsultavchCallSource().ToList();
                return _vchCallSource;
            }
        }
    }
}
