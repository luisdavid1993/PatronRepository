﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TT.AdoNetEntity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class OnyxEntities : DbContext
    {
        public OnyxEntities()
            : base("name=OnyxEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual int CP_InsertarDatosProducto(string iPRODUCTID, string cHPRODUCTNUMBER, Nullable<bool> bENVIOPUBLICOLOCAL, Nullable<bool> bENVIOPUBLICOLD, Nullable<bool> bENVIOCORPLOCAL, Nullable<bool> bENVIOCORPLD, Nullable<int> iCOMPANYID, Nullable<int> iCOMPANYLOCALID, string vCHCOMENTARIOS, Nullable<byte> tIRECORDSTATUS, Nullable<int> iVENTAID, Nullable<int> iESTRATOCIUDADID, Nullable<int> iUSOSERVICIOID, ObjectParameter iDATOSPRODUCTOID)
        {
            var iPRODUCTIDParameter = iPRODUCTID != null ?
                new ObjectParameter("IPRODUCTID", iPRODUCTID) :
                new ObjectParameter("IPRODUCTID", typeof(string));
    
            var cHPRODUCTNUMBERParameter = cHPRODUCTNUMBER != null ?
                new ObjectParameter("CHPRODUCTNUMBER", cHPRODUCTNUMBER) :
                new ObjectParameter("CHPRODUCTNUMBER", typeof(string));
    
            var bENVIOPUBLICOLOCALParameter = bENVIOPUBLICOLOCAL.HasValue ?
                new ObjectParameter("BENVIOPUBLICOLOCAL", bENVIOPUBLICOLOCAL) :
                new ObjectParameter("BENVIOPUBLICOLOCAL", typeof(bool));
    
            var bENVIOPUBLICOLDParameter = bENVIOPUBLICOLD.HasValue ?
                new ObjectParameter("BENVIOPUBLICOLD", bENVIOPUBLICOLD) :
                new ObjectParameter("BENVIOPUBLICOLD", typeof(bool));
    
            var bENVIOCORPLOCALParameter = bENVIOCORPLOCAL.HasValue ?
                new ObjectParameter("BENVIOCORPLOCAL", bENVIOCORPLOCAL) :
                new ObjectParameter("BENVIOCORPLOCAL", typeof(bool));
    
            var bENVIOCORPLDParameter = bENVIOCORPLD.HasValue ?
                new ObjectParameter("BENVIOCORPLD", bENVIOCORPLD) :
                new ObjectParameter("BENVIOCORPLD", typeof(bool));
    
            var iCOMPANYIDParameter = iCOMPANYID.HasValue ?
                new ObjectParameter("ICOMPANYID", iCOMPANYID) :
                new ObjectParameter("ICOMPANYID", typeof(int));
    
            var iCOMPANYLOCALIDParameter = iCOMPANYLOCALID.HasValue ?
                new ObjectParameter("ICOMPANYLOCALID", iCOMPANYLOCALID) :
                new ObjectParameter("ICOMPANYLOCALID", typeof(int));
    
            var vCHCOMENTARIOSParameter = vCHCOMENTARIOS != null ?
                new ObjectParameter("VCHCOMENTARIOS", vCHCOMENTARIOS) :
                new ObjectParameter("VCHCOMENTARIOS", typeof(string));
    
            var tIRECORDSTATUSParameter = tIRECORDSTATUS.HasValue ?
                new ObjectParameter("TIRECORDSTATUS", tIRECORDSTATUS) :
                new ObjectParameter("TIRECORDSTATUS", typeof(byte));
    
            var iVENTAIDParameter = iVENTAID.HasValue ?
                new ObjectParameter("IVENTAID", iVENTAID) :
                new ObjectParameter("IVENTAID", typeof(int));
    
            var iESTRATOCIUDADIDParameter = iESTRATOCIUDADID.HasValue ?
                new ObjectParameter("IESTRATOCIUDADID", iESTRATOCIUDADID) :
                new ObjectParameter("IESTRATOCIUDADID", typeof(int));
    
            var iUSOSERVICIOIDParameter = iUSOSERVICIOID.HasValue ?
                new ObjectParameter("IUSOSERVICIOID", iUSOSERVICIOID) :
                new ObjectParameter("IUSOSERVICIOID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CP_InsertarDatosProducto", iPRODUCTIDParameter, cHPRODUCTNUMBERParameter, bENVIOPUBLICOLOCALParameter, bENVIOPUBLICOLDParameter, bENVIOCORPLOCALParameter, bENVIOCORPLDParameter, iCOMPANYIDParameter, iCOMPANYLOCALIDParameter, vCHCOMENTARIOSParameter, tIRECORDSTATUSParameter, iVENTAIDParameter, iESTRATOCIUDADIDParameter, iUSOSERVICIOIDParameter, iDATOSPRODUCTOID);
        }
    
        public virtual ObjectResult<CP_CONSULTARDATOSPRODUCTO_Result> CP_CONSULTARDATOSPRODUCTO(Nullable<int> p_IDATOSPRODUCTOID)
        {
            var p_IDATOSPRODUCTOIDParameter = p_IDATOSPRODUCTOID.HasValue ?
                new ObjectParameter("P_IDATOSPRODUCTOID", p_IDATOSPRODUCTOID) :
                new ObjectParameter("P_IDATOSPRODUCTOID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CP_CONSULTARDATOSPRODUCTO_Result>("CP_CONSULTARDATOSPRODUCTO", p_IDATOSPRODUCTOIDParameter);
        }
    
        public virtual ObjectResult<CP_ConsultarClienteTelefonia_Result> CP_ConsultarClienteTelefonia(Nullable<int> iCompanyId)
        {
            var iCompanyIdParameter = iCompanyId.HasValue ?
                new ObjectParameter("iCompanyId", iCompanyId) :
                new ObjectParameter("iCompanyId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CP_ConsultarClienteTelefonia_Result>("CP_ConsultarClienteTelefonia", iCompanyIdParameter);
        }
    
        public virtual int CP_LogErrorTabTelefonia_Insertar(string vchUsuario, string vchMetodo, string vchMessageError, string vchInnerTracerError)
        {
            var vchUsuarioParameter = vchUsuario != null ?
                new ObjectParameter("vchUsuario", vchUsuario) :
                new ObjectParameter("vchUsuario", typeof(string));
    
            var vchMetodoParameter = vchMetodo != null ?
                new ObjectParameter("vchMetodo", vchMetodo) :
                new ObjectParameter("vchMetodo", typeof(string));
    
            var vchMessageErrorParameter = vchMessageError != null ?
                new ObjectParameter("vchMessageError", vchMessageError) :
                new ObjectParameter("vchMessageError", typeof(string));
    
            var vchInnerTracerErrorParameter = vchInnerTracerError != null ?
                new ObjectParameter("vchInnerTracerError", vchInnerTracerError) :
                new ObjectParameter("vchInnerTracerError", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CP_LogErrorTabTelefonia_Insertar", vchUsuarioParameter, vchMetodoParameter, vchMessageErrorParameter, vchInnerTracerErrorParameter);
        }
    
        public virtual ObjectResult<CP_ConsultarUso_Result> CP_ConsultarUso()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CP_ConsultarUso_Result>("CP_ConsultarUso");
        }
    
        public virtual int CP_ACTUALIZARDATOSPRODUCTO(Nullable<int> p_IDATOSPRODUCTOID, string p_IPRODUCTID, string p_CHPRODUCTNUMBER, Nullable<bool> p_BENVIOPUBLICOLOCAL, Nullable<bool> p_BENVIOPUBLICOLD, Nullable<bool> p_BENVIOCORPLOCAL, Nullable<bool> p_BENVIOCORPLD, Nullable<int> p_ICOMPANYID, Nullable<int> p_ICOMPANYLOCALID, string p_VCHCOMENTARIOS, Nullable<byte> p_TIRECORDSTATUS, Nullable<int> p_IVENTAID, Nullable<int> p_IESTRATOCIUDADID, Nullable<int> p_IUSOSERVICIOID)
        {
            var p_IDATOSPRODUCTOIDParameter = p_IDATOSPRODUCTOID.HasValue ?
                new ObjectParameter("P_IDATOSPRODUCTOID", p_IDATOSPRODUCTOID) :
                new ObjectParameter("P_IDATOSPRODUCTOID", typeof(int));
    
            var p_IPRODUCTIDParameter = p_IPRODUCTID != null ?
                new ObjectParameter("P_IPRODUCTID", p_IPRODUCTID) :
                new ObjectParameter("P_IPRODUCTID", typeof(string));
    
            var p_CHPRODUCTNUMBERParameter = p_CHPRODUCTNUMBER != null ?
                new ObjectParameter("P_CHPRODUCTNUMBER", p_CHPRODUCTNUMBER) :
                new ObjectParameter("P_CHPRODUCTNUMBER", typeof(string));
    
            var p_BENVIOPUBLICOLOCALParameter = p_BENVIOPUBLICOLOCAL.HasValue ?
                new ObjectParameter("P_BENVIOPUBLICOLOCAL", p_BENVIOPUBLICOLOCAL) :
                new ObjectParameter("P_BENVIOPUBLICOLOCAL", typeof(bool));
    
            var p_BENVIOPUBLICOLDParameter = p_BENVIOPUBLICOLD.HasValue ?
                new ObjectParameter("P_BENVIOPUBLICOLD", p_BENVIOPUBLICOLD) :
                new ObjectParameter("P_BENVIOPUBLICOLD", typeof(bool));
    
            var p_BENVIOCORPLOCALParameter = p_BENVIOCORPLOCAL.HasValue ?
                new ObjectParameter("P_BENVIOCORPLOCAL", p_BENVIOCORPLOCAL) :
                new ObjectParameter("P_BENVIOCORPLOCAL", typeof(bool));
    
            var p_BENVIOCORPLDParameter = p_BENVIOCORPLD.HasValue ?
                new ObjectParameter("P_BENVIOCORPLD", p_BENVIOCORPLD) :
                new ObjectParameter("P_BENVIOCORPLD", typeof(bool));
    
            var p_ICOMPANYIDParameter = p_ICOMPANYID.HasValue ?
                new ObjectParameter("P_ICOMPANYID", p_ICOMPANYID) :
                new ObjectParameter("P_ICOMPANYID", typeof(int));
    
            var p_ICOMPANYLOCALIDParameter = p_ICOMPANYLOCALID.HasValue ?
                new ObjectParameter("P_ICOMPANYLOCALID", p_ICOMPANYLOCALID) :
                new ObjectParameter("P_ICOMPANYLOCALID", typeof(int));
    
            var p_VCHCOMENTARIOSParameter = p_VCHCOMENTARIOS != null ?
                new ObjectParameter("P_VCHCOMENTARIOS", p_VCHCOMENTARIOS) :
                new ObjectParameter("P_VCHCOMENTARIOS", typeof(string));
    
            var p_TIRECORDSTATUSParameter = p_TIRECORDSTATUS.HasValue ?
                new ObjectParameter("P_TIRECORDSTATUS", p_TIRECORDSTATUS) :
                new ObjectParameter("P_TIRECORDSTATUS", typeof(byte));
    
            var p_IVENTAIDParameter = p_IVENTAID.HasValue ?
                new ObjectParameter("P_IVENTAID", p_IVENTAID) :
                new ObjectParameter("P_IVENTAID", typeof(int));
    
            var p_IESTRATOCIUDADIDParameter = p_IESTRATOCIUDADID.HasValue ?
                new ObjectParameter("P_IESTRATOCIUDADID", p_IESTRATOCIUDADID) :
                new ObjectParameter("P_IESTRATOCIUDADID", typeof(int));
    
            var p_IUSOSERVICIOIDParameter = p_IUSOSERVICIOID.HasValue ?
                new ObjectParameter("P_IUSOSERVICIOID", p_IUSOSERVICIOID) :
                new ObjectParameter("P_IUSOSERVICIOID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CP_ACTUALIZARDATOSPRODUCTO", p_IDATOSPRODUCTOIDParameter, p_IPRODUCTIDParameter, p_CHPRODUCTNUMBERParameter, p_BENVIOPUBLICOLOCALParameter, p_BENVIOPUBLICOLDParameter, p_BENVIOCORPLOCALParameter, p_BENVIOCORPLDParameter, p_ICOMPANYIDParameter, p_ICOMPANYLOCALIDParameter, p_VCHCOMENTARIOSParameter, p_TIRECORDSTATUSParameter, p_IVENTAIDParameter, p_IESTRATOCIUDADIDParameter, p_IUSOSERVICIOIDParameter);
        }
    
        public virtual int CRMCP_BuscarTelefonia(Nullable<int> iIncidentCategory, Nullable<int> iIncidentId, string vchSerialNumber, ObjectParameter iDatosProductoId)
        {
            var iIncidentCategoryParameter = iIncidentCategory.HasValue ?
                new ObjectParameter("iIncidentCategory", iIncidentCategory) :
                new ObjectParameter("iIncidentCategory", typeof(int));
    
            var iIncidentIdParameter = iIncidentId.HasValue ?
                new ObjectParameter("iIncidentId", iIncidentId) :
                new ObjectParameter("iIncidentId", typeof(int));
    
            var vchSerialNumberParameter = vchSerialNumber != null ?
                new ObjectParameter("vchSerialNumber", vchSerialNumber) :
                new ObjectParameter("vchSerialNumber", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CRMCP_BuscarTelefonia", iIncidentCategoryParameter, iIncidentIdParameter, vchSerialNumberParameter, iDatosProductoId);
        }
    
        public virtual ObjectResult<Nullable<int>> CP_Cuenta_Incident_iIncidentId(Nullable<int> iIncidentId)
        {
            var iIncidentIdParameter = iIncidentId.HasValue ?
                new ObjectParameter("iIncidentId", iIncidentId) :
                new ObjectParameter("iIncidentId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("CP_Cuenta_Incident_iIncidentId", iIncidentIdParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> CP_DatosProductoIncident_iIncidentId(Nullable<int> iIncidentId)
        {
            var iIncidentIdParameter = iIncidentId.HasValue ?
                new ObjectParameter("iIncidentId", iIncidentId) :
                new ObjectParameter("iIncidentId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("CP_DatosProductoIncident_iIncidentId", iIncidentIdParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> CP_iIncidentCategory_Incident_iIncidentId(Nullable<int> iIncidentId)
        {
            var iIncidentIdParameter = iIncidentId.HasValue ?
                new ObjectParameter("iIncidentId", iIncidentId) :
                new ObjectParameter("iIncidentId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("CP_iIncidentCategory_Incident_iIncidentId", iIncidentIdParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> CP_iOwnerId_Incident_iIncidentId(Nullable<int> iIncidentId)
        {
            var iIncidentIdParameter = iIncidentId.HasValue ?
                new ObjectParameter("iIncidentId", iIncidentId) :
                new ObjectParameter("iIncidentId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("CP_iOwnerId_Incident_iIncidentId", iIncidentIdParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> CP_iStatusId_Incident_iIncidentId(Nullable<int> iIncidentId)
        {
            var iIncidentIdParameter = iIncidentId.HasValue ?
                new ObjectParameter("iIncidentId", iIncidentId) :
                new ObjectParameter("iIncidentId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("CP_iStatusId_Incident_iIncidentId", iIncidentIdParameter);
        }
    
        public virtual ObjectResult<CP_Product_Master_iIncidentId_Result> CP_Product_Master_iIncidentId(Nullable<int> iIncidentId)
        {
            var iIncidentIdParameter = iIncidentId.HasValue ?
                new ObjectParameter("iIncidentId", iIncidentId) :
                new ObjectParameter("iIncidentId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CP_Product_Master_iIncidentId_Result>("CP_Product_Master_iIncidentId", iIncidentIdParameter);
        }
    
        public virtual ObjectResult<CP_ConsultaSerialNumber_Result> CP_ConsultaSerialNumber(Nullable<int> iProductId)
        {
            var iProductIdParameter = iProductId.HasValue ?
                new ObjectParameter("iProductId", iProductId) :
                new ObjectParameter("iProductId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CP_ConsultaSerialNumber_Result>("CP_ConsultaSerialNumber", iProductIdParameter);
        }
    
        public virtual ObjectResult<string> CP_ConsultaGrupoCentrex()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("CP_ConsultaGrupoCentrex");
        }
    
        public virtual ObjectResult<string> CP_ConsultavchCallSource()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("CP_ConsultavchCallSource");
        }
    
        public virtual int CP_ConsultarValoresCampoProducto(string chProductNumber, string chCampo, string cValidarRepetidos, Nullable<int> iValorIdPadre, Nullable<int> iCompanyId)
        {
            var chProductNumberParameter = chProductNumber != null ?
                new ObjectParameter("chProductNumber", chProductNumber) :
                new ObjectParameter("chProductNumber", typeof(string));
    
            var chCampoParameter = chCampo != null ?
                new ObjectParameter("chCampo", chCampo) :
                new ObjectParameter("chCampo", typeof(string));
    
            var cValidarRepetidosParameter = cValidarRepetidos != null ?
                new ObjectParameter("cValidarRepetidos", cValidarRepetidos) :
                new ObjectParameter("cValidarRepetidos", typeof(string));
    
            var iValorIdPadreParameter = iValorIdPadre.HasValue ?
                new ObjectParameter("iValorIdPadre", iValorIdPadre) :
                new ObjectParameter("iValorIdPadre", typeof(int));
    
            var iCompanyIdParameter = iCompanyId.HasValue ?
                new ObjectParameter("iCompanyId", iCompanyId) :
                new ObjectParameter("iCompanyId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CP_ConsultarValoresCampoProducto", chProductNumberParameter, chCampoParameter, cValidarRepetidosParameter, iValorIdPadreParameter, iCompanyIdParameter);
        }
    
        public virtual ObjectResult<CP_LLenarTablaAsuntosModificaron_Result> CP_LLenarTablaAsuntosModificaron(Nullable<int> iDatosProductoId)
        {
            var iDatosProductoIdParameter = iDatosProductoId.HasValue ?
                new ObjectParameter("iDatosProductoId", iDatosProductoId) :
                new ObjectParameter("iDatosProductoId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CP_LLenarTablaAsuntosModificaron_Result>("CP_LLenarTablaAsuntosModificaron", iDatosProductoIdParameter);
        }
    
        public virtual ObjectResult<CP_ParametrosXProducto_ProductNumber_Result> CP_ParametrosXProducto_ProductNumber(string chProductNumber)
        {
            var chProductNumberParameter = chProductNumber != null ?
                new ObjectParameter("chProductNumber", chProductNumber) :
                new ObjectParameter("chProductNumber", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CP_ParametrosXProducto_ProductNumber_Result>("CP_ParametrosXProducto_ProductNumber", chProductNumberParameter);
        }
    }
}
