using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TT.Dto;
using TT.Repository.Dao.Implementation;
using TT.Repository.Dao.Interfaces;


namespace TT.Negocio
{
    public class colEstratos
    {
        public CP_ConsultarDatosProductoDto MetConsultar(Nullable<int> iDatosProductoId)
        {
            IclaDatosProductoRepository DatosProducto = new claDatosProductoRepository();
            CP_ConsultarDatosProductoDto listaDP = DatosProducto.MetConsultar(iDatosProductoId);
            return listaDP;
        }

        public List<CP_ConsultarUsoDto> ConsultarUso()
        {
            IcolEstratosRepository Uso = new colEstratosRepository();
            List<CP_ConsultarUsoDto> ListaUso = Uso.ConsultarUso();
            return ListaUso;
        }
    }
}
