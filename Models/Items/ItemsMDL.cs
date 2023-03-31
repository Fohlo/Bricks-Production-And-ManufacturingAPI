using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotechxAPI.Models.Items
{
    public class ItemsMDL
    {

            public string ItemCode { get; set; }
            public string ItemName { get; set; }
            public string ForeignName { get; set; }
            public int ItemsGroupCode { get; set; }
            public int CustomsGroupCode { get; set; }
            public string SalesVATGroup { get; set; }
            public string PurchaseItem { get; set; }
            public string SalesItem { get; set; }
            public string InventoryItem { get; set; }
            public object IncomeAccount { get; set; }
            public object ExemptIncomeAccount { get; set; }
            public object ExpanseAccount { get; set; }
            public string Mainsupplier { get; set; }
            public object SupplierCatalogNo { get; set; }
            public float DesiredInventory { get; set; }
            public float MinInventory { get; set; }
            public object Picture { get; set; }
            public object User_Text { get; set; }
            public object SerialNum { get; set; }
            public float CommissionPercent { get; set; }
            public float CommissionSum { get; set; }
            public int CommissionGroup { get; set; }
            public string TreeType { get; set; }
            public string AssetItem { get; set; }
            public object DataExportCode { get; set; }
            public int Manufacturer { get; set; }
            public float QuantityOnStock { get; set; }
            public float QuantityOrderedFromVendors { get; set; }
            public float QuantityOrderedByCustomers { get; set; }
            public string ManageSerialNumbers { get; set; }
            public string ManageBatchNumbers { get; set; }
            public string Valid { get; set; }
            public object ValidFrom { get; set; }
            public object ValidTo { get; set; }
            public object ValidRemarks { get; set; }
            public string Frozen { get; set; }
            public object FrozenFrom { get; set; }
            public object FrozenTo { get; set; }
            public object FrozenRemarks { get; set; }
            public object SalesUnit { get; set; }
            public float SalesItemsPerUnit { get; set; }
            public object SalesPackagingUnit { get; set; }
            public float SalesQtyPerPackUnit { get; set; }
            public object SalesUnitLength { get; set; }
            public object SalesLengthUnit { get; set; }
            public object SalesUnitWidth { get; set; }
            public object SalesWidthUnit { get; set; }
            public object SalesUnitHeight { get; set; }
            public object SalesHeightUnit { get; set; }
            public float SalesUnitVolume { get; set; }
            public int SalesVolumeUnit { get; set; }
            public float SalesUnitWeight { get; set; }
            public int SalesWeightUnit { get; set; }
            public object PurchaseUnit { get; set; }
            public float PurchaseItemsPerUnit { get; set; }
            public object PurchasePackagingUnit { get; set; }
            public float PurchaseQtyPerPackUnit { get; set; }
            public object PurchaseUnitLength { get; set; }
            public object PurchaseLengthUnit { get; set; }
            public object PurchaseUnitWidth { get; set; }
            public object PurchaseWidthUnit { get; set; }
            public object PurchaseUnitHeight { get; set; }
            public object PurchaseHeightUnit { get; set; }
            public float PurchaseUnitVolume { get; set; }
            public int PurchaseVolumeUnit { get; set; }
            public float PurchaseUnitWeight { get; set; }
            public int PurchaseWeightUnit { get; set; }
            public string PurchaseVATGroup { get; set; }
            public float SalesFactor1 { get; set; }
            public float SalesFactor2 { get; set; }
            public float SalesFactor3 { get; set; }
            public float SalesFactor4 { get; set; }
            public float PurchaseFactor1 { get; set; }
            public float PurchaseFactor2 { get; set; }
            public float PurchaseFactor3 { get; set; }
            public float PurchaseFactor4 { get; set; }
            public float MovingAveragePrice { get; set; }
            public object ForeignRevenuesAccount { get; set; }
            public object ECRevenuesAccount { get; set; }
            public object ForeignExpensesAccount { get; set; }
            public object ECExpensesAccount { get; set; }
            public float AvgStdPrice { get; set; }
            public object DefaultWarehouse { get; set; }
            public object ShipType { get; set; }
            public string GLMethod { get; set; }
            public string TaxType { get; set; }
            public float MaxInventory { get; set; }
            public string ManageStockByWarehouse { get; set; }
            public string ForceSelectionOfSerialNumber { get; set; }
            public string ManageSerialNumbersOnReleaseOnly { get; set; }
            public object BaseUnitName { get; set; }
            public object ItemCountryOrg { get; set; }
            public string IssueMethod { get; set; }
            public string SRIAndBatchManageMethod { get; set; }
            public string IsPhantom { get; set; }
            public string InventoryUOM { get; set; }
            public string PlanningSystem { get; set; }
            public string ProcurementMethod { get; set; }
            public string ComponentWarehouse { get; set; }
            public object OrderIntervals { get; set; }
            public float OrderMultiple { get; set; }
            public object LeadTime { get; set; }
            public float MinOrderQuantity { get; set; }
            public string ItemType { get; set; }
            public string ItemClass { get; set; }
            public int OutgoingServiceCode { get; set; }
            public int IncomingServiceCode { get; set; }
            public int ServiceGroup { get; set; }
            public int NCMCode { get; set; }
            public string MaterialType { get; set; }
            public int MaterialGroup { get; set; }
            public string ProductSource { get; set; }
            public string AutoCreateSerialNumbersOnRelease { get; set; }
            public int DNFEntry { get; set; }
            public object GTSItemSpec { get; set; }
            public object GTSItemTaxCategory { get; set; }
            public string IssuePrimarilyBy { get; set; }
            public string NoDiscounts { get; set; }
            public string AssetClass { get; set; }
            public string AssetGroup { get; set; }
            public string InventoryNumber { get; set; }
            public object Technician { get; set; }
            public object Employee { get; set; }
            public object Location { get; set; }
            public string AssetStatus { get; set; }
            public string ManageByQuantity { get; set; }
            public int UoMGroupEntry { get; set; }
            public int InventoryUoMEntry { get; set; }
            public object DefaultSalesUoMEntry { get; set; }
            public object DefaultPurchasingUoMEntry { get; set; }
            public string U_IIS_disPhantom { get; set; }
            public string U_IIS_disGroupItem { get; set; }
            public string U_IIS_disHotItem { get; set; }
            public string U_IIS_disQALevel { get; set; }
            public object U_IIS_disQAItem { get; set; }
            public string U_IIS_disInspect { get; set; }
            public string U_IIS_disNotify { get; set; }
            public object U_IIS_disNoteCode { get; set; }
            public string U_IIS_disBinSubType { get; set; }
            public string U_IIS_disBtchExpiry { get; set; }
            public List<Itemprice> ItemPrices { get; set; }
            public List<Itemwarehouseinfocollection> ItemWarehouseInfoCollection { get; set; }
           
           // public Itemintrastatextension ItemIntrastatExtension { get; set; }
        }

        //public class Itemintrastatextension
        //{
        //    public string ItemCode { get; set; }
        //    public object CommodityCode { get; set; }
        //    public object SupplementaryUnit { get; set; }
        //    public float FactorOfSupplementaryUnit { get; set; }
        //    public object ImportRegionState { get; set; }
        //    public object ExportRegionState { get; set; }
        //    public object ImportNatureOfTransaction { get; set; }
        //    public object ExportNatureOfTransaction { get; set; }
        //    public object ImportStatisticalProcedure { get; set; }
        //    public object ExportStatisticalProcedure { get; set; }
        //    public object CountryOfOrigin { get; set; }
        //    public object ServiceCode { get; set; }
        //    public string Type { get; set; }
        //    public string ServiceSupplyMethod { get; set; }
        //    public string ServicePaymentMethod { get; set; }
        //    public string ImportRegionCountry { get; set; }
        //    public string ExportRegionCountry { get; set; }
        //    public string UseWeightInCalculation { get; set; }
        //    public string IntrastatRelevant { get; set; }
        //    public object StatisticalCode { get; set; }
        //}

        public class Itemprice
        {
            public int PriceList { get; set; }
            public float Price { get; set; }
            public string Currency { get; set; }
            public float AdditionalPrice1 { get; set; }
            public object AdditionalCurrency1 { get; set; }
            public float AdditionalPrice2 { get; set; }
            public object AdditionalCurrency2 { get; set; }
            public int BasePriceList { get; set; }
            public float Factor { get; set; }
            public object[] UoMPrices { get; set; }
        }

        public class Itemwarehouseinfocollection
        {
            public float? MinimalStock { get; set; }
            public float? MaximalStock { get; set; }
            public float? MinimalOrder { get; set; }
            public float StandardAveragePrice { get; set; }
            public string Locked { get; set; }
            public object InventoryAccount { get; set; }
            public object CostAccount { get; set; }
            public object TransferAccount { get; set; }
            public string WarehouseCode { get; set; }
            public float? InStock { get; set; }
            public float? Committed { get; set; }
            public float? Ordered { get; set; }
            public float? CountedQuantity { get; set; }
            public string WasCounted { get; set; }
            public int UserSignature { get; set; }
            public float? Counted { get; set; }
            public int? DefaultBin { get; set; }
            public string DefaultBinEnforced { get; set; }
            public string ItemCode { get; set; }
            public float U_IIS_disPickMin { get; set; }
            public float U_IIS_disPickMax { get; set; }
        }

        public class Itempreferredvendor
        {
            public string BPCode { get; set; }
        }


    }

