using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotechxAPI.Models.Production.ProductionBricks
{
    public class FinishedBricksPalletisedMDL
    {
        public int DocNum { get; set; }
        public int DocEntry { get; set; }
        public string U_Status { get; set; }
        public string U_Date { get; set; }
        public string U_TotalsBDF { get; set; }
        public string U_TotalsBLB { get; set; }
        public string U_TotalsBBC { get; set; }
        public string U_TotalsOC { get; set; }
        public string U_TotalsBCK { get; set; }
        public string U_TotalsT { get; set; }
        public List<FinishedBrickslinescollection> FBPALLETISEDCLLCollection { get; set; }
        public List<FirstCollection> FBPALLETISEDD1Collection { get; set; }
        public List<SecondCollection> FBPALLETISEDD2Collection { get; set; }
        public List<TotalCollection> FBPALLETISEDTOTALSCollection { get; set; }


        public class FinishedBrickslinescollection
        {
            public int LineId { get; set; }
            public string U_Time { get; set; }
            public string U_Clampnumber { get; set; }
            public string U_Area { get; set; }
            public string U_Inspector { get; set; }
            public string U_BDF { get; set; }
            public string U_BLB { get; set; }
            public string U_BBC { get; set; }
            public string U_OC { get; set; }
            public string U_BCK { get; set; }
            public string U_Totals { get; set; }
            public string U_ClosingStock { get; set; }
          
        }
        public class FirstCollection
        {
            public int LineId { get; set; }
            public string U_Time { get; set; }
            public string U_Clampnumber { get; set; }
            public string U_Area { get; set; }
            public string U_Plant { get; set; }
            public float U_BDF { get; set; }
            public float U_BLB { get; set; }
            public float U_BBC { get; set; }
            public float U_OC { get; set; }
            public float U_BCK { get; set; }
            public float U_Totals { get; set; }
           
        }
        public class SecondCollection
        {
            public int LineId { get; set; }
            public string U_Packtype { get; set; }
            public float U_BDF { get; set; }
            public float U_BLB { get; set; }
            public float U_BBC { get; set; }
            public float U_OC { get; set; }
            public float U_BCK { get; set; }
            public float U_TotalDispatch { get; set; }

        }
        public class TotalCollection
        {
            public int LineId { get; set; }
            public string U_Plant { get; set; }
            public string U_Bricktype { get; set; }
            public float U_Total { get; set; }

        }
    }
    public class PostFinishedBricksPalletisedMDL
    {
        public string U_Status { get; set; }
        public string U_Date { get; set; }
        public string U_TotalsBDF { get; set; }
        public string U_TotalsBLB { get; set; }
        public string U_TotalsBBC { get; set; }
        public string U_TotalsOC { get; set; }
        public string U_TotalsBCK { get; set; }
        public string U_TotalsT { get; set; }
        public List<FinishedBrickslinescollection> FBPALLETISEDCLLCollection { get; set; }
        public List<FirstCollection> FBPALLETISEDD1Collection { get; set; }
        public List<SecondCollection> FBPALLETISEDD2Collection { get; set; }
        public List<TotalCollection> FBPALLETISEDTOTALSCollection { get; set; }
        public class FinishedBrickslinescollection
        {
            public string U_Time { get; set; }
            public string U_Clampnumber { get; set; }
            public string U_Area { get; set; }
            public string U_Inspector { get; set; }
            public float U_BDF { get; set; }
            public float U_BLB { get; set; }
            public float U_BBC { get; set; }
            public float U_OC { get; set; }
            public float U_BCK { get; set; }
            public float U_Totals { get; set; }
            public float U_ClosingStock { get; set; }
            
        }


        public class FirstCollection
        {
           
            public string U_Time { get; set; }
            public string U_Clampnumber { get; set; }
            public string U_Area { get; set; }
            public string U_Plant { get; set; }
            public float U_BDF { get; set; }
            public float U_BLB { get; set; }
            public float U_BBC { get; set; }
            public float U_OC { get; set; }
            public float U_BCK { get; set; }
            public float U_Totals { get; set; }

        }
        public class SecondCollection
        {
            
            public string U_Packtype { get; set; }
            public float U_BDF { get; set; }
            public float U_BLB { get; set; }
            public float U_BBC { get; set; }
            public float U_OC { get; set; }
            public float U_BCK { get; set; }
            public float U_TotalDispatch { get; set; }

        }
        public class TotalCollection
        {
           
            public string U_Plant { get; set; }
            public string U_Bricktype { get; set; }
            public float U_Total { get; set; }

        }

    }
    public class PatchFinishedBricksPalletisedMDL
    {
        public int DocEntry { get; set; }
        public string U_Status { get; set; }
        public string U_Date { get; set; }
        public string U_TotalsBDF { get; set; }
        public string U_TotalsBLB { get; set; }
        public string U_TotalsBBC { get; set; }
        public string U_TotalsOC { get; set; }
        public string U_TotalsBCK { get; set; }
        public string U_TotalsT { get; set; }
        public List<FinishedBrickslinescollection> FBPALLETISEDCLLCollection { get; set; }
        public List<FirstCollection> FBPALLETISEDD1Collection { get; set; }
        public List<SecondCollection> FBPALLETISEDD2Collection { get; set; }
        public List<TotalCollection> FBPALLETISEDTOTALSCollection { get; set; }

        public class FinishedBrickslinescollection
        {
            public string U_Time { get; set; }
            public string U_Clampnumber { get; set; }
            public string U_Area { get; set; }
            public string U_Inspector { get; set; }
            public float U_BDF { get; set; }
            public float U_BLB { get; set; }
            public float U_BBC { get; set; }
            public float U_OC { get; set; }
            public float U_BCK { get; set; }
            public float U_Totals { get; set; }
            public float U_ClosingStock { get; set; }
           
        }
        public class FirstCollection
        {
            
            public string U_Time { get; set; }
            public string U_Clampnumber { get; set; }
            public string U_Area { get; set; }
            public string U_Plant { get; set; }
            public float U_BDF { get; set; }
            public float U_BLB { get; set; }
            public float U_BBC { get; set; }
            public float U_OC { get; set; }
            public float U_BCK { get; set; }
            public float U_Totals { get; set; }

        }
        public class SecondCollection
        {

            public string U_Packtype { get; set; }
            public float U_BDF { get; set; }
            public float U_BLB { get; set; }
            public float U_BBC { get; set; }
            public float U_OC { get; set; }
            public float U_BCK { get; set; }
            public float U_TotalDispatch { get; set; }

        }
        public class TotalCollection
        {

            public string U_Plant { get; set; }
            public string U_Bricktype { get; set; }
            public float U_Total { get; set; }

        }


    }
}
