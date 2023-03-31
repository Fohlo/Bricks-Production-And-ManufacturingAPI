using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotechxAPI.Models.PlantMaintance
{

    public class ChecklistsMDL
    {
        public int DocNum { get; set; }
        public int DocEntry { get; set; }
        public string U_Wkstarting { get; set; }
        public string U_Wkending { get; set; }
        public string U_CheckType { get; set; }
        public string U_Status { get; set; }
        public string U_MachineNo { get; set; }
        public string U_Operator { get; set; }
        public string U_WeekNumber { get; set; }
        public List<Pmsclinescollection> PMSCLINESCollection { get; set; }
        public List<Pmscrowscollection> PMSCROWSCollection { get; set; }

        public class Pmsclinescollection
        {
            public int DocEntry { get; set; }
            public int LineId { get; set; }
            public string U_ItemsTC { get; set; }
            public string U_Sunday { get; set; }
            public string U_Monday { get; set; }
            public string U_Tuesday { get; set; }
            public string U_Wednesday { get; set; }
            public string U_Thurday { get; set; }
            public string U_Frinday { get; set; }
            public string U_Saturday { get; set; }
            public string U_Remarks { get; set; }
            public string U_OverallRM { get; set; }
            public string U_AddedBy { get; set; }
            public string U_AddedByID { get; set; }
            public string U_Signature { get; set; }
        }

        public class Pmscrowscollection
        {
            public int DocEntry { get; set; }
            public int LineId { get; set; }
            public string U_SupRemarks { get; set; }
            public string U_SupSignature { get; set; }
            public string U_SupName { get; set; }
        }


    }

    public class PostChecklistsMDL
    {
        public string U_Wkstarting { get; set; }
        public string U_Wkending { get; set; }
        public string U_CheckType { get; set; }
        public string U_Status { get; set; }
        public string U_MachineNo { get; set; }
        public string U_Operator { get; set; }
        public string U_WeekNumber { get; set; }
        public List<Pmsclinescollection> PMSCLINESCollection { get; set; }
        public List<Pmscrowscollection> PMSCROWSCollection { get; set; }

        public class Pmsclinescollection
        {
            public string U_ItemsTC { get; set; }
            public string U_Sunday { get; set; }
            public string U_Monday { get; set; }
            public string U_Tuesday { get; set; }
            public string U_Wednesday { get; set; }
            public string U_Thurday { get; set; }
            public string U_Frinday { get; set; }
            public string U_Saturday { get; set; }
            public string U_Remarks { get; set; }
            public string U_AddedBy { get; set; }
            public string U_AddedByID { get; set; }
            public string U_Signature { get; set; }
        }

        public class Pmscrowscollection
        {
            public string U_SupRemarks { get; set; }
            public string U_SupSignature { get; set; }
            public string U_SupName { get; set; }
        }


    }

    public class PatchChecklistsMDL
    {
        public string U_Status { get; set; }
        public List<Pmsclinescollection> PMSCLINESCollection { get; set; }
        public List<Pmscrowscollection> PMSCROWSCollection { get; set; }

        public class Pmsclinescollection
        {
            public int LineId { get; set; }
            public string U_Sunday { get; set; }
            public string U_Monday { get; set; }
            public string U_Tuesday { get; set; }
            public string U_Wednesday { get; set; }
            public string U_Thurday { get; set; }
            public string U_Frinday { get; set; }
            public string U_Saturday { get; set; }
            public string U_Remarks { get; set; }
            public string U_OverallRM { get; set; }
            public string U_AddedBy { get; set; }
            public string U_AddedByID { get; set; }
            public string U_Signature { get; set; }
        }

        public class Pmscrowscollection
        {
            public int LineId { get; set; }
            public string U_SupRemarks { get; set; }
            public string U_SupSignature { get; set; }
            public string U_SupName { get; set; }
        }


    }

}



