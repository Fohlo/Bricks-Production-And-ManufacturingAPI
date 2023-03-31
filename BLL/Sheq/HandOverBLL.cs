using PhotechxAPI.Models.SHEQ;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotechxAPI.BLL.Sheq
{
    public class HandOverBLL
    {

        public static HandoverMDL get(string session, int Doc)
        {
            try
            {
                try
                {
                    var clause = "HANDOVER(" + Doc + ")";
                    var data = Pipeline.Get(session, clause);
                    return JsonConvert.DeserializeObject<HandoverMDL>(data);
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


        public static List<HandoverMDL> get(string session, string Query)
        {
            try
            {
                try
                {
                    //var clause = "NonCompliance";
                    var Alldata = new List<HandoverMDL>();
                    var data = Pipeline.GetMultiple(session, Query);
                    foreach (string infor in data)
                    {
                        Alldata.AddRange(JsonConvert.DeserializeObject<List<HandoverMDL>>(infor));
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


        public static string Post(string session, PostHandoverMDL data)
        {
            try
            {
                //foreach (PostNonComplianceMDL.Nonccollection line in data.NONCCollection)
                //{
                //    line.U_User = Globals.Globals.AuthSessions[session].EmployeeName;
                //    line.U_UserId = (int)Globals.Globals.AuthSessions[session].EmployeeID;
                //}

                data.U_AddedBy = Globals.Globals.AuthSessions[session].EmployeeName;
                data.U_AddedById = (int)Globals.Globals.AuthSessions[session].EmployeeID;


                var PostData = JsonConvert.SerializeObject(data, Newtonsoft.Json.Formatting.None,
                            new JsonSerializerSettings
                            {
                                NullValueHandling = NullValueHandling.Ignore
                            });
                var Post = Pipeline.Post(session, PostData, "HANDOVER");
                var Posresult = JsonConvert.DeserializeObject<HandoverMDL>(Post);
                return "Hand Over Document Added" + Posresult.DocNum;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static string Patch(string session, PostHandoverMDL data, int Doc)
        {
            try
            {
                //foreach (PatchNonComplianceMDL.Nonccollection line in data.NONCCollection)
                //{
                //    line.U_Ruser = Globals.Globals.AuthSessions[session].EmployeeName;
                //    line.U_RuserID = (int)Globals.Globals.AuthSessions[session].EmployeeID;
                //}

                //foreach (PatchNonComplianceMDL.Rccacollection line in data.RCCACollection)
                //{
                //    line.U_User = Globals.Globals.AuthSessions[session].EmployeeName;
                //    line.U_UserId = (int)Globals.Globals.AuthSessions[session].EmployeeID;
                //}

                //if (data.FOLLOWUPCollection.Count > 0)
                //{
                //    data.Status = "C";
                //}
                var PostData = JsonConvert.SerializeObject(data, Newtonsoft.Json.Formatting.None,
                            new JsonSerializerSettings
                            {
                                NullValueHandling = NullValueHandling.Ignore
                            });
                var Post = Pipeline.Patch(session, PostData, "HANDOVER(" + Doc + ")");
                //var Posresult = JsonConvert.DeserializeObject<NonComplianceMDL>(Post);
                return "Hand Over Form Has Been Updated";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


    }
}
