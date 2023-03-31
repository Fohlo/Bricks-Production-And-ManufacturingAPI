using PhotechxAPI.Models.SHEQ;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotechxAPI.BLL.Sheq
{
    public class WetBrickInspectionBLL
    {

        public static WetBrickIFMDL get(string session, int Doc)
        {
            try
            {
                try
                {
                    var clause = "WBIF(" + Doc + ")";
                    var data = Pipeline.Get(session, clause);
                    return JsonConvert.DeserializeObject<WetBrickIFMDL>(data);
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


        public static List<WetBrickIFMDL> get(string session, string Query)
        {
            try
            {
                try
                {
                    //var clause = "NonCompliance";
                    var Alldata = new List<WetBrickIFMDL>();
                    var data = Pipeline.GetMultiple(session, Query);
                    foreach (string infor in data)
                    {
                        Alldata.AddRange(JsonConvert.DeserializeObject<List<WetBrickIFMDL>>(infor));
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


        public static string Post(string session, PostWetBrickIFMDL data)
        {
            try
            {
               // foreach (PostWetBrickIFMDL.Wbifrcollection line in data.WBIFRCollection)
               // {
               //     line.U_Addedby = Globals.Globals.AuthSessions[session].EmployeeName;
                   // line.U_AddedByID = Globals.Globals.AuthSessions[session].EmployeeID;
               //     line.U_LoginType = Globals.Globals.AuthSessions[session].LoginType;
               // }

                var PostData = JsonConvert.SerializeObject(data, Newtonsoft.Json.Formatting.None,
                            new JsonSerializerSettings
                            {
                                NullValueHandling = NullValueHandling.Ignore
                            });
                var Post = Pipeline.Post(session, PostData, "WBIF");
                var Posresult = JsonConvert.DeserializeObject<WetBrickIFMDL>(Post);
                return "Wet Brick Document Has been created " + Posresult.DocNum;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static string Patch(string session, PatchWetBrickIFMDL data, int Doc)
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
                var Post = Pipeline.Patch(session, PostData, "WBIF(" + Doc+")");
                return "Wet Brick Inspection has been Updated";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
