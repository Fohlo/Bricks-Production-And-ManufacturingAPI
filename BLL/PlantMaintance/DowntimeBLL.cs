using System;
using System.Collections.Generic;
using PhotechxAPI.Models.PlantMaintance;
using Newtonsoft.Json;

using System.Linq;
using System.Threading.Tasks;

namespace PhotechxAPI.BLL.PlantMaintance
{
    public class DowntimeBLL
    {
        public static DownTimeMDL get(string session, int Doc)
        {
            try
            {
                try
                {
                    var clause = "downtime(" + Doc + ")";
                    var data = Pipeline.Get(session, clause);
                    return JsonConvert.DeserializeObject<DownTimeMDL>(data);
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


        public static List<DownTimeMDL> get(string session, string Query)
        {
            try
            {
                try
                {
                    var Alldata = new List<DownTimeMDL>();
                    var data = Pipeline.GetMultiples(session, Query);
                    foreach (string infor in data)
                    {
                        Alldata.AddRange(JsonConvert.DeserializeObject<List<DownTimeMDL>>(infor));
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

        public static List<DownTimeMDL> gets(string session, string Query)
        {
            try
            {
                try
                {
                    
                    var Alldata = new List<DownTimeMDL>();
                    var data = Pipeline.GetMultiple(session, Query);
                    foreach (string infor in data)
                    {
                        Alldata.AddRange(JsonConvert.DeserializeObject<List<DownTimeMDL>>(infor));
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

        public static string Post(string session, PostDownTimeMDL data)
        {
            try
            {


                var PostData = JsonConvert.SerializeObject(data, Newtonsoft.Json.Formatting.None,
                            new JsonSerializerSettings
                            {
                                NullValueHandling = NullValueHandling.Ignore
                            });
                var Post = Pipeline.Post(session, PostData, "downtime");
                var Posresult = JsonConvert.DeserializeObject<DownTimeMDL>(Post);
                return "Downtime  Posted " + Posresult.DocNum;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static string Patch(string session, PatchDownTimeMDL data, int Doc)
        {
            try
            {

                var PostData = JsonConvert.SerializeObject(data, Newtonsoft.Json.Formatting.None,
                            new JsonSerializerSettings
                            {
                                NullValueHandling = NullValueHandling.Ignore
                            });
                var Post = Pipeline.Patch(session, PostData, "downtime(" + Doc + ")");
                return "Downtime has been Updated";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}