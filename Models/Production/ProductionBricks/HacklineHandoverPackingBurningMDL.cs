using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotechxAPI.Models.Production.ProductionBricks
{
    public class HacklineHandoverPackingBurningMDL
    {
        public int DocNum { get; set; }
        public int DocEntry { get; set; }
        public string U_HandoverDate { get; set; }
        public string U_MStartDate { get; set; }
        public string U_MEndDate { get; set; }
        public float U_Quantity { get; set; }
        public string U_ClampShift { get; set; }
        public string U_Area { get; set; }
        public string U_SignatureA { get; set; }
        public string U_SignatureB { get; set; }
        public string U_SignatureC { get; set; }
    }
    public class PostHacklineHandoverPackingBurningMDL
    {
       
        public string U_HandoverDate { get; set; }
        public string U_MStartDate { get; set; }
        public string U_MEndDate { get; set; }
        public float U_Quantity { get; set; }
        public string U_ClampShift { get; set; }
        public string U_Area { get; set; }
        public string U_SignatureA { get; set; }
        public string U_SignatureB { get; set; }
        public string U_SignatureC { get; set; }
    }
    public class PatchHacklineHandoverPackingBurningMDL
    {
     
        public int DocEntry { get; set; }
        public string U_HandoverDate { get; set; }
        public string U_MStartDate { get; set; }
        public string U_MEndDate { get; set; }
        public float U_Quantity { get; set; }
        public string U_ClampShift { get; set; }
        public string U_Area { get; set; }
        public string U_SignatureA { get; set; }
        public string U_SignatureB { get; set; }
        public string U_SignatureC { get; set; }
    }
}
