using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotechxAPI.Models.Production.ProductionBricks
{
    public class HkcdailyupdateMDL
    {
        public int DocNum { get; set; }
        public int DocEntry { get; set; }
        public string U_Status { get; set; }
        public string U_Date { get; set; }
        public string U_Area { get; set; }
        public float U_Totals { get; set; }
        public string U_Operator { get; set; }
        public string U_Inspector { get; set; }
        public List<Hkcdailycollection> HKCDAILYCLLCollection { get; set; }

        public class Hkcdailycollection
        {
            public int DocNum { get; set; }
            public int DocEntry { get; set; }
            public string U_Shift { get; set; }
            public string U_Date { get; set; }
            public string U_Time { get; set; }
            public string U_Amountbricks { get; set; }
            public string U_Loader { get; set; }



        }

    }
    public class PostHkcdailyupdateMDL
    {
        public string U_Status { get; set; }
        public string U_Date { get; set; }
        public string U_Area { get; set; }
        public string U_Totals { get; set; }
        public string U_Operator { get; set; }
        public string U_Inspector { get; set; }
        public List<Hkcdailycollection> HKCDAILYCLLCollection { get; set; }

        public class Hkcdailycollection
        {
            public string U_Shift { get; set; }
            public string U_Date { get; set; }
            public string U_Time { get; set; }
            public string U_Amountbricks { get; set; }
            public string U_Loader { get; set; }

        }



    }
    public class PatchHkcdailyupdateMDL
    {
        public int DocEntry { get; set; }
        public string U_Status { get; set; }
        public string U_Date { get; set; }
        public string U_Area { get; set; }
        public string U_Totals { get; set; }
        public string U_Operator { get; set; }
        public string U_Inspector { get; set; }
        public List<Hkcdailycollection> HKCDAILYCLLCollection { get; set; }


        public class Hkcdailycollection
        {
            // public int LineId { get; set; }
            public string U_Shift { get; set; }
            public string U_Date { get; set; }
            public string U_Time { get; set; }
            public string U_Amountbricks { get; set; }
            public string U_Loader { get; set; }


        }


    }
}
