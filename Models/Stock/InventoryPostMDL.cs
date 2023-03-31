using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotechxAPI.Models.Stock
{
    public class InventoryPostMDL
    {
            public string odatametadata { get; set; }
            public int DocumentEntry { get; set; }
            public int DocumentNumber { get; set; }
            public int Series { get; set; }
            public string PostingDate { get; set; }
            public string CountDate { get; set; }
            public string CountTime { get; set; }
            public string Remarks { get; set; }
            public object Reference2 { get; set; }
            public object BranchID { get; set; }
            public string PriceSource { get; set; }
            public int PriceList { get; set; }
            public string JournalRemark { get; set; }
            public string DocObjectCodeEx { get; set; }
            public int FinancialPeriod { get; set; }
            public string PeriodIndicator { get; set; }
            public object AttachmentEntry { get; set; }
            public object YearEndDate { get; set; }
            public object U_IIS_WMSStartBin { get; set; }
            public object U_IIS_WMSEndBin { get; set; }
            public Inventorypostingline[] InventoryPostingLines { get; set; }
            public object[] InventoryPostingDocumentReferencesCollection { get; set; }
        }

        public class Inventorypostingline
        {
            public int DocumentEntry { get; set; }
            public int LineNumber { get; set; }
            public string ItemCode { get; set; }
            public string ItemDescription { get; set; }
            public string WarehouseCode { get; set; }
            public object BinEntry { get; set; }
            public float InWarehouseQuantity { get; set; }
            public object BarCode { get; set; }
            public float Variance { get; set; }
            public float VariancePercentage { get; set; }
            public float CountedQuantity { get; set; }
            public float Price { get; set; }
            public string Currency { get; set; }
            public float Total { get; set; }
            public int VisualOrder { get; set; }
            public string CountDate { get; set; }
            public string CountTime { get; set; }
            public int BaseEntry { get; set; }
            public int BaseLine { get; set; }
            public int BaseType { get; set; }
            public string BaseReference { get; set; }
            public object Remarks { get; set; }
            public string InventoryOffsetIncreaseAccount { get; set; }
            public string InventoryOffsetDecreaseAccount { get; set; }
            public string ProjectCode { get; set; }
            public int Manufacturer { get; set; }
            public object SupplierCatalogNo { get; set; }
            public object PreferredVendor { get; set; }
            public object CostingCode { get; set; }
            public object CostingCode2 { get; set; }
            public object CostingCode3 { get; set; }
            public object CostingCode4 { get; set; }
            public object CostingCode5 { get; set; }
            public string UoMCode { get; set; }
            public float UoMCountedQuantity { get; set; }
            public float ItemsPerUnit { get; set; }
            public string AllowBinNegativeQuantity { get; set; }
            public float ActualPrice { get; set; }
            public float PostedValueLC { get; set; }
            public float PostedValueSC { get; set; }
            public object U_WMSUser { get; set; }
            public object[] InventoryPostingLineUoMs { get; set; }
            public Inventorypostingserialnumber[] InventoryPostingSerialNumbers { get; set; }
            public object[] InventoryPostingBatchNumbers { get; set; }
            public object[] InventoryPostingCCDNumbers { get; set; }
        }

        public class Inventorypostingserialnumber
        {
            public int DocumentEntry { get; set; }
            public string ManufacturerSerialNumber { get; set; }
            public string InternalSerialNumber { get; set; }
            public object ExpiryDate { get; set; }
            public object ManufactureDate { get; set; }
            public string ReceptionDate { get; set; }
            public object WarrantyStart { get; set; }
            public object WarrantyEnd { get; set; }
            public object Location { get; set; }
            public object Notes { get; set; }
            public object BatchID { get; set; }
            public int SystemSerialNumber { get; set; }
            public int BaseLineNumber { get; set; }
            public float Quantity { get; set; }
            public object TrackingNote { get; set; }
            public object TrackingNoteLine { get; set; }
            public string ItemCode { get; set; }
        }  
}
