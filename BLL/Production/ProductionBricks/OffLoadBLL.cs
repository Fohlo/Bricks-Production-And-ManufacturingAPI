using PhotechxAPI.Models.PlantMaintance;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PhotechxAPI.Models.Production.ProductionBricks;

namespace PhotechxAPI.BLL.Production.ProductionBricks
{
    public class OffLoadBLL
    {
      

            public static OffLoadMDL get(string session, int DocEntry)
            {
                try
                {
                    try
                    {
                        var clause = "OFFLOAD(" + DocEntry + ")";
                        var data = Pipeline.Get(session, clause);
                        return JsonConvert.DeserializeObject<OffLoadMDL>(data);
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


            public static List<OffLoadMDL> get(string session, string Query)
            {
                try
                {
                    try
                    {
                        var Alldata = new List<OffLoadMDL>();
                        var data = Pipeline.GetMultiple(session, Query);
                        foreach (string infor in data)
                        {
                            Alldata.AddRange(JsonConvert.DeserializeObject<List<OffLoadMDL>>(infor));
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


            public static string Post(string session, PostOffLoadMDL data)
            {
                try
                {


                    var PostData = JsonConvert.SerializeObject(data, Newtonsoft.Json.Formatting.None,
                                new JsonSerializerSettings
                                {
                                    NullValueHandling = NullValueHandling.Ignore
                                });
                    var Post = Pipeline.Post(session, PostData, "OFFLOAD");
                    var Posresult = JsonConvert.DeserializeObject<OffLoadMDL>(Post);
                    return "OFF LOAD Posted " + Posresult.DocNum;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }

            public static string Patch(string session, PatchOffLoadMDL data, int DocEntry)
            {
                try
                {

                    var PostData = JsonConvert.SerializeObject(data, Newtonsoft.Json.Formatting.None,
                                new JsonSerializerSettings
                                {
                                    NullValueHandling = NullValueHandling.Ignore
                                });
                    var Post = Pipeline.Patch(session, PostData, "OFFLOAD(" + DocEntry + ")");
                    return "OFF LOAD has been Updated";
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }


        }
}

