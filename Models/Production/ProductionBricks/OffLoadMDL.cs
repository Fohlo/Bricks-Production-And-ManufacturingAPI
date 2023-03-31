using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotechxAPI.Models.Production.ProductionBricks
{
    public class OffLoadMDL
    {
        public int DocNum { get; set; }
        public int DocEntry { get; set; }
        public string U_Date { get; set; }
        public string U_TruckNo { get; set; }
        public string U_TruckName { get; set; }
        public string U_Driver { get; set; }
        public string U_Status { get; set; }
        public string U_BatchNo { get; set; }
        public List<OffLoadlinescollection> OFFTOTALSCLLCollection { get; set; }
        public List<OffLoadTotalscollection> OFFLOADCOLLECTIONCollection { get; set; }

        public class OffLoadlinescollection
        {
            public int DocNum { get; set; }
            public int DocEntry { get; set; }
            public string U_LoadNumber { get; set; }
            public string U_LoadType { get; set; }
            public string U_Shift { get; set; }
            public string U_Statusload { get; set; }
            public string U_OffloadTime { get; set; }
            public string U_Waste { get; set; }
            public string U_reason { get; set; }


        }
        public class OffLoadTotalscollection
        {
            public string U_Offloadtotal { get; set; }

        }

    }
    public class PostOffLoadMDL
    {
        public string U_Date { get; set; }
        public string U_TruckNo { get; set; }
        public string U_TruckName { get; set; }
        public string U_Driver { get; set; }
        public string U_Status { get; set; }
        public string U_BatchNo { get; set; }
        public List<OffLoadlinescollection> OFFTOTALSCLLCollection { get; set; }
        public List<OffLoadTotalscollection> OFFLOADCOLLECTIONCollection { get; set; }

        public class OffLoadlinescollection
        {
            public string U_LoadNumber { get; set; }
            public string U_LoadType { get; set; }
            public string U_Statusload { get; set; }
            public string U_Shift { get; set; }
            public string U_OffloadTime { get; set; }
            public string U_Waste { get; set; }
            public string U_reason { get; set; }

        }

        public class OffLoadTotalscollection
        {
            public string U_Offloadtotal { get; set; }

        }

    }
    public class PatchOffLoadMDL
    {
        public int DocEntry { get; set; }
        public string U_Date { get; set; }
        public string U_TruckNo { get; set; }
        public string U_TruckName { get; set; }
        public string U_Driver { get; set; }
        public string U_Status { get; set; }
        public string U_BatchNo { get; set; }
        public List<OffLoadlinescollection> OFFTOTALSCLLCollection { get; set; }
        public List<OffLoadTotalscollection> OFFLOADCOLLECTIONCollection { get; set; }


        public class OffLoadlinescollection
        {
            // public int LineId { get; set; }
            public string U_LoadNumber { get; set; }
            public string U_LoadType { get; set; }
            public string U_Statusload { get; set; }
            public string U_Shift { get; set; }
            public string U_OffloadTime { get; set; }
            public string U_Waste { get; set; }
            public string U_reason { get; set; }

        }

        public class OffLoadTotalscollection
        {
            public string U_Offloadtotal { get; set; }

        }
    }
}
