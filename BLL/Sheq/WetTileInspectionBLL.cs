using PhotechxAPI.Models.SHEQ;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotechxAPI.BLL.Sheq
{
    public class WetTileInspectionBLL
    {

        public static WetTileIFMDL get(string session, int Doc)
        {
            try
            {
                try
                {
                    var clause = "WETTILE(" + Doc + ")";
                    var data = Pipeline.Get(session, clause);
                    return JsonConvert.DeserializeObject<WetTileIFMDL>(data);
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


        public static List<WetTileIFMDL> get(string session, string Query)
        {
            try
            {
                try
                {
                    //var clause = "NonCompliance";
                    var Alldata = new List<WetTileIFMDL>();
                    var data = Pipeline.GetMultiple(session, Query);
                    foreach (string infor in data)
                    {
                        Alldata.AddRange(JsonConvert.DeserializeObject<List<WetTileIFMDL>>(infor));
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


        public static string Post(string session, PostWetTileIFMDL data)
        {
            try
            {
                //foreach (PostWetTileIFMDL. line in data.NONCCollection)
                //{
                //    line.U_User = Globals.Globals.AuthSessions[session].EmployeeName;
                //    line.U_UserId = (int)Globals.Globals.AuthSessions[session].EmployeeID;
                //}
                
                var PostData = JsonConvert.SerializeObject(data, Newtonsoft.Json.Formatting.None,
                            new JsonSerializerSettings
                            {
                                NullValueHandling = NullValueHandling.Ignore
                            });
                var Post = Pipeline.Post(session, PostData, "WETTILE");
                var Posresult = JsonConvert.DeserializeObject<WetTileIFMDL>(Post);
                return "Goods receipt PO " + Posresult.DocNum;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static string Patch(string session, PatchWetTileIFMDL data, int Doc)
        {
            try
            {
               
                var PostData = JsonConvert.SerializeObject(data, Newtonsoft.Json.Formatting.None,
                            new JsonSerializerSettings
                            {
                                NullValueHandling = NullValueHandling.Ignore
                            });
                var Post = Pipeline.Patch(session, PostData, "WETTILE(" + Doc+")");
                return "Wet Tile Inspection has been Updated";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
