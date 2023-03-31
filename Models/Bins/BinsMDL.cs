using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotechxAPI.Models.Bins
{
    public class BinsMDL
    {

            public int AbsEntry { get; set; }
            public string Warehouse { get; set; }
            public string Sublevel1 { get; set; }
            public object Sublevel2 { get; set; }
            public object Sublevel3 { get; set; }
            public object Sublevel4 { get; set; }
            public string BinCode { get; set; }
            public string Inactive { get; set; }
            public object Description { get; set; }
            public object AlternativeSortCode { get; set; }
            public object BarCode { get; set; }
            public object Attribute1 { get; set; }
            public object Attribute2 { get; set; }
            public object Attribute3 { get; set; }
            public object Attribute4 { get; set; }
            public object Attribute5 { get; set; }
            public object Attribute6 { get; set; }
            public object Attribute7 { get; set; }
            public object Attribute8 { get; set; }
            public object Attribute9 { get; set; }
            public object Attribute10 { get; set; }
            public string RestrictedItemType { get; set; }
            public object SpecificItem { get; set; }
            public object SpecificItemGroup { get; set; }
            public string BatchRestrictions { get; set; }
            public string RestrictedTransType { get; set; }
            public object RestrictionReason { get; set; }
            public object DateRestrictionChanged { get; set; }
            public float MinimumQty { get; set; }
            public float MaximumQty { get; set; }
            public string IsSystemBin { get; set; }
            public string ReceivingBinLocation { get; set; }
            public string ExcludeAutoAllocOnIssue { get; set; }
            public float MaximumWeight { get; set; }
            public float MaximumWeight1 { get; set; }
            public object MaximumWeightUnit { get; set; }
            public object MaximumWeightUnit1 { get; set; }
            public string RestrictedUoMType { get; set; }
            public object SpecificUoM { get; set; }
            public object SpecificUoMGroup { get; set; }
            public string U_IIS_proExclIss { get; set; }
            public string U_IIS_disBinType { get; set; }
            public string U_IIS_disBinSubType { get; set; }
            public object U_IIS_BinPickZone { get; set; }
        }

}
