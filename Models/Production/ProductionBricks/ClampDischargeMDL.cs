using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotechxAPI.Models.Production.ProductionBricks
{
   public class ClampDischargeMDL
    {
        public int DocNum { get; set; }
        public int DocEntry { get; set; }
        public string U_Date { get; set; }
        public string U_GrvNumber { get; set; }
        public string U_ClampNumber { get; set; }
        public float U_QuantityPack { get; set; }
        public string U_Plant { get; set; }
        public string U_Area { get; set; }
        public List<ClampDischargeCollection> CLAMPDCLLCollection { get; set; }
        public List<ClampDischargeTotals> CLAMPDDCollection { get; set; }

        public class ClampDischargeCollection
        {
            public int LineId { get; set; }
            public string U_ListDate { get; set; }
            public float U_OpeningBalance { get; set; }
            public float U_BDF { get; set; }
            public float U_BLB { get; set; }
            public float U_BBH { get; set; }
            public float U_Budget { get; set; }
            public float U_Out { get; set; }
            public float U_BCK { get; set; }
            public float U_RainDamage { get; set; }
            public float U_ClosingBalance { get; set; }
            public string U_Comment { get; set; }
            public string U_DispatchSup { get; set; }
            public string U_DateSup { get; set; }
            public string U_BurnSup { get; set; }
            public string U_BurnSupDate { get; set; }
            public string U_EarthSup { get; set; }
            public string U_EarthSupDate { get; set; }
            public string U_QCSup { get; set; }
            public string U_QCSupDate { get; set; }
            public float U_Wastage { get; set; }


        }

        public class ClampDischargeTotals
        {
            public float U_ListTotal { get; set; }
            public float U_TotalBDF { get; set; }
            public float U_TotalBLB { get; set; }
            public float U_TotalBBH { get; set; }
            public float U_TotalBudget { get; set; }
            public float U_TotalOUT { get; set; }
            public float U_TotalBCK { get; set; }
            public float U_TRainDamage { get; set; }
            public float U_TPacked { get; set; }
            public float U_TPackedBDF { get; set; }
            public float U_TPackedBLB { get; set; }
            public float U_TPackedBBH { get; set; }
            public float U_TPackedBudget { get; set; }
            public float U_TPackedOUT { get; set; }
            public float U_TPackedBCK { get; set; }
            public float U_TPackedRainDamage { get; set; }
        }
    }
    
    public class PostClampDischargeMDL
    {
        public string U_Date { get; set; }
        public string U_GrvNumber { get; set; }
        public string U_ClampNumber { get; set; }
        public float U_QuantityPack { get; set; }
        public string U_Plant { get; set; }
        public string U_Area { get; set; }
        public List<ClampDischargeCollection> CLAMPDCLLCollection { get; set; }
        public List<ClampDischargeTotals> CLAMPDDCollection { get; set; }


        public class ClampDischargeCollection
        {
            
            public string U_ListDate { get; set; }
            public float U_OpeningBalance { get; set; }
            public float U_BDF { get; set; }
            public float U_BLB { get; set; }
            public float U_BBH { get; set; }
            public float U_Budget { get; set; }
            public float U_Out { get; set; }
            public float U_BCK { get; set; }
            public float U_RainDamage { get; set; }
            public float U_ClosingBalance { get; set; }
            public string U_Comment { get; set; }
            public string U_DispatchSup { get; set; }
            public string U_DateSup { get; set; }
            public string U_BurnSup { get; set; }
            public string U_BurnSupDate { get; set; }
            public string U_EarthSup { get; set; }
            public string U_EarthSupDate { get; set; }
            public string U_QCSup { get; set; }
            public string U_QCSupDate { get; set; }
            public float U_Wastage { get; set; }


        }

       public class ClampDischargeTotals
        {
            public float U_ListTotal { get; set; }
            public float U_TotalBDF { get; set; }
            public float U_TotalBLB { get; set; }
            public float U_TotalBBH { get; set; }
            public float U_TotalBudget { get; set; }
            public float U_TotalOUT { get; set; }
            public float U_TotalBCK { get; set; }
            public float U_TRainDamage { get; set; }
            public float U_TPacked { get; set; }
            public float U_TPackedBDF { get; set; }
            public float U_TPackedBLB { get; set; }
            public float U_TPackedBBH { get; set; }
            public float U_TPackedBudget { get; set; }
            public float U_TPackedOUT { get; set; }
            public float U_TPackedBCK { get; set; }
            public float U_TPackedRainDamage { get; set; }
        }
    }
    
    public class PatchClampDischargeMDL
    {
        public int DocEntry { get; set; }
        public string U_Date { get; set; }
        public string U_GrvNumber { get; set; }
        public string U_ClampNumber { get; set; }
        public float U_QuantityPack { get; set; }
        public string U_Plant { get; set; }
        public string U_Area { get; set; }
        public List<ClampDischargeCollection> CLAMPDCLLCollection { get; set; }
        public List<ClampDischargeTotals> CLAMPDDCollection { get; set; }


        public class ClampDischargeCollection
        {
         
            public string U_ListDate { get; set; }
            public float U_OpeningBalance { get; set; }
            public float U_BDF { get; set; }
            public float U_BLB { get; set; }
            public float U_BBH { get; set; }
            public float U_Budget { get; set; }
            public float U_Out { get; set; }
            public float U_BCK { get; set; }
            public float U_RainDamage { get; set; }
            public float U_ClosingBalance { get; set; }
            public string U_Comment { get; set; }
            public string U_DispatchSup { get; set; }
            public string U_DateSup { get; set; }
            public string U_BurnSup { get; set; }
            public string U_BurnSupDate { get; set; }
            public string U_EarthSup { get; set; }
            public string U_EarthSupDate { get; set; }
            public string U_QCSup { get; set; }
            public string U_QCSupDate { get; set; }
            public float U_Wastage { get; set; }


        }

         public class ClampDischargeTotals
        {
            public float U_ListTotal { get; set; }
            public float U_TotalBDF { get; set; }
            public float U_TotalBLB { get; set; }
            public float U_TotalBBH { get; set; }
            public float U_TotalBudget { get; set; }
            public float U_TotalOUT { get; set; }
            public float U_TotalBCK { get; set; }
            public float U_TRainDamage { get; set; }
            public float U_TPacked { get; set; }
            public float U_TPackedBDF { get; set; }
            public float U_TPackedBLB { get; set; }
            public float U_TPackedBBH { get; set; }
            public float U_TPackedBudget { get; set; }
            public float U_TPackedOUT { get; set; }
            public float U_TPackedBCK { get; set; }
            public float U_TPackedRainDamage { get; set; }
        }
    }
}
