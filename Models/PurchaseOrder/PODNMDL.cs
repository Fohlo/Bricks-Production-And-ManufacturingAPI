using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotechxAPI.Models.PurchaseOrder
{
    public class PODNMDL
    {

            public int DocEntry { get; set; }
            public int DocNum { get; set; }
            public string CardCode { get; set; }
            public string NumAtCard { get; set; }
            public string DocObjectCode { get; set; }
            public int DocumentsOwner { get; set; }
            public string U_IIS_disTimeStamp { get; set; }
            public string U_IIS_disUser { get; set; }
            public List<Documentline> DocumentLines { get; set; }
        

        public class Documentline
        {
            public string ItemCode { get; set; }
            public float? Quantity { get; set; }
            public int? BaseType { get; set; }
            public int? BaseEntry { get; set; }
            public int? BaseLine { get; set; }
            public List<Serialnumber> SerialNumbers { get; set; }
            public List<Batchnumber> BatchNumbers { get; set; }
            public List<Documentlinesbinallocation> DocumentLinesBinAllocations { get; set; }
            public float? InventoryQuantity { get; set; }
        }

        public class Batchnumber
        {
            public string BaseLineNumber { get; set; }
            public string BatchNumber { get; set; }
            public string Quantity { get; set; }
            public double? U_IIS_disNetRec { get; set; }
            public string U_IIS_disInTime { get; set; }
            public string U_IIS_disHold { get; set; }
        }

        public class Serialnumber
        {
            public string ManufacturerSerialNumber { get; set; }
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
            public object U_IIS_disNetRec { get; set; }
            public string U_IIS_disHold { get; set; }
            public object U_IIS_disInTime { get; set; }
            public object U_IIS_OwnerCode { get; set; }
            public string U_IIS_PICK_TYPE { get; set; }
        }

        public class Documentlinesbinallocation
        {
            public string BinAbsEntry { get; set; }
            public string SerialAndBatchNumbersBaseLine { get; set; }
            public string Quantity { get; set; }
            public string BaseLineNumber { get; set; }
        }


    }
}
