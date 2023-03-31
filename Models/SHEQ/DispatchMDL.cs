using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotechxAPI.Models.SHEQ
{
    public class DispatchMDL
    {
            public int DocNum { get; set; }
            public int DocEntry { get; set; }
            public string U_Date { get; set; }
            public int U_Quantity { get; set; }
            public string U_Batch { get; set; }
            public string U_Product { get; set; }
            public string U_Colour { get; set; }
            public string U_AddedBy { get; set; }
            public string U_AddedByDate { get; set; }
            public int U_AddedByID { get; set; }
            public string U_Approved { get; set; }
            public string U_ApprovedBy { get; set; }
            public string U_ApprovedByDate { get; set; }
            public int U_ApprovedByID { get; set; }
            public string U_Status { get; set; }
            public string U_ProductType { get; set; }
            public string U_ReceivedBy { get; set; }
            public string U_ReceivedByDate { get; set; }
        public List<Despatchlinescollection> DESPATCHLINESCollection { get; set; }
        

        public class Despatchlinescollection
        {
            public int DocEntry { get; set; }
            public int LineId { get; set; }
            public string U_Description { get; set; }
            public string U_Adescription { get; set; }
            public string U_Time { get; set; }
            public string U_Atime { get; set; }
        }


    }


    public class PostDispatchMDL
    {
        public string U_Date { get; set; }
        public int U_Quantity { get; set; }
        public string U_Batch { get; set; }
        public string U_Product { get; set; }
        public string U_Colour { get; set; }
        public string U_AddedBy { get; set; }
        public string U_AddedByDate { get; set; }
        public int U_AddedByID { get; set; }
        public string U_Approved { get; set; }
        public string U_ApprovedBy { get; set; }
        public string U_ApprovedByDate { get; set; }
        public int U_ApprovedByID { get; set; }
        public string U_Status { get; set; }
        public string U_ProductType { get; set; }
        public string U_ReceivedBy { get; set; }
        public string U_ReceivedByDate { get; set; } 
        public List<Despatchlinescollection> DESPATCHLINESCollection { get; set; }


        public class Despatchlinescollection
        {
            public int LineId { get; set; }
            public string U_Description { get; set; }
            public string U_Adescription { get; set; }
            public string U_Time { get; set; }
            public string U_Atime { get; set; }
        }


    }

    public class PatchDispatchMDL
    {
        public string U_Date { get; set; }
        public int U_Quantity { get; set; }
        public string U_Batch { get; set; }
        public string U_Product { get; set; }
        public string U_Colour { get; set; }
        public string U_AddedBy { get; set; }
        public string U_AddedByDate { get; set; }
        public int U_AddedByID { get; set; }
        public string U_Approved { get; set; }
        public string U_ApprovedBy { get; set; }
        public string U_ApprovedByDate { get; set; }
        public int U_ApprovedByID { get; set; }
        public string U_Status { get; set; }
        public string U_ProductType { get; set; }
        public string U_ReceivedBy { get; set; }
        public string U_ReceivedByDate { get; set; }
        public List<Despatchlinescollection> DESPATCHLINESCollection { get; set; }


        public class Despatchlinescollection
        {
            public int LineId { get; set; }
            public string U_Description { get; set; }
            public string U_Adescription { get; set; }
            public string U_Time { get; set; }
            public string U_Atime { get; set; }
        }


    }
}
