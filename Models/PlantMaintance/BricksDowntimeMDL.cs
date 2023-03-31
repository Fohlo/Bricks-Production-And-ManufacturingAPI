using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotechxAPI.Models.PlantMaintance
{
    public class BricksDowntimeMDL
    {
        public int DocNum { get; set; }
        public int DocEntry { get; set; }
        public string U_Date { get; set; }
        public string U_Plant { get; set; }
        public string U_DayNight { get; set; }
        public string U_Shift { get; set; }
        public string U_BrickType { get; set; }
        public string U_Operator { get; set; }
        public string U_WeekNumber { get; set; }
        public List<Briicksdtlinescollection> BRIICKSDTLINESCollection { get; set; }
        public List<Bricksdtclltncollection> BRICKSDTCLLTNCollection { get; set; }

        public class Briicksdtlinescollection
        {
            public int DocEntry { get; set; }
            public int LineId { get; set; }
            public string U_Shift { get; set; }
            public string U_DayNight { get; set; }
            public string U_BrickType { get; set; }
            public string U_StartTime { get; set; }
            public string U_EndTime { get; set; }
            public string U_StartDate { get; set; }
            public string U_EndDate { get; set; }
            public string U_Duration { get; set; }
            public string U_Remarks { get; set; }
            public string U_DowntimeType { get; set; }
            public string U_Planned { get; set; }
            public string U_Day { get; set; }
        }

        public class Bricksdtclltncollection
        {
            public int DocEntry { get; set; }
            public int LineId { get; set; }
            public string U_Shift { get; set; }
            public string U_Day { get; set; }
            public string U_AvgRate { get; set; }
            public string U_ExtrusionRate { get; set; }
            public string U_ActualRate { get; set; }
            public string U_Total { get; set; }
            public string U_TotalDownTime { get; set; }
            public string U_HacklineProd { get; set; }
            public string U_ExtrusionProd { get; set; }
            public string U_PlantAvail { get; set; }
            public string U_PlantUtil { get; set; }
        }
    }
    public class PostBricksDowntimeMDL
    {
       
        public string U_Date { get; set; }
        public string U_Plant { get; set; }
        public string U_DayNight { get; set; }
        public string U_Shift { get; set; }
        public string U_BrickType { get; set; }
        public string U_Operator { get; set; }
        public string U_WeekNumber { get; set; }
        public List<Briicksdtlinescollection> BRIICKSDTLINESCollection { get; set; }
        public List<Bricksdtclltncollection> BRICKSDTCLLTNCollection { get; set; }

        public class Briicksdtlinescollection
        {
            public string U_Shift { get; set; }
            public string U_DayNight { get; set; }
            public string U_BrickType { get; set; }
            public string U_StartTime { get; set; }
            public string U_EndTime { get; set; }
            public string U_StartDate { get; set; }
            public string U_EndDate { get; set; }
            public string U_Duration { get; set; }
            public string U_Remarks { get; set; }
            public string U_DowntimeType { get; set; }
            public string U_Planned { get; set; }
            public string U_Day { get; set; }
        }

        public class Bricksdtclltncollection
        {         
            public string U_Shift { get; set; }
            public string U_Day { get; set; }
            public string U_AvgRate { get; set; }
            public string U_ExtrusionRate { get; set; }
            public string U_ActualRate { get; set; }
            public string U_Total { get; set; }
            public string U_TotalDownTime { get; set; }
            public string U_HacklineProd { get; set; }
            public string U_ExtrusionProd { get; set; }
            public string U_PlantAvail { get; set; }
            public string U_PlantUtil { get; set; }
        }
    }
    public class PatchBricksDowntimeMDL
    {
        public int DocNum { get; set; }
        public int DocEntry { get; set; }
        public string U_Date { get; set; }
        public string U_Plant { get; set; }
        public string U_DayNight { get; set; }
        public string U_Shift { get; set; }
        public string U_BrickType { get; set; }
        public string U_Operator { get; set; }
        public string U_WeekNumber { get; set; }
        public List<Briicksdtlinescollection> BRIICKSDTLINESCollection { get; set; }
        public List<Bricksdtclltncollection> BRICKSDTCLLTNCollection { get; set; }

        public class Briicksdtlinescollection
        {
            public int LineId { get; set; }
            public string U_Shift { get; set; }
            public string U_DayNight { get; set; }
            public string U_BrickType { get; set; }
            public string U_StartTime { get; set; }
            public string U_EndTime { get; set; }
            public string U_StartDate { get; set; }
            public string U_EndDate { get; set; }
            public string U_Duration { get; set; }
            public string U_Remarks { get; set; }
            public string U_DowntimeType { get; set; }
            public string U_Planned { get; set; }
            public string U_Day { get; set; }
        }

        public class Bricksdtclltncollection
        {
            public int LineId { get; set; }
            public string U_Shift { get; set; }
            public string U_Day { get; set; }
            public string U_AvgRate { get; set; }
            public string U_ExtrusionRate { get; set; }
            public string U_ActualRate { get; set; }
            public string U_Total { get; set; }
            public string U_TotalDownTime { get; set; }
            public string U_HacklineProd { get; set; }
            public string U_ExtrusionProd { get; set; }
            public string U_PlantAvail { get; set; }
            public string U_PlantUtil { get; set; }
        }
    }
}
