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
  public class claDatosProducto
    {


        public int BuscarTelefonia(Nullable<int> iVentaId)
        {
            IclaDatosProductoRepository DatoTelefonia = new claDatosProductoRepository();
            int CodigoTelefonia = DatoTelefonia.BuscarTelefonia(iVentaId);
            return CodigoTelefonia;   
        }

        public CP_ConsultarDatosProductoDto MetConsultar(Nullable<int> iDatosProductoId)
        {
            IclaDatosProductoRepository DatosProducto = new claDatosProductoRepository();
             CP_ConsultarDatosProductoDto listaDP = DatosProducto.MetConsultar(iDatosProductoId);
            return listaDP;
        }

        public int MetInsertar(CP_ConsultarDatosProductoDto ObjDatosProducto)
        {
            IclaDatosProductoRepository DatosProducto = new claDatosProductoRepository();
            int retorno = DatosProducto.MetInsertar(ObjDatosProducto);
            return retorno;
        }

        public int MetActualizar(CP_ConsultarDatosProductoDto ObjDatosProducto)
        {
            IclaDatosProductoRepository DatosProducto = new claDatosProductoRepository();
            int retorno = DatosProducto.MetActualizar(ObjDatosProducto);
            return retorno;
        }

        public CP_ConsultaSerialNumberDto ConsultaSerialNumber(int iProductId)
        {
            IclaDatosProductoRepository _ClienteTelefonia = new claDatosProductoRepository();
            CP_ConsultaSerialNumberDto ConsultaSerialNumber = _ClienteTelefonia.MeConsultaSerialNumber(iProductId);
            return ConsultaSerialNumber;
        }

    }
}
