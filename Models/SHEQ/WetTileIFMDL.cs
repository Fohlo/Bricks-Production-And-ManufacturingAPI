using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static PhotechxAPI.Globals.Globals;

namespace PhotechxAPI.Models.SHEQ
{
    public class WetTileIFMDL
    {
            public int DocNum { get; set; }
            public int DocEntry { get; set; }
            public string U_Shift { get; set; }
            public int U_Quantity { get; set; }
            public string U_POR { get; set; }
            public string U_Batch { get; set; }
            public string U_Profile { get; set; }
            public string U_Colour { get; set; }
            public string U_ProductType { get; set; }
            public string U_Plant { get; set; }
            public string U_Date { get; set; }
           // [JsonConverter(typeof(StringEnumConverter))]
            public string U_Status { get; set; }
            public List<Wtifdcollection> WTIFDCollection { get; set; }
            public List<Wtifcccollection> WTIFCCCollection { get; set; }
            public List<Wtifcmntcollection> WTIFCMNTCollection { get; set; }
            public List<Wtifavgcollection> WTIFAVGCollection { get; set; }



        public class Wtifdcollection
        {
            public int DocEntry { get; set; }
            public int LineId { get; set; }
            public string U_Time { get; set; }
            public float U_TilePallet { get; set; }
            public float U_CleanPallet { get; set; }
            public float U_TileMass { get; set; }
            public float U_Length { get; set; }
            public float U_Width { get; set; }
            public float U_BTB { get; set; }
            public float U_BTD { get; set; }
            public float U_Water { get; set; }
            public float U_Nail { get; set; }
            public string U_Sample { get; set; }
            public string U_Color { get; set; }
            public string U_Knife { get; set; }
            public string U_Surface { get; set; }
            public string U_WaterChannel { get; set; }
            public string U_AddedBy { get; set; }
            public string U_AddedByID { get; set; }
            public string U_LogingType { get; set; }
            public string U_InspectionNo { get; set; }
            public string U_CommentEN { get; set; }
            public string U_Comment { get; set; }
            public string U_InspectionTime { get; set; }
            public string U_InspectionType { get; set; }
            public string U_InspectionDate { get; set; }

        }

        public class Wtifcccollection
        {
            public int DocEntry { get; set; }
            public int LineId { get; set; }
            public string U_Temp { get; set; }
            public float U_Temperature { get; set; }
        }
        public class Wtifcmntcollection
        {
            public string U_CommentssENN { get; set; }
            public string U_Commentss { get; set; }
        }
        public class Wtifavgcollection
        {
            public int LineId { get; set; }
            public float U_AvgTilePallet { get; set; }
            public float U_AvgCleanPallet { get; set; }
            public float U_AvgTileMass { get; set; }
            public float U_AvgLength { get; set; }
            public float U_AvgWidth { get; set; }
            public float U_AvgBTB { get; set; }
            public float U_AvgBTD { get; set; }
            public float U_AvgWater { get; set; }
            public float U_AvgNail { get; set; }
        }


    }

    public class PostWetTileIFMDL
    {
        public string U_Shift { get; set; }
        public int U_Quantity { get; set; }
        public string U_POR { get; set; }
        public string U_Batch { get; set; }
        public string U_Profile { get; set; }
        public string U_Colour { get; set; }
        public string U_ProductType { get; set; }
        public string U_Plant { get; set; }
        public string U_Date { get; set; }
        public string U_Status { get; set; }
        public List<Wtifdcollection> WTIFDCollection { get; set; }
        public List<Wtifcccollection> WTIFCCCollection { get; set; }
        public List<Wtifcmntcollection> WTIFCMNTCollection { get; set; }
        public List<Wtifavgcollection> WTIFAVGCollection { get; set; }


        public class Wtifdcollection
        {
            public string U_Time { get; set; }
            public float U_TilePallet { get; set; }
            public float U_CleanPallet { get; set; }
            public float U_TileMass { get; set; }
            public float U_Length { get; set; }
            public float U_Width { get; set; }
            public float U_BTB { get; set; }
            public float U_BTD { get; set; }
            public float U_Water { get; set; }
            public float U_Nail { get; set; }
            public string U_Sample { get; set; }
            public string U_Color { get; set; }
            public string U_Knife { get; set; }
            public string U_Surface { get; set; }
            public string U_WaterChannel { get; set; }
            public string U_AddedBy { get; set; }
            public string U_AddedByID { get; set; }
            public string U_LogingType { get; set; }
            public string U_InspectionNo { get; set; }
            public string U_CommentEN { get; set; }
            public string U_Comment { get; set; }
            public string U_InspectionTime { get; set; }
            public string U_InspectionType { get; set; }
            public string U_InspectionDate { get; set; }
        }

        public class Wtifcccollection
        {
            public string U_Temp { get; set; }
            public float U_Temperature { get; set; }
        }

        public class Wtifcmntcollection
        {
            public string U_CommentssENN { get; set; }
            public string U_Commentss { get; set; }
        }
        public class Wtifavgcollection
        {
            public int LineId { get; set; }
            public float U_AvgTilePallet { get; set; }
            public float U_AvgCleanPallet { get; set; }
            public float U_AvgTileMass { get; set; }
            public float U_AvgLength { get; set; }
            public float U_AvgWidth { get; set; }
            public float U_AvgBTB { get; set; }
            public float U_AvgBTD { get; set; }
            public float U_AvgWater { get; set; }
            public float U_AvgNail { get; set; }
        }

    }

    public class PatchWetTileIFMDL
    {
        public string U_Shift { get; set; }
        public int U_Quantity { get; set; }
        public string U_POR { get; set; }
        public string U_Batch { get; set; }
        public string U_Profile { get; set; }
        public string U_Colour { get; set; }
        public string U_ProductType { get; set; }
        public string U_Plant { get; set; }
        public string U_Date { get; set; }
       // [JsonConverter(typeof(StringEnumConverter))]
        public string U_Status { get; set; }
        public List<Wtifdcollection> WTIFDCollection { get; set; }
        public List<Wtifcccollection> WTIFCCCollection { get; set; }
        public List<Wtifcmntcollection> WTIFCMNTCollection { get; set; }
        public List<Wtifavgcollection> WTIFAVGCollection { get; set; }


        public class Wtifdcollection
        {
            public int DocEntry { get; set; }
            public int LineId { get; set; }
            public string U_Time { get; set; }
            public float U_TilePallet { get; set; }
            public float U_CleanPallet { get; set; }
            public float U_TileMass { get; set; }
            public float U_Length { get; set; }
            public float U_Width { get; set; }
            public float U_BTB { get; set; }
            public float U_BTD { get; set; }
            public float U_Water { get; set; }
            public float U_Nail { get; set; }
            public string U_Sample { get; set; }
            public string U_Color { get; set; }
            public string U_Knife { get; set; }
            public string U_Surface { get; set; }
            public string U_WaterChannel { get; set; }
            public string U_AddedBy { get; set; }
            public string U_AddedByID { get; set; }
            public string U_LogingType { get; set; }            
            public string U_CommentEN { get; set; }
            public string U_Comment { get; set; }
            public string U_InspectionNo { get; set; }
            public string U_InspectionTime { get; set; }
            public string U_InspectionType { get; set; }
            public string U_InspectionDate { get; set; }
        }

        public class Wtifcccollection
        {
            public int DocEntry { get; set; }
            public int LineId { get; set; }
            public string U_Temp { get; set; }
            public float U_Temperature { get; set; }
        }
        public class Wtifcmntcollection
        {
            public string U_CommentssENN { get; set; }
            public string U_Commentss { get; set; }
        }

        public class Wtifavgcollection
        {
            public int LineId { get; set; }
            public float U_AvgTilePallet { get; set; }
            public float U_AvgCleanPallet { get; set; }
            public float U_AvgTileMass { get; set; }
            public float U_AvgLength { get; set; }
            public float U_AvgWidth { get; set; }
            public float U_AvgBTB { get; set; }
            public float U_AvgBTD { get; set; }
            public float U_AvgWater { get; set; }
            public float U_AvgNail { get; set; }
        }

    }


}
