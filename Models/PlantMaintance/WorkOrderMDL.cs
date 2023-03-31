using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotechxAPI.Models.PlantMaintance
{
    public class WorkOrderMDL
    {
            public int DocNum { get; set; }
            public int DocEntry { get; set; }
            public string U_Machine { get; set; }
            public string U_Type { get; set; }
            public string U_Requestor { get; set; }
            public string U_DateCompleted { get; set; }
            public string U_DateReceived { get; set; }
            public string U_Task { get; set; }
            public string U_Artisan { get; set; }
            public string U_Plant { get; set; }
            public string U_Status { get; set; }
            public string U_FromChecklist { get; set; }
            public string U_ChecklistDocNum { get; set; }
            public List<Woddcollection> WODDCollection { get; set; }
            public List<Womcollection> WOMCollection { get; set; }
            public List<Wodjacollection> WODJACollection { get; set; }


        public class Woddcollection
        {
            public int DocEntry { get; set; }
            public int LineId { get; set; }
            public string U_Checklist { get; set; }
            public string U_Status { get; set; }
            public string U_Comment { get; set; }
        }

        public class Womcollection
        {
            public int DocEntry { get; set; }
            public int LineId { get; set; }
            public string U_Item { get; set; }
            public string U_Description { get; set; }
            public int U_Quantity { get; set; }
        }
        public class Wodjacollection
        {
            public int DocEntry { get; set; }
            public int LineId { get; set; }
            public string U_Artisan { get; set; }
            public string U_Time { get; set; }
            public string U_Date { get; set; }
            public string U_JobInstruction { get; set; }
            public string U_JobCommencedDate { get; set; }
            public string U_JobCompletedDate { get; set; }
            public string U_JobCommencedTime { get; set; }
            public string U_JobCompletedTime { get; set; }
            public string U_Summary { get; set; }
            public float U_HoursTaken { get; set; }
        }

    }


    public class PostWorkOrderMDL
    {
        public string U_Machine { get; set; }
        public string U_Type { get; set; }
        public string U_Requestor { get; set; }
        public string U_DateCompleted { get; set; }
        public string U_DateReceived { get; set; }
        public string U_Task { get; set; }
        public string U_Artisan { get; set; }
        public string U_Plant { get; set; }
        public string U_Status { get; set; }
        public string U_FromChecklist { get; set; }
        public string U_ChecklistDocNum { get; set; }
        public List<Woddcollection> WODDCollection { get; set; }
        public List<Womcollection> WOMCollection { get; set; }
        public List<Wodjacollection> WODJACollection { get; set; }


        public class Woddcollection
        {
           
            public int LineId { get; set; }
            public string U_Checklist { get; set; }
            public string U_Status { get; set; }
            public string U_Comment { get; set; }
        }

        public class Womcollection
        {
           
            public int LineId { get; set; }
            public string U_Item { get; set; }
            public string U_Description { get; set; }
            public int U_Quantity { get; set; }
        }
        public class Wodjacollection
        {
           
            public int LineId { get; set; }
            public string U_Artisan { get; set; }
            public string U_Time { get; set; }
            public string U_Date { get; set; }
            public string U_JobInstruction { get; set; }
            public string U_JobCommencedDate { get; set; }
            public string U_JobCompletedDate { get; set; }
            public string U_JobCommencedTime { get; set; }
            public string U_JobCompletedTime { get; set; }
            public string U_Summary { get; set; }
            public float U_HoursTaken { get; set; }
        }

    }

    public class PatchWorkOrderMDL
    {
        public int DocNum { get; set; }
        public int DocEntry { get; set; }
        public string U_Machine { get; set; }
        public string U_Type { get; set; }
        public string U_Requestor { get; set; }
        public string U_DateCompleted { get; set; }
        public string U_DateReceived { get; set; }
        public string U_Task { get; set; }
        public string U_Artisan { get; set; }
        public string U_Plant { get; set; }
        public string U_Status { get; set; }
        public string U_FromChecklist { get; set; }
        public string U_ChecklistDocNum { get; set; }
        public List<Woddcollection> WODDCollection { get; set; }
        public List<Womcollection> WOMCollection { get; set; }
        public List<Wodjacollection> WODJACollection { get; set; }


        public class Woddcollection
        {
           
            public string U_Checklist { get; set; }
            public string U_Status { get; set; }
            public string U_Comment { get; set; }
        }

        public class Womcollection
        {
           
            public string U_Item { get; set; }
            public string U_Description { get; set; }
            public int U_Quantity { get; set; }
        }
        public class Wodjacollection
        {
           
            public string U_Artisan { get; set; }
            public string U_Time { get; set; }
            public string U_Date { get; set; }
            public string U_JobInstruction { get; set; }
            public string U_JobCommencedDate { get; set; }
            public string U_JobCompletedDate { get; set; }
            public string U_JobCommencedTime { get; set; }
            public string U_JobCompletedTime { get; set; }
            public string U_Summary { get; set; }
            public float U_HoursTaken { get; set; }
        }

    }


}
