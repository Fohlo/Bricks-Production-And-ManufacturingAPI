using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotechxAPI.Models.Batches
{
    public class BatchNumberMDL
    {
            public int DocEntry { get; set; }
            public string ItemCode { get; set; }
            public string ItemDescription { get; set; }
            public string Status { get; set; }
            public string Batch { get; set; }
            public object BatchAttribute1 { get; set; }
            public object BatchAttribute2 { get; set; }
            public string AdmissionDate { get; set; }
            public string ManufacturingDate { get; set; }
            public string ExpirationDate { get; set; }
            public object Details { get; set; }
            public int SystemNumber { get; set; }
            public object U_IIS_proPrNo { get; set; }
            public object U_IIS_proStepNo { get; set; }
            public object U_IIS_proOrigBatch { get; set; }
            public float U_IIS_proQCV { get; set; }
            public float U_IIS_disNetRec { get; set; }
            public string U_IIS_disHold { get; set; }
            public object U_IIS_disInTime { get; set; }
            public string U_IIS_OwnerCode { get; set; }
            public string U_IIS_PICK_TYPE { get; set; }
    }
}
