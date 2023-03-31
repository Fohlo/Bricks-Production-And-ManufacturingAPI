using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotechxAPI.Models.SHEQ
{
    public class DryRidgeIFMDL
    {
            public int DocNum { get; set; }
            public int DocEntry { get; set; }
            public string U_Batch { get; set; }
            public int U_Quantity { get; set; }
            public string U_Product { get; set; }
            public string U_Colour { get; set; }
            public string U_Inspection { get; set; }
            public string U_Date { get; set; }
            public List<Drifdcollection> DRIFDCollection { get; set; }
            public List<Drifccollection> DRIFCCollection { get; set; }
            public List<Drifavgcollection> DRIFAVGCollection { get; set; }


        public class Drifdcollection
        {
            public int DocEntry { get; set; }
            public int LineId { get; set; }
            public int U_Sample { get; set; }
            public float U_Length { get; set; }
            public float U_Width { get; set; }
            public float U_ThickNess { get; set; }
            public float U_DRMass { get; set; }
            public string U_Knife { get; set; }
            public string U_ColourD { get; set; }
            public string U_Smooth { get; set; }
            public string U_InspectionNo { get; set; }
            public string U_InspectionTime { get; set; }
            public string U_InspectionType { get; set; }
            public string U_InspectionDate { get; set; }

        }

        public class Drifccollection
        {
            public int DocEntry { get; set; }
            public int LineId { get; set; }
            public string U_Sound { get; set; }
            public string U_Details { get; set; }
        }

        public class Drifavgcollection
        {
            public int LineId { get; set; }
            public float U_AvgLength { get; set; }
            public float U_AvgWidth { get; set; }
            public float U_AvgThickNess { get; set; }
            public float U_AvgDRMass { get; set; }
        }


    }


    public class PostDryRidgeIFMDL
    {
        public string U_Batch { get; set; }
        public int U_Quantity { get; set; }
        public string U_Product { get; set; }
        public string U_Colour { get; set; }
        public string U_Inspection { get; set; }
        public string U_Date { get; set; }
        public List<Drifdcollection> DRIFDCollection { get; set; }
        public List<Drifccollection> DRIFCCollection { get; set; }
        public List<Drifavgcollection> DRIFAVGCollection { get; set; }

        public class Drifdcollection
        {
            public int U_Sample { get; set; }
            public float U_Length { get; set; }
            public float U_Width { get; set; }
            public float U_ThickNess { get; set; }
            public float U_DRMass { get; set; }
            public string U_Knife { get; set; }
            public string U_ColourD { get; set; }
            public string U_Smooth { get; set; }
            public string U_InspectionNo { get; set; }
            public string U_InspectionTime { get; set; }
            public string U_InspectionType { get; set; }
            public string U_InspectionDate { get; set; }
        }

        public class Drifccollection
        {
            public string U_Sound { get; set; }
            public string U_Details { get; set; }
        }
        public class Drifavgcollection
        {
            public int LineId { get; set; }
            public float U_AvgLength { get; set; }
            public float U_AvgWidth { get; set; }
            public float U_AvgThickNess { get; set; }
            public float U_AvgDRMass { get; set; }
        }


    }


}
