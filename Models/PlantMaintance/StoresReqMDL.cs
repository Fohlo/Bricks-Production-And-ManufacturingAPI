using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotechxAPI.Models.PlantMaintance
{
    public class StoresReqMDL
    {
            public int DocNum { get; set; }
            public int DocEntry { get; set; }
            public string U_RequestBy { get; set; }
            public string U_Disburse { get; set; }
            public string U_ApprovedBy { get; set; }
            public string U_DisbursedBy { get; set; }
            public List<Storeqlcollection> STOREQLCollection { get; set; }
        

        public class Storeqlcollection
        {
            public int DocEntry { get; set; }
            public int LineId { get; set; }
            public int U_Quantity { get; set; }
            public string U_Item { get; set; }
            public string U_Description { get; set; }
        }


    }

    public class PostStoresReqMDL
    {
        public string U_RequestBy { get; set; }
        public string U_Disburse { get; set; }
        public string U_ApprovedBy { get; set; }
        public string U_DisbursedBy { get; set; }
        public List<Storeqlcollection> STOREQLCollection { get; set; }


        public class Storeqlcollection
        {
            public int U_Quantity { get; set; }
            public string U_Item { get; set; }
            public string U_Description { get; set; }
        }


    }

    public class PatchStoresReqMDL
    {
        public string U_RequestBy { get; set; }
        public string U_Disburse { get; set; }
        public string U_ApprovedBy { get; set; }
        public string U_DisbursedBy { get; set; }
        public List<Storeqlcollection> STOREQLCollection { get; set; }


        public class Storeqlcollection
        {
            public int LineId { get; set; }
            public int U_Quantity { get; set; }
            public string U_Item { get; set; }
            public string U_Description { get; set; }
        }


    }
}
