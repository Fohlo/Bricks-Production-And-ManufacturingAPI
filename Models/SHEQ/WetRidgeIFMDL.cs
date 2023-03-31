using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotechxAPI.Models.SHEQ
{
    public class WetRidgeIFMDL
    {
        public int DocNum { get; set; }
        public int DocEntry { get; set; }
        public string U_Date { get; set; }
        public string U_Shift { get; set; }
        public int U_Quantity { get; set; }
        public string U_Inspector { get; set; }
        public string U_Product { get; set; }
        public string U_Batch { get; set; }
        public string U_Color { get; set; }
        public string U_ProductType { get; set; }
        public List<Wrifdcollection> WRIFDCollection { get; set; }
        public List<Wrifabccollection> WRIFABCCollection { get; set; }
        public List<Wrifavgcollection> WRIFAVGCollection { get; set; }


        public class Wrifdcollection
        {
            public int DocEntry { get; set; }
            public int LineId { get; set; }
            public string U_Sample { get; set; }
            public string U_SampleType { get; set; }
            public float U_TilepalletA { get; set; }
            public float U_TilePalletB { get; set; }
            public float U_Tilemass { get; set; }
            public float U_Ridge { get; set; }
            public string U_Eridge { get; set; }
            public string U_Surface { get; set; }
            public string U_ColorDefects { get; set; }
            public float U_Body { get; set; }
            public string U_InspectionNo { get; set; }
            public string U_InspectionTime { get; set; }
            public string U_InspectionType { get; set; }
            public string U_InspectionDate { get; set; }

        }

        public class Wrifabccollection
        {
            public int DocEntry { get; set; }
            public int LineId { get; set; }
            public string U_A { get; set; }
            public string U_B { get; set; }
            public string U_C { get; set; }
        }

        public class Wrifavgcollection
        {
            public int LineId { get; set; }
            public float U_AvgCarbon { get; set; }
            public float U_AvgWidth { get; set; }
            public float U_AvgHeight { get; set; }
            public float U_AvgLength { get; set; }
            public float U_AvgPenetrometer { get; set; }
            public string U_AvgWeightt { get; set; }
            public float U_AvgVaccum { get; set; }
            public float U_AvgExtrusion { get; set; }
            public float U_AvgMoisture { get; set; }
            public float U_TilepalletA { get; set; }
            public float U_TilePalletB { get; set; }
            public float U_Tilemass { get; set; }
            public float U_Body { get; set; }
            public float U_Ridge { get; set; }
        }



    }


    public class PostWetRidgeIFMDL
    {
        public string U_Date { get; set; }
        public string U_Product { get; set; }
        public string U_Batch { get; set; }
        public string U_Shift { get; set; }
        public int U_Quantity { get; set; }
        public string U_Inspector { get; set; }
        public string U_Color { get; set; }
        public string U_ProductType { get; set; }
        public List<Wrifdcollection> WRIFDCollection { get; set; }
        public List<Wrifabccollection> WRIFABCCollection { get; set; }
        public List<Wrifavgcollection> WRIFAVGCollection { get; set; }


        public class Wrifdcollection
        {
            public string U_Sample { get; set; }
            public string U_SampleType { get; set; }
            public float U_TilepalletA { get; set; }
            public float U_TilePalletB { get; set; }
            public float U_Tilemass { get; set; }
            public float U_Ridge { get; set; }
            public string U_Eridge { get; set; }
            public string U_Surface { get; set; }
            public string U_ColorDefects { get; set; }
            public float U_Body { get; set; }
            public string U_InspectionNo { get; set; }
            public string U_InspectionTime { get; set; }
            public string U_InspectionType { get; set; }
            public string U_InspectionDate { get; set; }

        }

        public class Wrifabccollection
        {
            public string U_A { get; set; }
            public string U_B { get; set; }
            public string U_C { get; set; }
        }
        public class Wrifavgcollection
        {
            public int LineId { get; set; }
            public float U_AvgCarbon { get; set; }
            public float U_AvgWidth { get; set; }
            public float U_AvgHeight { get; set; }
            public float U_AvgLength { get; set; }
            public float U_AvgPenetrometer { get; set; }
            public string U_AvgWeightt { get; set; }
            public float U_AvgVaccum { get; set; }
            public float U_AvgExtrusion { get; set; }
            public float U_AvgMoisture { get; set; }
            public float U_TilepalletA { get; set; }
            public float U_TilePalletB { get; set; }
            public float U_Tilemass { get; set; }
            public float U_Body { get; set; }
            public float U_Ridge { get; set; }
        }

    }

    public class PatchWetRidgeIFMDL
    {
        public string U_Date { get; set; }
        public string U_Product { get; set; }
        public string U_Batch { get; set; }
        public string U_Shift { get; set; }
        public int U_Quantity { get; set; }
        public string U_Inspector { get; set; }
        public string U_Color { get; set; }
        public string U_ProductType { get; set; }
        public List<Wrifdcollection> WRIFDCollection { get; set; }
        public List<Wrifabccollection> WRIFABCCollection { get; set; }
        public List<Wrifavgcollection> WRIFAVGCollection { get; set; }


        public class Wrifdcollection
        {
            public string U_Sample { get; set; }
            public string U_SampleType { get; set; }
            public float U_TilepalletA { get; set; }
            public float U_TilePalletB { get; set; }
            public float U_Tilemass { get; set; }
            public float U_Ridge { get; set; }
            public string U_Eridge { get; set; }
            public string U_Surface { get; set; }
            public string U_ColorDefects { get; set; }
            public float U_Body { get; set; }
            public string U_InspectionNo { get; set; }
            public string U_InspectionTime { get; set; }
            public string U_InspectionType { get; set; }
            public string U_InspectionDate { get; set; }

        }

        public class Wrifabccollection
        {
            public string U_A { get; set; }
            public string U_B { get; set; }
            public string U_C { get; set; }
        }

        public class Wrifavgcollection
        {
            public int LineId { get; set; }
            public float U_AvgCarbon { get; set; }
            public float U_AvgWidth { get; set; }
            public float U_AvgHeight { get; set; }
            public float U_AvgLength { get; set; }
            public float U_AvgPenetrometer { get; set; }
            public string U_AvgWeightt { get; set; }
            public float U_AvgVaccum { get; set; }
            public float U_AvgExtrusion { get; set; }
            public float U_AvgMoisture { get; set; }
            public float U_TilepalletA { get; set; }
            public float U_TilePalletB { get; set; }
            public float U_Tilemass { get; set; }
            public float U_Body { get; set; }
            public float U_Ridge { get; set; }
        }


    }


}
