using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static PhotechxAPI.Globals.Globals;

namespace PhotechxAPI.Models.SHEQ
{
    public class NonComplianceMDL
    {

        public int DocNum { get; set; }
        public int DocEntry { get; set; }
        public string U_Dept { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public Status U_Status { get; set; }
        public string U_Date { get; set; }
        public List<Nonccollection> NONCCollection { get; set; }
        public List<Rccacollection> RCCACollection { get; set; }
        public List<Followupcollection> FOLLOWUPCollection { get; set; }


        public class Nonccollection
        {
            public int DocEntry { get; set; }
            public int LineId { get; set; }
            public string U_User { get; set; }
            public int U_UserId { get; set; }
            public string U_Details { get; set; }
        }

        public class Rccacollection
        {
            public int DocEntry { get; set; }
            public int LineId { get; set; }
            public string U_Details { get; set; }
            public int? U_UserId { get; set; }
            public string U_User { get; set; }
            public string U_Date { get; set; }
        }

        public class Followupcollection
        {
            public int DocEntry { get; set; }
            public int LineId { get; set; }
            public string U_Details { get; set; }
            public int? U_UserId { get; set; }
            public string U_Date { get; set; }
            public string U_User { get; set; }
        }


    }

    public class PostNonComplianceMDL
    {
            public string U_Dept { get; set; }
            public string U_Date { get; set; }
            public List<Nonccollection> NONCCollection { get; set; }
        

        public class Nonccollection
        {
            public int? U_UserId { get; set; }
            public string U_User { get; set; }
            public string U_Details { get; set; }
        }

    }

    public class PatchNonComplianceMDL
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public Status U_Status { get; set; }
        public List<Rccacollection> RCCACollection { get; set; }
        public List<Followupcollection> FOLLOWUPCollection { get; set; }


       

        public class Rccacollection
        {
            public int LineId { get; set; }
            public string U_Details { get; set; }
            public int? U_UserId { get; set; }
            public string U_User { get; set; }
            public string U_Date { get; set; }
        }

        public class Followupcollection
        {
            public int LineId { get; set; }
            public string U_Details { get; set; }
            public int? U_UserID { get; set; }
            public string U_User { get; set; }
            public string U_Date { get; set; }
        }

    }


}
