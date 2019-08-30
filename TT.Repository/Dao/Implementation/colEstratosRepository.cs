using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TT.Repository.Dao.Interfaces;
using TT.Dto;
using TT.AdoNetEntity;
using TT.Uils.MapperBase;

namespace TT.Repository.Dao.Implementation
{
    public class colEstratosRepository : IcolEstratosRepository
    {
        public List<CP_ConsultarUsoDto> ConsultarUso()
        {
            using (OnyxEntities db = new OnyxEntities())
            {
                List<CP_ConsultarUsoDto> ConsultarUso = MapperConfigurationCentral
                                                        <CP_ConsultarUso_Result,
                                                        CP_ConsultarUsoDto>.MapListList
                                                        (db.CP_ConsultarUso().ToList());
                return ConsultarUso;
            }
        }
    }
}
