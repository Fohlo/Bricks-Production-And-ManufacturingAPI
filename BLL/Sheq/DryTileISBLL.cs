using PhotechxAPI.Models.SHEQ;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotechxAPI.BLL.Sheq
{
    public class DryTileISBLL
    {
        public static DryTileISMDL get(string session, int Doc)
        {
            try
            {
                try
                {
                    var clause = "DRYTILEIS(" + Doc + ")";
                    var data = Pipeline.Get(session, clause);
                    return JsonConvert.DeserializeObject<DryTileISMDL>(data);
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


        public static List<DryTileISMDL> get(string session, string Query)
        {
            try
            {
                try
                {
                    //var clause = "NonCompliance";
                    var Alldata = new List<DryTileISMDL>();
                    var data = Pipeline.GetMultiple(session, Query);
                    foreach (string infor in data)
                    {
                        Alldata.AddRange(JsonConvert.DeserializeObject<List<DryTileISMDL>>(infor));
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


        public static string Post(string session, PostDryTileISMDL data)
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
                var Post = Pipeline.Post(session, PostData, "DRYTILEIS");
                var Posresult = JsonConvert.DeserializeObject<DryTileISMDL>(Post);
                return "Dry Tile Document Added" + Posresult.DocNum;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static string Patch(string session, PostDryTileISMDL data, int Doc)
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
                var Post = Pipeline.Patch(session, PostData, "DRYTILEIS(" + Doc + ")");
                //var Posresult = JsonConvert.DeserializeObject<NonComplianceMDL>(Post);
                return "Dry Tile Form Has Been Updated";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


    }
}
