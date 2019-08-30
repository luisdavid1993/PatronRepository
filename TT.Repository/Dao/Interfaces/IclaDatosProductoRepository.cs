using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TT.Dto;

namespace TT.Repository.Dao.Interfaces
{
   public interface IclaDatosProductoRepository
    {
        CP_ConsultarDatosProductoDto MetConsultar(Nullable<int> iDatosProductoId);
        int MetInsertar(CP_ConsultarDatosProductoDto DatosProducto);
        int MetActualizar(CP_ConsultarDatosProductoDto DatosProducto);
        int BuscarTelefonia(Nullable<int> iVentaId);
        CP_ConsultaSerialNumberDto MeConsultaSerialNumber(int iProductId);
    }
}
