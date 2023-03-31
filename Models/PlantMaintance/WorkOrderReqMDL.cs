using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotechxAPI.Models.PlantMaintance
{
    public class WorkOrderReqMDL
    {
            public int DocNum { get; set; }
            public string Remark { get; set; }
            public int DocEntry { get; set; }
            public string U_Type { get; set; }
            public string U_Request { get; set; }
            public int U_RequestID { get; set; }
            public string U_ApprovedBy { get; set; }
            public int U_ApprovedByID { get; set; }
            public string U_Status { get; set; }
            public string U_Details { get; set; }
    }

    public class PostWorkOrderReqMDL
    {
        public string Remark { get; set; }
        public string U_Type { get; set; }
        public string U_Request { get; set; }
        public int U_RequestID { get; set; }
        public string U_ApprovedBy { get; set; }
        public int U_ApprovedByID { get; set; }
        public string U_Status { get; set; }
        public string U_Details { get; set; }
    }

    public class PatchWorkOrderReqMDL
    {
        public string Remark { get; set; }
        public string U_Type { get; set; }
        public string U_Request { get; set; }
        public int U_RequestID { get; set; }
        public string U_ApprovedBy { get; set; }
        public int U_ApprovedByID { get; set; }
        public string U_Status { get; set; }
        public string U_Details { get; set; }
    }

}
