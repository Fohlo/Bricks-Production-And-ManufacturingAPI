using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotechxAPI.Models.Production.ProductionBricks
{
    public class ClampHandoverFormMDL
    {
        public int DocNum { get; set; }
        public int DocEntry { get; set; }
        public string U_Date { get; set; }
        public string U_ProductType { get; set; }
        public string U_CombustionDays { get; set; }
        public string U_ClampNo { get; set; }
        public float U_Quantity { get; set; }
        public string U_PlantArea { get; set; }
        public string U_Details { get; set; }
        public string U_AddedBy { get; set; }
        public string U_AddedById { get; set; }
        public string U_ReceivedBy { get; set; }
        public string U_ReceivedByDate { get; set; }
        public string U_CompletedBy { get; set; }
        public string U_CompletedByDate { get; set; }
        public string U_BatchNo { get; set; }
    }

    public class PostClampHandoverFormMDL 
    {
        public string U_Date { get; set; }
        public string U_ProductType { get; set; }
        public string U_CombustionDays { get; set; }
        public string U_ClampNo { get; set; }
        public float U_Quantity { get; set; }
        public string U_PlantArea { get; set; }
        public string U_Details { get; set; }
        public string U_AddedBy { get; set; }
        public string U_AddedById { get; set; }
        public string U_ReceivedBy { get; set; }
        public string U_ReceivedByDate { get; set; }
        public string U_CompletedBy { get; set; }
        public string U_CompletedByDate { get; set; }
        public string U_BatchNo { get; set; }

    }

    public class PatchClampHandoverFormMDL
    {
        public int DocEntry { get; set; }
        public string U_Date { get; set; }
        public string U_ProductType { get; set; }
        public string U_CombustionDays { get; set; }
        public string U_ClampNo { get; set; }
        public float U_Quantity { get; set; }
        public string U_PlantArea { get; set; }
        public string U_Details { get; set; }
        public string U_AddedBy { get; set; }
        public string U_AddedById { get; set; }
        public string U_ReceivedBy { get; set; }
        public string U_ReceivedByDate { get; set; }
        public string U_CompletedBy { get; set; }
        public string U_CompletedByDate { get; set; }
        public string U_BatchNo { get; set; }

    }


}