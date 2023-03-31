using PhotechxAPI.Models.SHEQ;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotechxAPI.BLL.Sheq
{
    public class NonComplianceBLL
    {

        public static NonComplianceMDL get(string session, int Doc)
        {
            try
            {
                try
                {
                    var clause = "NonCompliance(" + Doc + ")";
                    var data = Pipeline.Get(session, clause);
                    return JsonConvert.DeserializeObject<NonComplianceMDL>(data);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public static List<NonComplianceMDL> get(string session, string Query)
        {
            try
            {
                try
                {
                    //var clause = "NonCompliance";
                    var Alldata = new List<NonComplianceMDL>();
                    var data = Pipeline.GetMultiple(session, Query);
                    foreach (string infor in data)
                    {
                        Alldata.AddRange(JsonConvert.DeserializeObject<List<NonComplianceMDL>>(infor));
                    }
                    return Alldata;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public static string Post(string session, PostNonComplianceMDL data)
        {
            try
            {
                foreach (PostNonComplianceMDL.Nonccollection line in data.NONCCollection)
                {
                    line.U_User = Globals.Globals.AuthSessions[session].EmployeeName;
                    line.U_UserId = (int)Globals.Globals.AuthSessions[session].EmployeeID;
                }

                data.U_Date = DateTime.Now.ToString("yyyy-MM-dd");
                var PostData = JsonConvert.SerializeObject(data, Newtonsoft.Json.Formatting.None,
                            new JsonSerializerSettings
                            {
                                NullValueHandling = NullValueHandling.Ignore
                            });
                var Post = Pipeline.Post(session, PostData, "NonCompliance");
                var Posresult = JsonConvert.DeserializeObject<NonComplianceMDL>(Post);
                return "Non Compliance Document Added";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static string Patch(string session, PatchNonComplianceMDL data, int Doc)
        {
            try
            {
                if (data.RCCACollection != null)
                {
                    foreach (PatchNonComplianceMDL.Rccacollection line in data.RCCACollection)
                    {
                        line.U_User = Globals.Globals.AuthSessions[session].EmployeeName;
                        line.U_UserId = (int)Globals.Globals.AuthSessions[session].EmployeeID;
                        line.U_Date = DateTime.Now.ToString("yyyy-MM-dd");
                    }
                }
                

                if (data.FOLLOWUPCollection!= null && data.FOLLOWUPCollection.Count > 0)
                {
                    //data.U_Status = Globals.Globals.Status.Closed;
                    foreach (PatchNonComplianceMDL.Followupcollection line in data.FOLLOWUPCollection)
                    {
                        line.U_User = Globals.Globals.AuthSessions[session].EmployeeName;
                        line.U_UserID = (int)Globals.Globals.AuthSessions[session].EmployeeID;
                        line.U_Date = DateTime.Now.ToString("yyyy-MM-dd");
                    }
                }
                else
                {
                    data.U_Status = Globals.Globals.Status.Open;
                }
                var PostData = JsonConvert.SerializeObject(data, Newtonsoft.Json.Formatting.None,
                            new JsonSerializerSettings
                            {
                                NullValueHandling = NullValueHandling.Ignore
                            });
                var Post = Pipeline.Patch(session, PostData, "NonCompliance("+ Doc + ")");
                return "Non Compliance document has been Updated";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
