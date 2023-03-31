using System;
using System.Collections.Generic;
using PhotechxAPI.Models.PlantMaintance;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotechxAPI.BLL.PlantMaintance
{
    public class BricksdowntimeBLL
    {

        public static BricksDowntimeMDL get(string session, int Doc)
        {
            try
            {
                try
                {
                    var clause = "bricksdt(" + Doc + ")";
                    var data = Pipeline.Get(session, clause);
                    return JsonConvert.DeserializeObject<BricksDowntimeMDL>(data);
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


        public static List<BricksDowntimeMDL> get(string session, string Query)
        {
            try
            {
                try
                {
                    var Alldata = new List<BricksDowntimeMDL>();
                    var data = Pipeline.GetMultiple(session, Query);
                    foreach (string infor in data)
                    {
                        Alldata.AddRange(JsonConvert.DeserializeObject<List<BricksDowntimeMDL>>(infor));
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


        public static string Post(string session, PostBricksDowntimeMDL data)
        {
            try
            {


                var PostData = JsonConvert.SerializeObject(data, Newtonsoft.Json.Formatting.None,
                            new JsonSerializerSettings
                            {
                                NullValueHandling = NullValueHandling.Ignore
                            });
                var Post = Pipeline.Post(session, PostData, "bricksdt");
                var Posresult = JsonConvert.DeserializeObject<BricksDowntimeMDL>(Post);
                return "Bricks Downtime Posted ";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static List<BricksDowntimeMDL> gets(string session, string Query)
        {
            try
            {
                try
                {

                    var Alldata = new List<BricksDowntimeMDL>();
                    var data = Pipeline.GetMultiple(session, Query);
                    foreach (string infor in data)
                    {
                        Alldata.AddRange(JsonConvert.DeserializeObject<List<BricksDowntimeMDL>>(infor));
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
        public static string Patch(string session, PatchBricksDowntimeMDL data, int Doc)
        {
            try
            {

                var PostData = JsonConvert.SerializeObject(data, Newtonsoft.Json.Formatting.None,
                            new JsonSerializerSettings
                            {
                                NullValueHandling = NullValueHandling.Ignore
                            });
                var Post = Pipeline.Patch(session, PostData, "bricksdt(" + Doc + ")");
                return "Downtime has been Updated";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


    }
}
