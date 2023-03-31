using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotechxAPI.Models.Production.ProductionBricks
{
    public class ProHacklineHandoverMDL
    {
       
            public int DocNum { get; set; }
            public int DocEntry { get; set; }
            public string U_HandoverDate { get; set; }
            public string U_DateManufacturedStart { get; set; }
            public string U_DateManufacturedEnd { get; set; }
            public string U_Name { get; set; }
            public float U_Area { get; set; }
            public string U_ClampShift { get; set; }
            public float U_Quantity { get; set; }
        }
    public class PostProHacklineHandoverMDL
    {

        public string U_HandoverDate { get; set; }
        public string U_DateManufacturedStart { get; set; }
        public string U_DateManufacturedEnd { get; set; }
        public string U_Name { get; set; }
        public float U_Area { get; set; }
        public string U_ClampShift { get; set; }
        public float U_Quantity { get; set; }
    }
    public class PatchProHacklineHandoverMDL
    {
        
        public int DocNum { get; set; }
        public int DocEntry { get; set; }
        public string U_HandoverDate { get; set; }
        public string U_DateManufacturedStart { get; set; }
        public string U_DateManufacturedEnd { get; set; }
        public string U_Name { get; set; }
        public float U_Area { get; set; }
        public string U_ClampShift { get; set; }
        public float U_Quantity { get; set; }
    }
}

