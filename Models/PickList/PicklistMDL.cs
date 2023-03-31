using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotechxAPI.Models.PickList
{
    public class PicklistMDL
    {
            public int Absoluteentry { get; set; }
            public string Name { get; set; }
            public int OwnerCode { get; set; }
            public object OwnerName { get; set; }
            public string PickDate { get; set; }
            public object Remarks { get; set; }
            public string Status { get; set; }
            public string ObjectType { get; set; }
            public string UseBaseUnits { get; set; }
            public object U_IIS_disUser { get; set; }
            public string U_IIS_disInUse { get; set; }
            public object U_IIS_disTimeStamp { get; set; }
            public object U_IIS_ConsNo { get; set; }
            public object U_IIS_SF_Tracking { get; set; }
            public object U_IIS_SF_Volume { get; set; }
            public Picklistsline[] PickListsLines { get; set; }
        }

        public class Picklistsline
        {
            public int AbsoluteEntry { get; set; }
            public int LineNumber { get; set; }
            public int OrderEntry { get; set; }
            public int OrderRowID { get; set; }
            public float PickedQuantity { get; set; }
            public string PickStatus { get; set; }
            public float ReleasedQuantity { get; set; }
            public float PreviouslyReleasedQuantity { get; set; }
            public int BaseObjectType { get; set; }
            public object U_IIS_ParcelNo { get; set; }
            public object U_IIS_CStatus { get; set; }
            public object U_IIS_wmsRef1 { get; set; }
            public object U_IIS_wmsRef2 { get; set; }
            public object U_IIS_wmsRef3 { get; set; }
            public object U_IIS_disPackQty { get; set; }
            public object U_IIS_UniqueRef { get; set; }
            public object[] SerialNumbers { get; set; }
            public object[] BatchNumbers { get; set; }
            public object[] DocumentLinesBinAllocations { get; set; }
        }
}
