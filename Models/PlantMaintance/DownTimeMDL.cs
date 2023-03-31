using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotechxAPI.Models.PlantMaintance
{
    public class DownTimeMDL
    
    {
        public int DocNum { get; set; }
        public int DocEntry { get; set; }
        public string U_MachineNo { get; set; }
        public string U_MachineGrp { get; set; }
        public string U_Status{ get; set; }
        public string U_Date { get; set; }
        public string U_Hours { get; set; }
        public int U_WeekNo { get; set; }
        public List<Downtimecollection> DOWNTIMEROWSCollection { get; set; }
        public List<Downtimesumcollection> DOWNTIMESUMCollection { get; set; }


        public class Downtimecollection
        {

            public int DocEntry { get; set; }
            public int LineId { get; set; }
            public string U_Shift { get; set; }
            public string U_StartTime { get; set; }
            public string U_EndTime { get; set; }
            public string U_StartDate { get; set; }
            public string U_EndDate { get; set; }
            public string U_Duration { get; set; }
            public string U_Remarks { get; set; }
            public string U_Reason { get; set; }
            public string U_Planned { get; set; }
            public string U_Day { get; set; }
        }

        public class Downtimesumcollection
        {
            public int DocEntry { get; set; }
            public int LineId { get; set; }
            public string U_Shift { get; set; }
            public string U_Day { get; set; }
            public string U_PlantAvail { get; set; }
            public string U_PlantUtil { get; set; }
        }
    }

    public class PostDownTimeMDL
    {
       
        public string U_MachineNo { get; set; }
        public string U_MachineGrp { get; set; }
        public string U_Status { get; set; }
        public string U_Date { get; set; }
        public string U_Hours { get; set; }
        public int U_WeekNo { get; set; }
        public List<Downtimecollection> DOWNTIMEROWSCollection { get; set; }
        public List<Downtimesumcollection> DOWNTIMESUMCollection { get; set; }


        public class Downtimecollection
        {

           
           
            public string U_Shift { get; set; }
            public string U_StartTime { get; set; }
            public string U_EndTime { get; set; }
            public string U_StartDate { get; set; }
            public string U_EndDate { get; set; }
            public string U_Duration { get; set; }
            public string U_Remarks { get; set; }
            public string U_Reason { get; set; }
            public string U_Planned { get; set; }
            public string U_Day { get; set; }
        }
        public class Downtimesumcollection
        {
          
           
            public string U_Shift { get; set; }
            public string U_Day { get; set; }
            public string U_PlantAvail { get; set; }
            public string U_PlantUtil { get; set; }
        }


    }

    public class PatchDownTimeMDL
    {
        public int DocNum { get; set; }
        public int DocEntry { get; set; }
        public string U_MachineNo { get; set; }
        public string U_MachineGrp { get; set; }
        public string U_Status { get; set; }
        public string U_Date { get; set; }
        public string U_Hours { get; set; }
        public int U_WeekNo { get; set; }
        public List<Downtimecollection> DOWNTIMEROWSCollection { get; set; }
        public List<Downtimesumcollection> DOWNTIMESUMCollection { get; set; }


        public class Downtimecollection
        {
            public int LineId { get; set; }
            public string U_Shift { get; set; }
            public string U_StartTime { get; set; }
            public string U_EndTime { get; set; }
            public string U_StartDate { get; set; }
            public string U_EndDate { get; set; }
            public string U_Duration { get; set; }
            public string U_Remarks { get; set; }
            public string U_Reason { get; set; }
            public string U_Planned { get; set; }
            public string U_Day { get; set; }
        }
        public class Downtimesumcollection
        {
            public int LineId { get; set; }
            public string U_Shift { get; set; }
            public string U_Day { get; set; }
            public string U_PlantAvail { get; set; }
            public string U_PlantUtil { get; set; }
        }

    }
}
