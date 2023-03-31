﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotechxAPI.BLL.Stock
{
    public class InventoryPostBLL
    {
            public int DocEntry { get; set; }
            public int Series { get; set; }
            public string Printed { get; set; }
            public string DocDate { get; set; }
            public string DueDate { get; set; }
            public object CardCode { get; set; }
            public object CardName { get; set; }
            public string Address { get; set; }
            public string Reference1 { get; set; }
            public object Reference2 { get; set; }
            public string Comments { get; set; }
            public string JournalMemo { get; set; }
            public int PriceList { get; set; }
            public object SalesPersonCode { get; set; }
            public string FromWarehouse { get; set; }
            public string ToWarehouse { get; set; }
            public string CreationDate { get; set; }
            public string UpdateDate { get; set; }
            public int FinancialPeriod { get; set; }
            public int TransNum { get; set; }
            public int DocNum { get; set; }
            public string TaxDate { get; set; }
            public object ContactPerson { get; set; }
            public object FolioPrefixString { get; set; }
            public object FolioNumber { get; set; }
            public string DocObjectCode { get; set; }
            public string AuthorizationStatus { get; set; }
            public object BPLID { get; set; }
            public object BPLName { get; set; }
            public object VATRegNum { get; set; }
            public object AuthorizationCode { get; set; }
            public object StartDeliveryDate { get; set; }
            public object StartDeliveryTime { get; set; }
            public object EndDeliveryDate { get; set; }
            public object EndDeliveryTime { get; set; }
            public object VehiclePlate { get; set; }
            public object ATDocumentType { get; set; }
            public object EDocExportFormat { get; set; }
            public object ElecCommStatus { get; set; }
            public object ElecCommMessage { get; set; }
            public object PointOfIssueCode { get; set; }
            public object Letter { get; set; }
            public object FolioNumberFrom { get; set; }
            public object FolioNumberTo { get; set; }
            public object AttachmentEntry { get; set; }
            public string DocumentStatus { get; set; }
            public object ShipToCode { get; set; }
            public object SAPPassport { get; set; }
            public string U_IIS_Processed { get; set; }
            public object U_IIS_DELSEQ { get; set; }
            public string U_IIS_repStRound { get; set; }
            public object U_IIS_StOrder { get; set; }
            public object U_IIS_repStWeek { get; set; }
            public string U_IIS_repStDay { get; set; }
            public object U_IIS_prjProjectN { get; set; }
            public object U_IIS_prjPM { get; set; }
            public object U_IIS_prjAutoAct { get; set; }
            public object U_IIS_prjDefStat { get; set; }
            public object U_IIS_prjActDate { get; set; }
            public string U_IIS_prjPACreate { get; set; }
            public string U_IIS_prjPAStatus { get; set; }
            public object U_IIS_disEmpNme { get; set; }
            public object U_IIS_repCnPayFrq { get; set; }
            public object U_IIS_repCnSubInt { get; set; }
            public object U_IIS_repCnStrtDa { get; set; }
            public object U_IIS_repCnNextDa { get; set; }
            public object U_IIS_repCnEndDat { get; set; }
            public object U_IIS_repContract { get; set; }
            public object U_IIS_repContrType { get; set; }
            public object U_IIS_repPrMethod { get; set; }
            public string U_IIS_repIPDisp { get; set; }
            public string U_IIS_repIPAdvArr { get; set; }
            public string U_IIS_repAutoDef { get; set; }
            public string U_IIS_repStByRound { get; set; }
            public string U_IIS_repStPause { get; set; }
            public object U_IIS_repStObjType { get; set; }
            public string U_IIS_LINKDOC { get; set; }
            public string U_IIS_b2bDocFlag { get; set; }
            public object U_IIS_b2bCardCode { get; set; }
            public object U_IIS_SubRound { get; set; }
            public string U_IIS_ApprIndv { get; set; }
            public string U_IIS_ApprBulk { get; set; }
            public object U_IIS_BulkTime { get; set; }
            public object U_IIS_CarriageCost { get; set; }
            public object U_IIS_SF_ServLevel { get; set; }
            public object U_IIS_SF_Desc { get; set; }
            public object U_IIS_SF_Amt { get; set; }
            public object U_IIS_SF_Weight { get; set; }
            public object U_GLSShipName { get; set; }
            public object U_GLSShipStreet { get; set; }
            public object U_GLSShipBlock { get; set; }
            public object U_GLSShipCity { get; set; }
            public object U_GLSShipCounty { get; set; }
            public object U_GLSShipZipCode { get; set; }
            public object U_GLSShipCountry { get; set; }
            public object U_GLSShipPhone { get; set; }
            public string U_IIS_ORDER_SOURCE { get; set; }
            public string U_IIS_ORDER_TYPE { get; set; }
            public object U_IIS_ORDER_STATUS { get; set; }
            public object U_IIS_PREBOOK { get; set; }
            public object U_IIS_BOOKREF { get; set; }
            public object U_IIS_BOOKRFDT { get; set; }
            public object U_IIS_3PL_STATUS { get; set; }
            public object U_IIS_3PL_RCVDDATE { get; set; }
            public object U_IIS_EDI_TYPE { get; set; }
            public object U_IIS_EDI_STATUS { get; set; }
            public object U_IIS_P_ORDNAME { get; set; }
            public object U_IIS_P_DELNAME { get; set; }
            public object U_IIS_P_DELEMAIL { get; set; }
            public object U_IIS_P_DELPHONE { get; set; }
            public object U_IIS_DEL_INSTR { get; set; }
            public object U_IIS_REAL_AUTH { get; set; }
            public object U_IIS_SF_SpInstr1 { get; set; }
            public object U_IIS_SF_SpInstr2 { get; set; }
            public object U_IIS_SF_SpInstr3 { get; set; }
            public object U_IIS_CustGroup { get; set; }
            public object U_IIS_WebOrderNo { get; set; }
            public object U_IIS_ShipType { get; set; }
            public object U_IIS_BlkCourier { get; set; }
            public object U_IIS_CampCode { get; set; }
            public object U_IIS_SourceCode { get; set; }
            public object U_IIS_ConsNo { get; set; }
            public object U_IIS_SF_Tracking { get; set; }
            public string U_IIS_SF_Taillift { get; set; }
            public object U_IIS_CD1ID { get; set; }
            public object U_IIS_CUSTCODE { get; set; }
            public string U_IIS_BILLINGIGNORE { get; set; }
            public string U_IIS_INVSEP { get; set; }
            public object U_IIS_SF_Sender { get; set; }
            public object U_IIS_SF_Comment1 { get; set; }
            public object U_IIS_SF_ServOptn { get; set; }
            public object U_IIS_DelType { get; set; }
            public object U_IIS_ContrNo { get; set; }
            public object U_IIS_DelLocn { get; set; }
            public object U_IIS_WhsCode { get; set; }
            public string U_IIS_MarginC { get; set; }
            public object U_IIS_MarginL { get; set; }
            public string U_IIS_ValueC { get; set; }
            public object U_IIS_ValueL { get; set; }
            public string U_IIS_CreditC { get; set; }
            public string U_IIS_Collected { get; set; }
            public string U_IIS_AF { get; set; }
            public string U_IIS_AUF { get; set; }
            public object U_IIS_SIP { get; set; }
            public object U_IIS_TranspMethod { get; set; }
            public object U_IIS_TargetWhs { get; set; }
            public object U_IIS_OrigTransReq { get; set; }
            public object U_MJ_SubRound { get; set; }
            public object U_IIS_SelGrp1 { get; set; }
            public object U_IIS_SelGrp2 { get; set; }
            public object U_IIS_SelGrp3 { get; set; }
            public object U_IIS_SelGrp4 { get; set; }
            public object U_IIS_disTimeStamp { get; set; }
            public object U_IIS_disUser { get; set; }
            public object U_IIS_Pigeon_hole { get; set; }
            public object U_IIS_disCarton_Qty { get; set; }
            public object U_IIS_disPallet_Qty { get; set; }
            public object U_IIS_disTrolley { get; set; }
            public object U_IIS_disDestBin { get; set; }
            public string U_IIS_disInUse { get; set; }
            public string U_IIS_disPicked { get; set; }
            public string U_IIS_disPickUrg { get; set; }
            public string U_IIS_disHoldDis { get; set; }
            public object U_IIS_disBaseSerial { get; set; }
            public string U_IIS_disQALevel { get; set; }
            public object U_IIS_disOrderQueue { get; set; }
            public string U_IIS_disCloseOrdr { get; set; }
            public string U_IIS_disHeavyOrder { get; set; }
            public string U_IIS_SF_ResendRtn { get; set; }
            public object U_ConsignID { get; set; }
            public object U_Customer { get; set; }
            public string U_IIS_BelowMinMargin { get; set; }
            public string U_IIS_EmptyBPCat { get; set; }
            public string U_IIS_WMSREL { get; set; }
            public string U_IIS_ONHOLD { get; set; }
            public object U_IIS_PININFO { get; set; }
            public object U_IIS_PINREF { get; set; }
            public string U_IIS_PARTSHIP { get; set; }
            public object U_GLSEmail { get; set; }
            public object U_IIS_SF_Volume { get; set; }
            public object U_IIS_JTYPE { get; set; }
            public object U_IIS_TYPE { get; set; }
            public object U_IIS_OwnerCode { get; set; }
            public object U_IIS_JobNo { get; set; }
            public string U_IIS_LUCREL { get; set; }
            public object U_IIS_EDINO { get; set; }
            public object U_IIS_FILEDATE { get; set; }
            public object U_IIS_PACKNO { get; set; }
            public object U_IIS_EDI_ITEM { get; set; }
            public string U_IIS_EDI_DJ { get; set; }
            public object U_CX_LicensePlate { get; set; }
            public object U_CX_GrossWeight { get; set; }
            public object U_CX_NettWeight { get; set; }
            public object U_IIS_LC_MD_ProfShare { get; set; }
            public object U_IIS_3PL_HANDLING { get; set; }
            public object U_IIS_3PL_REWORK { get; set; }
            public object U_IIS_LND_TRANSPORT { get; set; }
            public object U_IIS_LND_TRANSCURR { get; set; }
            public object U_IIS_PLT_GKN { get; set; }
            public object U_IIS_PLT_RED { get; set; }
            public object U_IIS_PLT_STD { get; set; }
            public object U_IIS_PLT_EURO { get; set; }
            public object U_IIS_3PL_SDN { get; set; }
            public object U_IIS_3PL_PICK { get; set; }
            public object U_IIS_QTECLS { get; set; }
            public string U_IIS_disManifested { get; set; }
            public object[] StockTransfer_ApprovalRequests { get; set; }
            public object[] ElectronicProtocols { get; set; }
            public Stocktransferline[] StockTransferLines { get; set; }
            public Stocktransfertaxextension StockTransferTaxExtension { get; set; }
            public object[] DocumentReferences { get; set; }
        }

        public class Stocktransfertaxextension
        {
            public string SupportVAT { get; set; }
            public object FormNumber { get; set; }
            public object TransactionCategory { get; set; }
            public object U_GLSZipCodeS { get; set; }
            public object U_GLSZipCodeB { get; set; }
            public object U_IIS_DelLocnS { get; set; }
            public object U_IIS_DelLocnB { get; set; }
            public object U_IIS_FDESTS { get; set; }
            public object U_IIS_FDESTB { get; set; }
            public object U_CX_TransportDaysS { get; set; }
            public object U_CX_TransportDaysB { get; set; }
            public object U_CX_WhsCodeS { get; set; }
            public object U_CX_WhsCodeB { get; set; }
            public object U_CX_MatHandCodeS { get; set; }
            public object U_CX_MatHandCodeB { get; set; }
        }

        public class Stocktransferline
        {
            public int LineNum { get; set; }
            public int DocEntry { get; set; }
            public string ItemCode { get; set; }
            public string ItemDescription { get; set; }
            public float Quantity { get; set; }
            public float Price { get; set; }
            public string Currency { get; set; }
            public float Rate { get; set; }
            public float DiscountPercent { get; set; }
            public object VendorNum { get; set; }
            public object SerialNumber { get; set; }
            public string WarehouseCode { get; set; }
            public string FromWarehouseCode { get; set; }
            public object ProjectCode { get; set; }
            public float Factor { get; set; }
            public float Factor2 { get; set; }
            public float Factor3 { get; set; }
            public float Factor4 { get; set; }
            public object DistributionRule { get; set; }
            public object DistributionRule2 { get; set; }
            public object DistributionRule3 { get; set; }
            public object DistributionRule4 { get; set; }
            public object DistributionRule5 { get; set; }
            public string UseBaseUnits { get; set; }
            public string MeasureUnit { get; set; }
            public float UnitsOfMeasurment { get; set; }
            public string BaseType { get; set; }
            public object BaseLine { get; set; }
            public object BaseEntry { get; set; }
            public float UnitPrice { get; set; }
            public int UoMEntry { get; set; }
            public string UoMCode { get; set; }
            public float InventoryQuantity { get; set; }
            public float RemainingOpenQuantity { get; set; }
            public float RemainingOpenInventoryQuantity { get; set; }
            public string LineStatus { get; set; }
            public object U_RECHARGEABLE { get; set; }
            public object U_IIS_RechgPONum { get; set; }
            public object U_IIS_RechgPOLine { get; set; }
            public object U_IIS_RechgPOEntry { get; set; }
            public string U_IIS_REASCODE { get; set; }
            public string U_IIS_DirectDel { get; set; }
            public object U_IIS_Depot { get; set; }
            public float U_IIS_repStSun { get; set; }
            public float U_IIS_repStMon { get; set; }
            public float U_IIS_repStTue { get; set; }
            public float U_IIS_repStWed { get; set; }
            public float U_IIS_repStThu { get; set; }
            public float U_IIS_repStFri { get; set; }
            public float U_IIS_repStSat { get; set; }
            public object U_IIS_proReasCode { get; set; }
            public object U_IIS_proReasDesc { get; set; }
            public float U_IIS_proQCV { get; set; }
            public object U_IIS_proPrOrder { get; set; }
            public object U_IIS_proPrLineID { get; set; }
            public string U_IIS_prjActMile { get; set; }
            public object U_IIS_prjActGrp { get; set; }
            public object U_IIS_prjParent { get; set; }
            public object U_IIS_prjChild { get; set; }
            public object U_IIS_prjActTemp { get; set; }
            public object U_IIS_prjPhase { get; set; }
            public object U_IIS_prjTask { get; set; }
            public object U_IIS_prjSONum { get; set; }
            public object U_IIS_prjSOEntry { get; set; }
            public object U_IIS_prjSOLine { get; set; }
            public object U_IIS_prjActNo { get; set; }
            public object U_IIS_prjActUser { get; set; }
            public string U_IIS_cloFulfilAsIs { get; set; }
            public object U_IIS_DCNO { get; set; }
            public object U_IIS_DCLINE { get; set; }
            public object U_IIS_PurchCost { get; set; }
            public object U_IIS_priSpCode { get; set; }
            public object U_IIS_priSpOffer { get; set; }
            public object U_IIS_priSpNoOffers { get; set; }
            public object U_IIS_priSpID { get; set; }
            public object U_IIS_priSpType { get; set; }
            public object U_Batch { get; set; }
            public string U_IIS_repRecur { get; set; }
            public object U_IIS_repServCall { get; set; }
            public object U_IIS_repServContr { get; set; }
            public float U_IIS_repSCRate { get; set; }
            public object U_IIS_repSCNoDays { get; set; }
            public object U_IIS_repDateFrom { get; set; }
            public object U_IIS_repDateTo { get; set; }
            public object U_IIS_repUnitQty { get; set; }
            public object U_WhsCodeServ { get; set; }
            public object U_IIS_VEHREG { get; set; }
            public object U_IIS_SystemPrice { get; set; }
            public object U_IIS_DCTYPE { get; set; }
            public object U_IIS_DCREF { get; set; }
            public object U_IIS_DCENTRY { get; set; }
            public string U_IIS_Released { get; set; }
            public object U_IIS_CSM2_Parent { get; set; }
            public object U_IIS_CSM2_Reason { get; set; }
            public object U_PICK { get; set; }
            public object U_IIS_CtCmpName { get; set; }
            public object U_IIS_CtPrefix { get; set; }
            public object U_IIS_CtFName { get; set; }
            public object U_IIS_CtLName { get; set; }
            public object U_IIS_CtTel1 { get; set; }
            public object U_IIS_CtMobile { get; set; }
            public object U_IIS_CtEmail { get; set; }
            public object U_IIS_DelAdd1 { get; set; }
            public object U_IIS_DelAdd2 { get; set; }
            public object U_IIS_DelAdd3 { get; set; }
            public object U_IIS_DelTown { get; set; }
            public object U_IIS_DelCnty { get; set; }
            public object U_IIS_DelZip { get; set; }
            public object U_IIS_DelCtry { get; set; }
            public object U_IIS_DelInstr { get; set; }
            public object U_IIS_Courier { get; set; }
            public object U_IIS_CourierChrg { get; set; }
            public string U_IIS_ExpressDel { get; set; }
            public object U_IIS_Occasion { get; set; }
            public object U_IIS_GiftMsg1 { get; set; }
            public object U_IIS_GiftMsg2 { get; set; }
            public object U_IIS_GiftMsg3 { get; set; }
            public object U_IIS_GiftMsg4 { get; set; }
            public object U_IIS_GiftMsg5 { get; set; }
            public object U_IIS_GiftMsg6 { get; set; }
            public object U_IIS_GiftMsg7 { get; set; }
            public string U_IIS_PerProd { get; set; }
            public object U_IIS_PerChars { get; set; }
            public object U_IIS_PerLine1 { get; set; }
            public object U_IIS_PerLine2 { get; set; }
            public object U_IIS_PerLine3 { get; set; }
            public object U_IIS_PerLine4 { get; set; }
            public object U_IIS_PerLine5 { get; set; }
            public object U_IIS_CourierTrkNo { get; set; }
            public object U_IIS_DispDate { get; set; }
            public object U_IIS_DelVAT { get; set; }
            public string U_IIS_Manual { get; set; }
            public object U_IIS_CUSTCODE { get; set; }
            public object U_IIS_Supplier { get; set; }
            public object U_IIS_Claimback { get; set; }
            public object U_IIS_ProdSuppl { get; set; }
            public object U_IIS_ProdCode { get; set; }
            public object U_IIS_ProdDesc { get; set; }
            public object U_IIS_Line { get; set; }
            public object U_IIS_GPPercent { get; set; }
            public object U_IIS_NumAtCard { get; set; }
            public object U_IIS_OrigTransLn { get; set; }
            public object U_IIS_Com { get; set; }
            public object U_IIS_disOrdObjType { get; set; }
            public object U_IIS_disOrdDocEntry { get; set; }
            public object U_IIS_disOrdLineNum { get; set; }
            public object U_IIS_disStkInDate { get; set; }
            public object U_IIS_disDestWhsCode { get; set; }
            public string U_IIS_disPicked { get; set; }
            public string U_IIS_disQALevel { get; set; }
            public string U_IIS_disOrdPickType { get; set; }
            public object U_IIS_disDownType { get; set; }
            public string U_IIS_disDownExp { get; set; }
            public object U_IIS_WCFCalcNo { get; set; }
            public object U_IIS_WCFComm { get; set; }
            public object U_IIS_WCFTarget { get; set; }
            public object U_IIS_WeightNet { get; set; }
            public object U_IIS_WeightDiff { get; set; }
            public object U_IIS_DocNum { get; set; }
            public object U_IIS_LineNum { get; set; }
            public object U_IIS_Fitter { get; set; }
            public object U_IIS_PlotType { get; set; }
            public object U_IIS_BudPerc { get; set; }
            public object U_IIS_ProgDate { get; set; }
            public string U_IIS_PWork { get; set; }
            public object U_IIS_PriceWork { get; set; }
            public string U_IIS_DWork { get; set; }
            public object U_IIS_DyNoHrs { get; set; }
            public object U_IIS_PlotNo { get; set; }
            public object U_IIS_SODocNum { get; set; }
            public object U_IIS_SODocKey { get; set; }
            public object U_IIS_SOLineNum { get; set; }
            public object U_IIS_SOLineID { get; set; }
            public object U_AV_REMAIN { get; set; }
            public object U_AV_PERCENT { get; set; }
            public object U_iis_serial { get; set; }
            public object U_iis_ddate { get; set; }
            public object U_IIS_FCOLL { get; set; }
            public object U_IIS_FCOLS { get; set; }
            public object U_SMP_ID { get; set; }
            public object U_IIS_JobNo { get; set; }
            public object U_IIS_LND_DUTYPERC { get; set; }
            public object U_IIS_LND_SUGAR { get; set; }
            public object U_IIS_LND_DUTYVAL { get; set; }
            public object U_MB_OrderRef { get; set; }
            public object U_MB_Section { get; set; }
            public object U_MB_UnitHouse { get; set; }
            public object U_IIS_OriginalQty { get; set; }
            public object[] SerialNumbers { get; set; }
            public object[] BatchNumbers { get; set; }
            public object[] CCDNumbers { get; set; }
            public object[] StockTransferLinesBinAllocations { get; set; }
        }
}
