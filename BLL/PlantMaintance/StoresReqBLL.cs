using PhotechxAPI.Models.PlantMaintance;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotechxAPI.BLL.PlantMaintance
{
    public class StoresReqBLL
    {

        public static StoresReqMDL get(string session, int Doc)
        {
            try
            {
                try
                {
                    var clause = "Storesreq(" + Doc + ")";
                    var data = Pipeline.Get(session, clause);
                    return JsonConvert.DeserializeObject<StoresReqMDL>(data);
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


        public static List<StoresReqMDL> get(string session, string Query)
        {
            try
            {
                try
                {
                    var Alldata = new List<StoresReqMDL>();
                    var data = Pipeline.GetMultiple(session, Query);
                    foreach (string infor in data)
                    {
                        Alldata.AddRange(JsonConvert.DeserializeObject<List<StoresReqMDL>>(infor));
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


        public static string Post(string session, PostStoresReqMDL data)
        {
            try
            {


                var PostData = JsonConvert.SerializeObject(data, Newtonsoft.Json.Formatting.None,
                            new JsonSerializerSettings
                            {
                                NullValueHandling = NullValueHandling.Ignore
                            });
                var Post = Pipeline.Post(session, PostData, "Storesreq");
                var Posresult = JsonConvert.DeserializeObject<StoresReqMDL>(Post);
                return "Stores Request Posted " + Posresult.DocNum;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static string Patch(string session, PatchStoresReqMDL data, int Doc)
        {
            try
            {

                var PostData = JsonConvert.SerializeObject(data, Newtonsoft.Json.Formatting.None,
                            new JsonSerializerSettings
                            {
                                NullValueHandling = NullValueHandling.Ignore
                            });
                var Post = Pipeline.Patch(session, PostData, "Storesreq(" + Doc + ")");
                return "Stores Request has been Updated";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }



    }
}
