using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotechxAPI.Models.Production.ProductionBricks
{
    public class ProductionLogSheetMDL
    {
        public int DocNum { get; set; }
        public int DocEntry { get; set; }
        public string U_Date { get; set; }
        public string U_Plant { get; set; }
        public string U_Shift { get; set; }
        public string U_Checker { get; set; }
        public string U_WeekNumber { get; set; }
        public float U_Production { get; set; }
        public float U_TotalProduction { get; set; }
        public float U_SubTotal { get; set; }
        public float U_BatchNo { get; set; }
        public float U_Status { get; set; }
        public string U_Area { get; set; }


        public List<Productionlslinescollection> PRODLINESCollection { get; set; }

        public class Productionlslinescollection
        {
            public int LineId { get; set; }
            public string U_Area { get; set; }
            public float U_HacklineNo { get; set; }
            public float U_TotalPallets { get; set; }
            public float U_A { get; set; }
            public float U_B { get; set; }
            public float U_C { get; set; }
            public float U_D { get; set; }
            public float U_E { get; set; }
            public float U_F { get; set; }
            public float U_G { get; set; }
            public float U_H { get; set; }
            public float U_I { get; set; }
            public float U_J { get; set; }
            public float U_K { get; set; }
        }
    }
    public class PostProductionLogSheetMDL
    {
        public string U_Date { get; set; }
        public string U_Plant { get; set; }
        public string U_Shift { get; set; }
        public string U_Checker { get; set; }
        public string U_WeekNumber { get; set; }
        public float U_Production { get; set; }
        public float U_TotalProduction { get; set; }
        public float U_SubTotal { get; set; }
        public float U_BatchNo { get; set; }
        public float U_Status { get; set; }
        public string U_Area { get; set; }

        public List<Productionlslinescollection> PRODLINESCollection { get; set; }
        public class Productionlslinescollection
        {
            public string U_Area { get; set; }
            public float U_HacklineNo { get; set; }
            public float U_TotalPallets { get; set; }
            public float U_A { get; set; }
            public float U_B { get; set; }
            public float U_C { get; set; }
            public float U_D { get; set; }
            public float U_E { get; set; }
            public float U_F { get; set; }
            public float U_G { get; set; }
            public float U_H { get; set; }
            public float U_I { get; set; }
            public float U_J { get; set; }
            public float U_K { get; set; }
        }
    }
    public class PatchProductionLogSheetMDL
    {
        public int DocNum { get; set; }
        public int DocEntry { get; set; }
        public string U_Date { get; set; }
        public string U_Plant { get; set; }
        public string U_Shift { get; set; }
        public string U_Checker { get; set; }
        public string U_WeekNumber { get; set; }
        public float U_Production { get; set; }
        public float U_TotalProduction { get; set; }
        public float U_SubTotal { get; set; }
        public float U_BatchNo { get; set; }
        public float U_Status { get; set; }
        public string U_Area { get; set; }

        public List<Productionlslinescollection> PRODLINESCollection { get; set; }
        public class Productionlslinescollection
        {
            public string U_Area { get; set; }
            public float U_HacklineNo { get; set; }
            public float U_TotalPallets { get; set; }
            public float U_A { get; set; }
            public float U_B { get; set; }
            public float U_C { get; set; }
            public float U_D { get; set; }
            public float U_E { get; set; }
            public float U_F { get; set; }
            public float U_G { get; set; }
            public float U_H { get; set; }
            public float U_I { get; set; }
            public float U_J { get; set; }
            public float U_K { get; set; }
        }
    }
}
