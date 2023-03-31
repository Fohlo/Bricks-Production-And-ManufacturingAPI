using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotechxAPI.Models.ProductionOrder
{
    public class ProductionOrderMDL
    {
            public int AbsoluteEntry { get; set; }
            public int DocumentNumber { get; set; }
            public string ItemNo { get; set; }
            public string ProductionOrderStatus { get; set; }
            public string ProductionOrderType { get; set; }
            public float PlannedQuantity { get; set; }
            public float CompletedQuantity { get; set; }
            public float RejectedQuantity { get; set; }
            public string PostingDate { get; set; }
            public string DueDate { get; set; }
            public string EndDate { get; set; }
            public Productionorderline[] ProductionOrderLines { get; set; }
        

        public class Productionorderline
        {
            public int DocumentAbsoluteEntry { get; set; }
            public int LineNumber { get; set; }
            public string ItemNo { get; set; }
            public float BaseQuantity { get; set; }
            public float PlannedQuantity { get; set; }
            public float IssuedQuantity { get; set; }
            public string ProductionOrderIssueType { get; set; }
            public string Warehouse { get; set; }
            public int VisualOrder { get; set; }
            public object DistributionRule { get; set; }
            public object LocationCode { get; set; }
            public object Project { get; set; }
            public object DistributionRule2 { get; set; }
            public object DistributionRule3 { get; set; }
            public object DistributionRule4 { get; set; }
            public object DistributionRule5 { get; set; }
            public int UoMEntry { get; set; }
            public int UoMCode { get; set; }
            public object WipAccount { get; set; }
            public string ItemType { get; set; }
            public object LineText { get; set; }
            public float AdditionalQuantity { get; set; }
            public object ResourceAllocation { get; set; }
            public string StartDate { get; set; }
            public string EndDate { get; set; }
            public object StageID { get; set; }
            public float RequiredDays { get; set; }
        }

    }
}
