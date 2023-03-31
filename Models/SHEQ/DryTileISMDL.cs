using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotechxAPI.Models.SHEQ
{
    public class DryTileISMDL
    {
            public int DocNum { get; set; }
            public int DocEntry { get; set; }
            public string U_Date { get; set; }
            public int U_Shift { get; set; }
            public int U_Quantity { get; set; }
            public string U_Profile { get; set; }
            public string U_Colour { get; set; }
            public object U_QuantityS { get; set; }
            public float U_Waste { get; set; }
            public string U_Batch { get; set; }
            public string U_Status { get; set; }
            public List<Dtfivicollection> DTFIVICollection { get; set; }
            public List<Dtfircollection> DTFIRCollection { get; set; }
            public List<Dtfidcollection> DTFIDCollection { get; set; }
            public List<Dtifcmntcollection> DTIFCMNTCollection { get; set; }
            public List<Dtiffavgcollection> DTIFFAVGCollection { get; set; }

        public class Dtfivicollection
        {
            public int DocEntry { get; set; }
            public int LineId { get; set; }
            public string U_Efflorescence { get; set; }
            public string U_Color { get; set; }
            public string U_NIB { get; set; }
        }

        public class Dtfircollection
        {
            public int DocEntry { get; set; }
            public int LineId { get; set; }
            public string U_Dow { get; set; }
            public string U_Dampness { get; set; }
        }


        public class Dtfidcollection
        {
            public int DocEntry { get; set; }
            public int LineId { get; set; }
            public string U_Sample { get; set; }
            public float U_Length { get; set; }
            public float U_Width { get; set; }
            public float U_Body { get; set; }
            public float U_WaterChannel { get; set; }
            public float U_WateCap { get; set; }
            public float U_Nail { get; set; }
            public float U_Nib { get; set; }
            public float U_DryTileMass { get; set; }
            public float U_Reading { get; set; }
            public float U_Transverse { get; set; }
            public float U_Average { get; set; }
            public string U_AddedBy { get; set; }
            public string U_AddedByID { get; set; }
            public string U_LogingType { get; set; }
            public string U_InspectionNo { get; set; }
            public string U_CommentEN { get; set; }
            public string U_Comment { get; set; }
            public string U_InspectionTime { get; set; }
            public string U_InspectionTypee { get; set; }
            public string U_InspectionDate { get; set; }
        }
        public class Dtifcmntcollection
        {
            public string U_CommentssENN { get; set; }
            public string U_Commentss { get; set; }
        }

        public class Dtiffavgcollection
        {
            public int LineId { get; set; }
            public float U_AvgLength { get; set; }
            public float U_AvgWidth { get; set; }
            public float U_AvgBody { get; set; }
            public float U_AvgWaterChannel { get; set; }
            public float U_AvgWateCap { get; set; }
            public float U_AvgNail { get; set; }
            public float U_AvgNib { get; set; }
            public float U_AvgDryTileMass { get; set; }
            public float U_AvgReading { get; set; }
            public float U_AvgTransverse { get; set; }
        }


    }


    public class PostDryTileISMDL
    {
        public string U_Date { get; set; }
        public int U_Shift { get; set; }
        public int U_Quantity { get; set; }
        public string U_Profile { get; set; }
        public string U_Colour { get; set; }
        public int U_QuantityS { get; set; }
        public float U_Waste { get; set; }
        public string U_Batch { get; set; }
        public string U_Status { get; set; }
        public List<Dtfivicollection> DTFIVICollection { get; set; }
        public List<Dtfircollection> DTFIRCollection { get; set; }
        public List<Dtfidcollection> DTFIDCollection { get; set; }
        public List<Dtifcmntcollection> DTIFCMNTCollection { get; set; }
        public List<Dtiffavgcollection> DTIFFAVGCollection { get; set; }

        public class Dtfivicollection
        {
            public string U_Efflorescence { get; set; }
            public string U_Color { get; set; }
            public string U_NIB { get; set; }
        }

        public class Dtfircollection
        {
            public string U_Dow { get; set; }
            public string U_Dampness { get; set; }
        }

        public class Dtfidcollection
        {
            public float U_Length { get; set; }
            public string U_Sample { get; set; }
            public float U_Width { get; set; }
            public float U_Body { get; set; }
            public float U_WaterChannel { get; set; }
            public float U_WateCap { get; set; }
            public float U_Nail { get; set; }
            public float U_Nib { get; set; }
            public float U_DryTileMass { get; set; }
            public float U_Reading { get; set; }
            public float U_Transverse { get; set; }
            public float U_Average { get; set; }
            public string U_AddedBy { get; set; }
            public string U_AddedByID { get; set; }
            public string U_LogingType { get; set; }
            public string U_InspectionNo { get; set; }
            public string U_CommentEN { get; set; }
            public string U_Comment { get; set; }
            public string U_InspectionTime { get; set; }
            public string U_InspectionTypee { get; set; }
            public string U_InspectionDate { get; set; }
        }

        public class Dtifcmntcollection
        {
            public string U_CommentssENN { get; set; }
            public string U_Commentss { get; set; }
        }
        public class Dtiffavgcollection
        {
            public int LineId { get; set; }
            public float U_AvgLength { get; set; }
            public float U_AvgWidth { get; set; }
            public float U_AvgBody { get; set; }
            public float U_AvgWaterChannel { get; set; }
            public float U_AvgWateCap { get; set; }
            public float U_AvgNail { get; set; }
            public float U_AvgNib { get; set; }
            public float U_AvgDryTileMass { get; set; }
            public float U_AvgReading { get; set; }
            public float U_AvgTransverse { get; set; }
        }


    }

    public class PatchDryTileISMDL
    {
        public string U_Date { get; set; }
        public int U_Shift { get; set; }
        public int U_Quantity { get; set; }
        public string U_Profile { get; set; }
        public string U_Colour { get; set; }
        public int U_QuantityS { get; set; }
        public float U_Waste { get; set; }
        public string U_Batch { get; set; }
        public string U_Status { get; set; }
        public List<Dtfivicollection> DTFIVICollection { get; set; }
        public List<Dtfircollection> DTFIRCollection { get; set; }
        public List<Dtfidcollection> DTFIDCollection { get; set; }
        public List<Dtifcmntcollection> DTIFCMNTCollection { get; set; }
        public List<Dtiffavgcollection> DTIFFAVGCollection { get; set; }

        public class Dtfivicollection
        {
            public string U_Efflorescence { get; set; }
            public string U_Color { get; set; }
            public string U_NIB { get; set; }
        }

        public class Dtfircollection
        {
            public string U_Dow { get; set; }
            public string U_Dampness { get; set; }
        }

        public class Dtfidcollection
        {
            public float U_Length { get; set; }
            public string U_Sample { get; set; }
            public float U_Width { get; set; }
            public float U_Body { get; set; }
            public float U_WaterChannel { get; set; }
            public float U_WateCap { get; set; }
            public float U_Nail { get; set; }
            public float U_Nib { get; set; }
            public float U_DryTileMass { get; set; }
            public float U_Reading { get; set; }
            public float U_Transverse { get; set; }
            public float U_Average { get; set; }
            public string U_AddedBy { get; set; }
            public string U_AddedByID { get; set; }
            public string U_LogingType { get; set; }
            public string U_InspectionNo { get; set; }
            public string U_CommentEN { get; set; }
            public string U_Comment { get; set; }
            public string U_InspectionTime { get; set; }
            public string U_InspectionTypee { get; set; }
            public string U_InspectionDate { get; set; }
        }

        public class Dtifcmntcollection
        {
            public string U_CommentssENN { get; set; }
            public string U_Commentss { get; set; }
        }
        public class Dtiffavgcollection
        {
            public int LineId { get; set; }
            public float U_AvgLength { get; set; }
            public float U_AvgWidth { get; set; }
            public float U_AvgBody { get; set; }
            public float U_AvgWaterChannel { get; set; }
            public float U_AvgWateCap { get; set; }
            public float U_AvgNail { get; set; }
            public float U_AvgNib { get; set; }
            public float U_AvgDryTileMass { get; set; }
            public float U_AvgReading { get; set; }
            public float U_AvgTransverse { get; set; }
        }


    }

}
