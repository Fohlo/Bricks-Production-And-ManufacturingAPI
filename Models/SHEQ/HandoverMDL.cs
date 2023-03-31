using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotechxAPI.Models.SHEQ
{
    public class HandoverMDL
    {
            public int DocNum { get; set; }
            public int DocEntry { get; set; }
            public string U_Date { get; set; }
            public int U_Quantity { get; set; }
            public string U_Product { get; set; }
            public string U_Lines { get; set; }
            public string U_Moisture { get; set; }
            public int U_DayDry { get; set; }
            public string U_Details { get; set; }
            public string U_AddedBy { get; set; }
            public int U_AddedById { get; set; }
            public string U_ReceivedBy { get; set; }
            public string U_ReceivedByDate { get; set; }
            public string U_CompiledBy { get; set; }
            public string U_CompiledByDate { get; set; }
    }


    public class PostHandoverMDL
    {
        public string U_Date { get; set; }
        public int U_Quantity { get; set; }
        public string U_Product { get; set; }
        public string U_Lines { get; set; }
        public string U_Moisture { get; set; }
        public int U_DayDry { get; set; }
        public string U_Details { get; set; }
        public string U_AddedBy { get; set; }
        public int U_AddedById { get; set; }
        public string U_ReceivedBy { get; set; }
        public string U_ReceivedByDate { get; set; }
        public string U_CompiledBy { get; set; }
        public string U_CompiledByDate { get; set; }
        public int U_ReceivedById { get; set; }

    }
    public class PatchHandoverMDL
    {
        public string U_Date { get; set; }
        public int U_Quantity { get; set; }
        public string U_Product { get; set; }
        public string U_Lines { get; set; }
        public string U_Moisture { get; set; }
        public int U_DayDry { get; set; }
        public string U_Details { get; set; }
        public string U_AddedBy { get; set; }
        public int U_AddedById { get; set; }
        public string U_ReceivedBy { get; set; }
        public string U_ReceivedByDate { get; set; }
        public string U_CompiledBy { get; set; }
        public string U_CompiledByDate { get; set; }
        public int U_ReceivedById { get; set; }

    }

}
