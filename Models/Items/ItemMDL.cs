using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotechxAPI.Models.Item
{


    public class ItemMDL
    {
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string ForeignName { get; set; }
        public string U_ItemGroup { get; set; }
        public string InventoryUOM { get; set; }
        public string PurchaseUnit { get; set; }
        public string SalesUnit { get; set; }
        public string DefaultCountingUnit { get; set; }
        public int UoMGroupEntry { get; set; }
        public int InventoryUoMEntry { get; set; }
        public int? DefaultSalesUoMEntry { get; set; }
        public float QuantityOnStock { get; set; }
        public float QuantityOrderedFromVendors { get; set; }
        public float QuantityOrderedByCustomers { get; set; }
        public Itemprice[] ItemPrices { get; set; }
        public Itemwarehouseinfocollection[] ItemWarehouseInfoCollection { get; set; }
    }

    public class Itemprice
    {
        public int? PriceList { get; set; }
        public float Price { get; set; }
        public string Currency { get; set; }
        public float AdditionalPrice1 { get; set; }
        public string AdditionalCurrency1 { get; set; }
        public float AdditionalPrice2 { get; set; }
        public string AdditionalCurrency2 { get; set; }
        public int? BasePriceList { get; set; }
    }

    public class Itemwarehouseinfocollection
    {
        public float StandardAveragePrice { get; set; }
        public string Locked { get; set; }
        public string InventoryAccount { get; set; }
        public string CostAccount { get; set; }
        public string TransferAccount { get; set; }
        public string WarehouseCode { get; set; }
        public float InStock { get; set; }
        public float Committed { get; set; }
        public float Ordered { get; set; }
        public float CountedQuantity { get; set; }
        public string WasCounted { get; set; }
        public int UserSignature { get; set; }
        public float Counted { get; set; }
        public string ExpenseClearingAct { get; set; }
    }



    public class FluidsTypes
    {
        public string U_FluidCode
        { get; set; }
        public string U_FluidType
        { get; set; }

    }
}
