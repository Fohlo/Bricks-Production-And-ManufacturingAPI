using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotechxAPI.Models.Production.ProductionBricks
{
    public class ExtrusionLogSheetMDL
    {
        public int DocNum { get; set; }
        public int DocEntry { get; set; }
        public string U_Date { get; set; }
        public string U_Plant { get; set; }
        public string U_Shift { get; set; }
        public float U_Cuts { get; set; }
        public float U_Water { get; set; }
        public float U_TotalProduction { get; set; }
        public string U_Operator { get; set; }
        public string U_Foreman { get; set; }
        public string U_Areas { get; set; }
        public string U_BatchNo { get; set; }
        public List<Extrusionlslinescollection> EXTRUSIONLINESCollection { get; set; }
        public List<Extrusionlstotalslinescollection> EXTLOGTOTALSCollection { get; set; }
        public List<Extrusionlssumlinescollection> EXTRUSIONCLLCollection { get; set; }
        public class Extrusionlslinescollection
        {
            public int LineId { get; set; }
            public string U_Time { get; set; }
            public float U_Cutter { get; set; }
            public float U_Hackline { get; set; }
            public float U_Waste { get; set; }
            public float U_Cuts { get; set; }
            public float U_Run { get; set; }
            public float U_Down { get; set; }
            public string U_DowntimeReasons { get; set; }
        }
        public class Extrusionlstotalslinescollection
        {
            public int LineId { get; set; }
            public float U_CutterTotal { get; set; }
            public float U_HacklineTotal { get; set; }
            public float U_WasteTotal { get; set; }
            public float U_CutsTotal { get; set; }
            public float U_RunTotal { get; set; }
            public float U_DownTotal { get; set; }
        }

        public class Extrusionlssumlinescollection
        {
            public int LineId { get; set; }
            public float U_Availability { get; set; }
            public float U_Utilization { get; set; }
            public float U_Waste { get; set; }
            public float U_ExtrusionRate { get; set; }
            public float U_Runtime { get; set; }
            public float U_Downtime { get; set; }
        }
    }
    public class PostExtrusionLogSheetMDL
    {
        public string U_Date { get; set; }
        public string U_Plant { get; set; }
        public string U_Shift { get; set; }
        public float U_Cuts { get; set; }
        public float U_Water { get; set; }
        public float U_TotalProduction { get; set; }
        public string U_Operator { get; set; }
        public string U_Foreman { get; set; }
        public string U_Areas { get; set; }
        public string U_BatchNo { get; set; }
        public List<Extrusionlslinescollection> EXTRUSIONLINESCollection { get; set; }
        public List<Extrusionlstotalslinescollection> EXTLOGTOTALSCollection { get; set; }
        public List<Extrusionlssumlinescollection> EXTRUSIONCLLCollection { get; set; }
        public class Extrusionlslinescollection
        {
            public string U_Time { get; set; }
            public float U_Cutter { get; set; }
            public float U_Hackline { get; set; }
            public float U_Waste { get; set; }
            public float U_Cuts { get; set; }
            public float U_Run { get; set; }
            public float U_Down { get; set; }
            public string U_DowntimeReasons { get; set; }
        }
        public class Extrusionlstotalslinescollection
        {
            public float U_CutterTotal { get; set; }
            public float U_HacklineTotal { get; set; }
            public float U_WasteTotal { get; set; }
            public float U_CutsTotal { get; set; }
            public float U_RunTotal { get; set; }
            public float U_DownTotal { get; set; }
        }

        public class Extrusionlssumlinescollection
        {
            public int LineId { get; set; }
            public float U_Availability { get; set; }
            public float U_Utilization { get; set; }
            public float U_Waste { get; set; }
            public float U_ExtrusionRate { get; set; }
            public float U_Runtime { get; set; }
            public float U_Downtime { get; set; }
        }
    }
    public class PatchExtrusionLogSheetMDL
    {
        public int DocNum { get; set; }
        public int DocEntry { get; set; }
        public string U_Date { get; set; }
        public string U_Plant { get; set; }
        public string U_Shift { get; set; }
        public float U_Cuts { get; set; }
        public float U_Water { get; set; }
        public float U_TotalProduction { get; set; }
        public string U_Operator { get; set; }
        public string U_Foreman { get; set; }
        public string U_Areas { get; set; }
        public string U_BatchNo { get; set; }
        public List<Extrusionlslinescollection> EXTRUSIONLINESCollection { get; set; }
        public List<Extrusionlstotalslinescollection> EXTLOGTOTALSCollection { get; set; }
        public List<Extrusionlssumlinescollection> EXTRUSIONCLLCollection { get; set; }
        public class Extrusionlslinescollection
        {
           
            public string U_Time { get; set; }
            public float U_Cutter { get; set; }
            public float U_Hackline { get; set; }
            public float U_Waste { get; set; }
            public float U_Cuts { get; set; }
            public float U_Run { get; set; }
            public float U_Down { get; set; }
            public string U_DowntimeReasons { get; set; }
        }

        public class Extrusionlstotalslinescollection
        {
            //public int LineId { get; set; }
            public float U_CutterTotal { get; set; }
            public float U_HacklineTotal { get; set; }
            public float U_WasteTotal { get; set; }
            public float U_CutsTotal { get; set; }
            public float U_RunTotal { get; set; }
            public float U_DownTotal { get; set; }
        }

        public class Extrusionlssumlinescollection
        {
            public float U_Availability { get; set; }
            public float U_Utilization { get; set; }
            public float U_Waste { get; set; }
            public float U_ExtrusionRate { get; set; }
            public float U_Runtime { get; set; }
            public float U_Downtime { get; set; }
        }
    }
}
