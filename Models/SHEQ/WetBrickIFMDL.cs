using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotechxAPI.Models.SHEQ
{
    public class WetBrickIFMDL
    {

        public int DocNum { get; set; }
        public int DocEntry { get; set; }
        public string U_Shift { get; set; }
        public string U_Batch { get; set; }
        public string U_Area { get; set; }
        public string U_Product { get; set; }
        public int U_Quantity { get; set; }
        public int U_Wires { get; set; }
        public string U_Date { get; set; }
        public string U_Plant { get; set; }
        public string U_Status { get; set; }
        public List<Wbifrcollection> WBIFRCollection { get; set; }
        public List<Wbifsacollection> WBIFSACollection { get; set; }
        public List<Wbifccollection> WBIFCCollection { get; set; }
        public List<Claymixcollection> CLAYMIXCollection { get; set; }
        public List<Claycocollection> CLAYCOCollection { get; set; }
        public List<Wbifavgcollection> WBIFAVGCollection { get; set; }


        public class Wbifrcollection
        {
            public int DocEntry { get; set; }
            public int LineId { get; set; }
            public float U_Carbon { get; set; }
            public float U_Width { get; set; }
            public float U_Height { get; set; }
            public string U_Corners { get; set; }
            public float U_Penetrometer { get; set; }
            public float U_Vaccum { get; set; }
            public float U_Extrusion { get; set; }
            public float U_Moisture { get; set; }
            public string U_Sample { get; set; }
            public string U_Warping { get; set; }
            public string U_Addedby { get; set; }
         //   [JsonConverter(typeof(StringEnumConverter))]
          //  public LoginTypes U_LoginType { get; set; }
            public string U_InspectionNo { get; set; }
            public string U_Weightt { get; set; }
            public string U_InspectionTime { get; set; }
            public string U_InspectionType { get; set; }
            public string U_InspectionDate { get; set; }
           // public float U_Length { get; set; }
            public string U_Lengthh { get; set; }
        }

        public class Wbifsacollection
        {
            public int DocEntry { get; set; }
            public int LineId { get; set; }
            public float U_FinalWeight { get; set; }
            public float U_InitialWeight { get; set; }
        }

        public class Wbifccollection
        {
            public int DocEntry { get; set; }
            public int LineId { get; set; }
            public string U_QualityC { get; set; }
            public string U_QualityI { get; set; }
        }

        public class Claymixcollection
        {
            public int DocEntry { get; set; }
            public int LineId { get; set; }
            public float U_Ratio { get; set; }
            public float U_Weight { get; set; }
        }

        public class Claycocollection
        {
            public int DocEntry { get; set; }
            public int LineId { get; set; }
            public float U_Mining { get; set; }
            public float U_Extrusion { get; set; }
            public float U_Coal { get; set; }
        }
        public class Wbifavgcollection
        {
            public int LineId { get; set; }
            public float U_AvgCarbon { get; set; }
            public float U_AvgWidth { get; set; }
            public float U_AvgHeight { get; set; }
            public float U_AvgLength { get; set; }
            public float U_AvgPenetrometer { get; set; }
            public float U_AvgWeightt { get; set; }
            public float U_AvgVaccum { get; set; }
            public float U_AvgExtrusion { get; set; }
            public float U_AvgMoisture { get; set; }
        }


    }


    public class PostWetBrickIFMDL
    {
        public string U_Shift { get; set; }
        public string U_Batch { get; set; }
        public string U_Area { get; set; }
        public string U_Product { get; set; }
        public int U_Quantity { get; set; }
        public int U_Wires { get; set; }
        public string U_Date { get; set; }
        public string U_Plant { get; set; }
        public string U_Status { get; set; }
        public List<Wbifrcollection> WBIFRCollection { get; set; }
        public List<Wbifsacollection> WBIFSACollection { get; set; }
        public List<Wbifccollection> WBIFCCollection { get; set; }
        public List<Claymixcollection> CLAYMIXCollection { get; set; }
        public List<Claycocollection> CLAYCOCollection { get; set; }
        public List<Wbifavgcollection> WBIFAVGCollection { get; set; }


        public class Wbifrcollection
        {

            public float U_Carbon { get; set; }
            public float U_Width { get; set; }
            public float U_Height { get; set; }
            public string U_Corners { get; set; }
            public float U_Penetrometer { get; set; }
            public float U_Vaccum { get; set; }
            public float U_Extrusion { get; set; }
            public float U_Moisture { get; set; }
            public string U_Sample { get; set; }
            public string U_Warping { get; set; }
            public string U_Addedby { get; set; }
            //[JsonConverter(typeof(StringEnumConverter))]
           // public LoginTypes U_LoginType { get; set; }
            public string U_InspectionNo { get; set; }
            public string U_Weightt { get; set; }
            public string U_InspectionTime { get; set; }
            public string U_InspectionType { get; set; }
            public string U_InspectionDate { get; set; }
           // public float U_Length { get; set; }
            public string U_Lengthh { get; set; }
        }

        public class Wbifsacollection
        {
            public float U_FinalWeight { get; set; }
            public float U_InitialWeight { get; set; }
        }

        public class Wbifccollection
        {
            public string U_QualityC { get; set; }
            public string U_QualityI { get; set; }
        }

        public class Claymixcollection
        {
            public float U_Ratio { get; set; }
            public float U_Weight { get; set; }
        }

        public class Claycocollection
        {
            public float U_Mining { get; set; }
            public float U_Extrusion { get; set; }
            public float U_Coal { get; set; }
        }

        public class Wbifavgcollection
        {
            public int LineId { get; set; }
            public float U_AvgCarbon { get; set; }
            public float U_AvgWidth { get; set; }
            public float U_AvgHeight { get; set; }
            public float U_AvgLength { get; set; }
            public float U_AvgPenetrometer { get; set; }
            public float U_AvgWeightt { get; set; }
            public float U_AvgVaccum { get; set; }
            public float U_AvgExtrusion { get; set; }
            public float U_AvgMoisture { get; set; }
        }


    }


    public class PatchWetBrickIFMDL
    {
        public string U_Shift { get; set; }
        public string U_Batch { get; set; }
        public string U_Area { get; set; }
        public string U_Product { get; set; }
        public int U_Quantity { get; set; }
        public int U_Wires { get; set; }
        public string U_Date { get; set; }
        public string U_Plant { get; set; }
        public string U_Status { get; set; }
        public List<Wbifrcollection> WBIFRCollection { get; set; }
        public List<Wbifsacollection> WBIFSACollection { get; set; }
        public List<Wbifccollection> WBIFCCollection { get; set; }
        public List<Claymixcollection> CLAYMIXCollection { get; set; }
        public List<Claycocollection> CLAYCOCollection { get; set; }
        public List<Wbifavgcollection> WBIFAVGCollection { get; set; }


        public class Wbifrcollection
        {

            public float U_Carbon { get; set; }
            public float U_Width { get; set; }
            public float U_Height { get; set; }
            public string U_Corners { get; set; }
            public float U_Penetrometer { get; set; }
            public float U_Vaccum { get; set; }
            public float U_Extrusion { get; set; }
            public float U_Moisture { get; set; }
            public string U_Sample { get; set; }
            public string U_Warping { get; set; }
            public string U_Addedby { get; set; }
           // [JsonConverter(typeof(StringEnumConverter))]
          //  public LoginTypes U_LoginType { get; set; }
            public string U_InspectionNo { get; set; }
            public string U_Weightt { get; set; }
            public string U_InspectionTime { get; set; }
           // public float U_Length { get; set; }          
            public string U_InspectionType { get; set; }
            public string U_InspectionDate { get; set; }
           
            public string U_Lengthh { get; set; }
        }

        public class Wbifsacollection
        {
            public float U_FinalWeight { get; set; }
            public float U_InitialWeight { get; set; }
        }

        public class Wbifccollection
        {
            public string U_QualityC { get; set; }
            public string U_QualityI { get; set; }
        }

        public class Claymixcollection
        {
            public float U_Ratio { get; set; }
            public float U_Weight { get; set; }
        }

        public class Claycocollection
        {
            public float U_Mining { get; set; }
            public float U_Extrusion { get; set; }
            public float U_Coal { get; set; }
        }

        public class Wbifavgcollection
        {
            public int LineId { get; set; }
            public float U_AvgCarbon { get; set; }
            public float U_AvgWidth { get; set; }
            public float U_AvgHeight { get; set; }
            public float U_AvgLength { get; set; }
            public float U_AvgPenetrometer { get; set; }
            public float U_AvgWeightt { get; set; }
            public float U_AvgVaccum { get; set; }
            public float U_AvgExtrusion { get; set; }
            public float U_AvgMoisture { get; set; }
        }


    }









}
