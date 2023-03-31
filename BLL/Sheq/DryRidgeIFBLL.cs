using PhotechxAPI.Models.SHEQ;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotechxAPI.BLL.Sheq
{
    public class DryRidgeIFBLL
    {

        public static DryRidgeIFMDL get(string session, int Doc)
        {
            try
            {
                try
                {
                    var clause = "DRYRIDGEIF(" + Doc + ")";
                    var data = Pipeline.Get(session, clause);
                    return JsonConvert.DeserializeObject<DryRidgeIFMDL>(data);
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


        public static List<DryRidgeIFMDL> get(string session, string Query)
        {
            try
            {
                try
                {
                    //var clause = "NonCompliance";
                    var Alldata = new List<DryRidgeIFMDL>();
                    var data = Pipeline.GetMultiple(session, Query);
                    foreach (string infor in data)
                    {
                        Alldata.AddRange(JsonConvert.DeserializeObject<List<DryRidgeIFMDL>>(infor));
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


        public static string Post(string session, PostDryRidgeIFMDL data)
        {
            try
            {
                //foreach (PostNonComplianceMDL.Nonccollection line in data.NONCCollection)
                //{
                //    line.U_User = Globals.Globals.AuthSessions[session].EmployeeName;
                //    line.U_UserId = (int)Globals.Globals.AuthSessions[session].EmployeeID;
                //}

                var PostData = JsonConvert.SerializeObject(data, Newtonsoft.Json.Formatting.None,
                            new JsonSerializerSettings
                            {
                                NullValueHandling = NullValueHandling.Ignore
                            });
                var Post = Pipeline.Post(session, PostData, "DRYRIDGEIF");
                var Posresult = JsonConvert.DeserializeObject<DryRidgeIFMDL>(Post);
                return "Dry Ridge Inspection Form Document Added" + Posresult.DocNum;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static string Patch(string session, PostDryRidgeIFMDL data, int Doc)
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
                var Post = Pipeline.Patch(session, PostData, "DRYRIDGEIF(" + Doc + ")");
                //var Posresult = JsonConvert.DeserializeObject<NonComplianceMDL>(Post);
                return "Dry Ridge Inspection Form Has Been Updated";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


    }
}
