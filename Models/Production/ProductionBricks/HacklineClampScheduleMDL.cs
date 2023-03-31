using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotechxAPI.Models.Production.ProductionBricks
{
    public class HacklineClampScheduleMDL
    {
        public int DocNum { get; set; }
        public int DocEntry { get; set; }
        public string U_Date { get; set; }
        public string U_ClampNo { get; set; }
        public string U_Area { get; set; }
        public string U_Plant { get; set; }
        public string U_TotalPallets { get; set; }
        public string U_TotalPacked { get; set; }
        public List<Hacklineclamplinescollection> HCSCLLCollection { get; set; }
        public List<Hacklineseparationcollection> HCSDCollection { get; set; }
        public class Hacklineclamplinescollection
        {
            public int LineId { get; set; }
            public string U_Shift { get; set; }
            public float U_NoOfGuys { get; set; }
            public float U_PalletNo { get; set; }
            public float U_ProductionNo { get; set; }
        }

        public class Hacklineseparationcollection
        {
            public int LineId { get; set; }
            public string U_ClampNo { get; set; }
            public string U_Area { get; set; }
            public string U_Plant { get; set; }
            public float U_ProductionNo { get; set; }
            public float U_WasteNo { get; set; }
            public float U_ActualPacked { get; set; }
        }
    }

    public class PostHacklineClampScheduleMDL
    {
        public string U_Date { get; set; }
        public string U_ClampNo { get; set; }
        public string U_Area { get; set; }
        public string U_Plant { get; set; }
        public string U_TotalPallets { get; set; }
        public string U_TotalPacked { get; set; }
        public List<Hacklineclamplinescollection> HCSCLLCollection { get; set; }
        public List<Hacklineseparationcollection> HCSDCollection { get; set; }

        public class Hacklineclamplinescollection
        {
           
            public string U_Shift { get; set; }
            public float U_NoOfGuys { get; set; }
            public float U_PalletNo { get; set; }
            public float U_ProductionNo { get; set; }
        }

        public class Hacklineseparationcollection
        {
          
            public string U_ClampNo { get; set; }
            public string U_Area { get; set; }
            public string U_Plant { get; set; }
            public float U_ProductionNo { get; set; }
            public float U_WasteNo { get; set; }
            public float U_ActualPacked { get; set; }
        }
    }
    public class PatchHacklineClampScheduleMDL
    {
        public int DocEntry { get; set; }
        public string U_Date { get; set; }
        public string U_ClampNo { get; set; }
        public string U_Area { get; set; }
        public string U_Plant { get; set; }
        public string U_TotalPallets { get; set; }
        public string U_TotalPacked { get; set; }
        public List<Hacklineclamplinescollection> HCSCLLCollection { get; set; }
        public List<Hacklineseparationcollection> HCSDCollection { get; set; }
        public class Hacklineclamplinescollection
        {
            
            public string U_Shift { get; set; }
            public float U_NoOfGuys { get; set; }
            public float U_PalletNo { get; set; }
            public float U_ProductionNo { get; set; }
        }

        public class Hacklineseparationcollection
        {
          
            public string U_ClampNo { get; set; }
            public string U_Area { get; set; }
            public string U_Plant { get; set; }
            public float U_ProductionNo { get; set; }
            public float U_WasteNo { get; set; }
            public float U_ActualPacked { get; set; }
        }
    }
}
