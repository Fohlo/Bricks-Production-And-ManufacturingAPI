using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotechxAPI.Models.Stock
{
    public class InventoryCountMDL
    {
            public int DocumentEntry { get; set; }
            public int DocumentNumber { get; set; }
            public string CountDate { get; set; }
            public string CountTime { get; set; }
            public string SingleCounterType { get; set; }
            public int SingleCounterID { get; set; }
            public string DocumentStatus { get; set; }
            public string U_IIS_WMSStartBin { get; set; }
            public string U_IIS_WMSEndBin { get; set; }
            public List<Inventorycountingline> InventoryCountingLines { get; set; }

        public class Inventorycountingline
        {
            public int DocumentEntry { get; set; }
            public int LineNumber { get; set; }
            public string ItemCode { get; set; }
            public string ItemDescription { get; set; }
            public string Freeze { get; set; }
            public string WarehouseCode { get; set; }
            public int BinEntry { get; set; }
            public float InWarehouseQuantity { get; set; }
            public string Counted { get; set; }
            public string UoMCode { get; set; }
            public string BarCode { get; set; }
            public object UoMCountedQuantity { get; set; }
            public object ItemsPerUnit { get; set; }
            public float CountedQuantity { get; set; }
            public float Variance { get; set; }
            public float VariancePercentage { get; set; }
            public int VisualOrder { get; set; }
            public object TargetEntry { get; set; }
            public object TargetLine { get; set; }
            public int TargetType { get; set; }
            public object TargetReference { get; set; }
            public object ProjectCode { get; set; }
            public int Manufacturer { get; set; }
            public string SupplierCatalogNo { get; set; }
            public string LineStatus { get; set; }
            public string CounterType { get; set; }
            public int CounterID { get; set; }
            public string MultipleCounterRole { get; set; }
            public object U_WMSUser { get; set; }
            public object[] InventoryCountingLineUoMs { get; set; }
            public object[] InventoryCountingSerialNumbers { get; set; }
            public object[] InventoryCountingBatchNumbers { get; set; }
        }


    }

}
