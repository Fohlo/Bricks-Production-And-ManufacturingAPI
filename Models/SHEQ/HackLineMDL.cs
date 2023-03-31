using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotechxAPI.Models.SHEQ
{
    public class HackLineMDL
    {
            public int DocNum { get; set; }
            public int DocEntry { get; set; }
            public string U_Area { get; set; }
            public string U_Plant { get; set; }
            public int U_Quantity { get; set; }
            public string U_Extrusion { get; set; }
            public string U_Product { get; set; }
            public int U_Lines { get; set; }
            public float U_Carbon { get; set; }
            public string U_Date { get; set; }
            public string U_Batch { get; set; }
            public string U_Status { get; set; }
            public string U_ProductType { get; set; }
            public List<Hisdcollection> HISDCollection { get; set; }
            public List<Hacklinedrycollection> HACKLINEDRYCollection { get; set; }


        public class Hisdcollection
        {
            public int DocEntry { get; set; }
            public int LineId { get; set; }
            public string U_Date { get; set; }
            public int U_Sample { get; set; }
            public float U_Length { get; set; }
            public float U_Width { get; set; }
            public float U_Height { get; set; }
            public float U_Weight { get; set; }
            public float U_SampleAvg { get; set; }
            public float U_SampleMst { get; set; }
            public float U_DryRate { get; set; }
            public string U_Inspector { get; set; }
            public string U_Comment { get; set; }
            public string U_AddedBy { get; set; }
            public string U_AddedByID { get; set; }
            public string U_LogingType { get; set; }
            public string U_InspectionNo { get; set; }
            public string U_CommentEN { get; set; }
        }

        public class Hacklinedrycollection
        {
            public string U_RateDate { get; set; }
            public float U_RateExtrusion { get; set; }
            public float U_RateActual { get; set; }
            public float U_RateDryRate { get; set; }
            public float U_RateDays { get; set; }
        }
    }


    public class PostHackLineMDL
    {
        public string U_Area { get; set; }
        public string U_Plant { get; set; }
        public int U_Quantity { get; set; }
        public string U_Extrusion { get; set; }
        public string U_Product { get; set; }
        public int U_Lines { get; set; }
        public float U_Carbon { get; set; }
        public string U_Date { get; set; }
        public string U_Batch { get; set; }
        public string U_ProductType { get; set; }
        public string U_Status { get; set; }
        public List<Hisdcollection> HISDCollection { get; set; }
        public List<Hacklinedrycollection> HACKLINEDRYCollection { get; set; }

        public class Hisdcollection
        {
            public string U_Date { get; set; }
            public int U_Sample { get; set; }
            public float U_Length { get; set; }
            public float U_Width { get; set; }
            public float U_Height { get; set; }
            public float U_Weight { get; set; }
            public float U_SampleAvg { get; set; }
            public float U_SampleMst { get; set; }
            public float U_DryRate { get; set; }
            public string U_Inspector { get; set; }
            public string U_Comment { get; set; }
            public string U_AddedBy { get; set; }
            public string U_AddedByID { get; set; }
            public string U_LogingType { get; set; }
            public string U_InspectionNo { get; set; }
            public string U_CommentEN { get; set; }
        }
        public class Hacklinedrycollection
        {
            public string U_RateDate { get; set; }
            public float U_RateExtrusion { get; set; }
            public float U_RateActual { get; set; }
            public float U_RateDryRate { get; set; }
            public float U_RateDays { get; set; }
        }

    }


    public class PatchHackLineMDL
    {
        public string U_Area { get; set; }
        public string U_Plant { get; set; }
        public int U_Quantity { get; set; }
        public string U_Extrusion { get; set; }
        public string U_Product { get; set; }
        public int U_Lines { get; set; }
        public float U_Carbon { get; set; }
        public string U_Date { get; set; }
        public string U_Batch { get; set; }
        public string U_ProductType { get; set; }
        public string U_Status { get; set; }
        public List<Hisdcollection> HISDCollection { get; set; }
        public List<Hacklinedrycollection> HACKLINEDRYCollection { get; set; }

        public class Hisdcollection
        {
            public string U_Date { get; set; }
            public int U_Sample { get; set; }
            public float U_Length { get; set; }
            public float U_Width { get; set; }
            public float U_Height { get; set; }
            public float U_Weight { get; set; }
            public float U_SampleAvg { get; set; }
            public float U_SampleMst { get; set; }
            public float U_DryRate { get; set; }
            public string U_Inspector { get; set; }
            public string U_Comment { get; set; }
            public string U_AddedBy { get; set; }
            public string U_AddedByID { get; set; }
            public string U_LogingType { get; set; }
            public string U_InspectionNo { get; set; }
            public string U_CommentEN { get; set; }
        }
        public class Hacklinedrycollection
        {
            public string U_RateDate { get; set; }
            public float U_RateExtrusion { get; set; }
            public float U_RateActual { get; set; }
            public float U_RateDryRate { get; set; }
            public float U_RateDays { get; set; }
        }

    }
}
