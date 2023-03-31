using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotechxAPI.Models.PurchaseOrder
{
    public class POMDL
    {
        public int DocEntry { get; set; }
        public int DocNum { get; set; }
        public string DocType { get; set; }
        public string DocDate { get; set; }
        public string DocDueDate { get; set; }
        public string CardCode { get; set; }
        public string CardName { get; set; }
        public string NumAtCard { get; set; }
        public string Reference1 { get; set; }
        public string Reference2 { get; set; }
        public string Comments { get; set; }
        public string JournalMemo { get; set; }
        public int? DocumentsOwner { get; set; }
        public string ShipFrom { get; set; }
        public string U_IIS_disTimeStamp { get; set; }
        public int? U_IIS_disUser { get; set; }
        public string U_IIS_Pigeon_hole { get; set; }
        public float U_IIS_disCarton_Qty { get; set; }
        public float U_IIS_disPallet_Qty { get; set; }
        public string U_IIS_disTrolley { get; set; }
        public string U_IIS_disDestBin { get; set; }
        public string U_IIS_disInUse { get; set; }
        public string U_IIS_disPicked { get; set; }
        public string U_IIS_disPickUrg { get; set; }
        public string U_IIS_disHoldDis { get; set; }
        public string U_IIS_disBaseSerial { get; set; }
        public string U_IIS_disQALevel { get; set; }
        public string U_IIS_disOrderQueue { get; set; }
        public string U_IIS_disCloseOrdr { get; set; }
        public string U_IIS_disHeavyOrder { get; set; }
        public string U_IIS_SF_ResendRtn { get; set; }
        public string U_IIS_disManifested { get; set; }
        public List<Documentline> DocumentLines { get; set; }

    }

    public class Documentline
    {
        public int LineNum { get; set; }
        public string ItemCode { get; set; }
        public string ItemDescription { get; set; }
        public float? Quantity { get; set; }
        public string WarehouseCode { get; set; }
        public int? BaseType { get; set; }
        public int? BaseEntry { get; set; }
        public int? BaseLine { get; set; }
        public object MeasureUnit { get; set; }
        public float UnitsOfMeasurment { get; set; }
        public float LineTotal { get; set; }
        public float BaseOpenQuantity { get; set; }
        public float UnitPrice { get; set; }
        public string LineStatus { get; set; }
        public int DocEntry { get; set; }
        public int UoMEntry { get; set; }
        public string UoMCode { get; set; }
        public float InventoryQuantity { get; set; }
        public float RemainingOpenInventoryQuantity { get; set; }
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
        public List<Serialnumber> SerialNumbers { get; set; }
        public object[] BatchNumbers { get; set; }
        public object[] DocumentLinesBinAllocations { get; set; }
    }

   
        
    

    public class Serialnumber
    {
        public object ManufacturerSerialNumber { get; set; }
        public string InternalSerialNumber { get; set; }
        public string ExpiryDate { get; set; }
        public string ManufactureDate { get; set; }
        public string ReceptionDate { get; set; }
        public string WarrantyStart { get; set; }
        public string WarrantyEnd { get; set; }
        public string Location { get; set; }
        public string Notes { get; set; }
        public int BatchID { get; set; }
        public int SystemSerialNumber { get; set; }
        public int BaseLineNumber { get; set; }
        public float Quantity { get; set; }      
        public string ItemCode { get; set; }
        public object U_IIS_proPrNo { get; set; }
        public object U_IIS_proStepNo { get; set; }
        public object U_IIS_proOrigBatch { get; set; }
        public object U_IIS_proQCV { get; set; }
        public object U_IIS_disNetRec { get; set; }
        public string U_IIS_disHold { get; set; }
        public object U_IIS_disInTime { get; set; }
        public object U_IIS_OwnerCode { get; set; }
        public string U_IIS_PICK_TYPE { get; set; }
    }


}

