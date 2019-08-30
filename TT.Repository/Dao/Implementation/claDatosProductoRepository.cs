using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TT.AdoNetEntity;
using TT.Dto;
using TT.Repository.Dao.Interfaces;
using TT.Uils.MapperBase;

namespace TT.Repository.Dao.Implementation
{
    public class claDatosProductoRepository : IclaDatosProductoRepository
    {
        public CP_ConsultarDatosProductoDto MetConsultar(Nullable<int> iDatosProductoId)
        {
            using (OnyxEntities db = new OnyxEntities())
            {
                CP_ConsultarDatosProductoDto CP_ConsultarDatosProductoDtoValues = MapperConfigurationCentral
                                                                                               <CP_CONSULTARDATOSPRODUCTO_Result,
                                                                                               CP_ConsultarDatosProductoDto>.MapEntity
                                                                                               (db.CP_CONSULTARDATOSPRODUCTO(iDatosProductoId).ToList().FirstOrDefault());
                return CP_ConsultarDatosProductoDtoValues;

            }
        }
        public int MetActualizar(CP_ConsultarDatosProductoDto DatosProducto)
        {
            using (OnyxEntities db = new OnyxEntities())
            {
                var retorno = db.CP_ACTUALIZARDATOSPRODUCTO(DatosProducto.IDATOSPRODUCTOID,
                    DatosProducto.IPRODUCTID, "p_CHPRODUCTNUMBER", DatosProducto.BENVIOPUBLICOLOCAL,
                    DatosProducto.BENVIOPUBLICOLD, DatosProducto.BENVIOCORPLOCAL, DatosProducto.BENVIOCORPLOCAL,
                    DatosProducto.ICOMPANYID, DatosProducto.ICOMPANYIDLOCAL, DatosProducto.VCHCOMENTARIOS,
                    DatosProducto.TIRECORDSTATUS, DatosProducto.IVENTAID, DatosProducto.IESTRATOCIUDADID, DatosProducto.IUSOSERVICIOID);

                return retorno;

            }
        }

        public int MetInsertar(CP_ConsultarDatosProductoDto DatosProducto)
        {
            ObjectParameter prueba = new ObjectParameter("IDATOSPRODUCTOID" ,typeof(int));
            

            using (OnyxEntities db = new OnyxEntities())
            {
                var retorno = db.CP_InsertarDatosProducto(DatosProducto.IPRODUCTID, DatosProducto.CHPRODUCTNUMBER,
                    DatosProducto.BENVIOPUBLICOLOCAL, DatosProducto.BENVIOPUBLICOLD, DatosProducto.BENVIOCORPLOCAL,
                    DatosProducto.BENVIOCORPLOCAL, DatosProducto.ICOMPANYID, DatosProducto.ICOMPANYIDLOCAL,
                    DatosProducto.VCHCOMENTARIOS, DatosProducto.TIRECORDSTATUS, DatosProducto.IVENTAID,
                    DatosProducto.IESTRATOCIUDADID, DatosProducto.IUSOSERVICIOID, prueba);

                return retorno;

            }
        }




        public int BuscarTelefonia(Nullable<int> iVentaId)
        {
            using (OnyxEntities db = new OnyxEntities())
            {
                System.Data.Entity.Core.Objects.ObjectParameter iDatosProductoId = new System.Data.Entity.Core.Objects.ObjectParameter("iDatosProductoId", typeof(Int32));

                db.CRMCP_BuscarTelefonia(3, iVentaId,null, iDatosProductoId);
                //int CodigoTelefonia = Convert.ToInt32(iDatosProductoId.Value);
                try
                {
                    int CodigoTelefonia = Convert.ToInt32(iDatosProductoId.Value);
                    return CodigoTelefonia;
                }
                catch (Exception)
                {

                    return 0;
                }
                //if (CodigoTelefonia != 0)
                //{
                //    return CodigoTelefonia;
                //}
                //else
                //{
                //    return 0;
                //}


            }
        }

        public CP_ConsultaSerialNumberDto MeConsultaSerialNumber(int iProductId) { 
               try{
                    using (OnyxEntities db = new OnyxEntities()){
                        CP_ConsultaSerialNumberDto _CP_ConsultaSerialNumberDto = MapperConfigurationCentral<CP_ConsultaSerialNumber_Result, CP_ConsultaSerialNumberDto>.MapEntity(db.CP_ConsultaSerialNumber(iProductId).ToList().First());
                        return _CP_ConsultaSerialNumberDto;
                    }
                }catch (Exception ex){
                    throw ex;
                }
        }
    }
}
