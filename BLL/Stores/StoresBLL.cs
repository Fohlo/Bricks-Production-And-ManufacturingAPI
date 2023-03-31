using PhotechxAPI.Models.SHEQ;
using PhotechxAPI.Models.PlantMaintance;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using PhotechxAPI.Models.Stores;

namespace PhotechxAPI.BLL.Stores
{
    public class StoresBLL
    {

        public static StoresMDL get(string session, StoresMDL ItemCode)
        {
            try
            {
                try
                {
                    var clause = "OITM(" + ItemCode + ")";
                    var data = Pipeline.Get(session, clause);
                    return JsonConvert.DeserializeObject<StoresMDL>(data);
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


        public static List<StoresMDL> get(string session, string Query)
        {
            try
            {
                try
                {
                    var Alldata = new List<StoresMDL>();
                    var data = Pipeline.GetMultiple(session, Query);
                    foreach (string infor in data)
                    {
                        Alldata.AddRange(JsonConvert.DeserializeObject<List<StoresMDL>>(infor));
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


        public static string Post(string session, PostStoresMDL data)
        {
            try
            {


                var PostData = JsonConvert.SerializeObject(data, Newtonsoft.Json.Formatting.None,
                            new JsonSerializerSettings
                            {
                                NullValueHandling = NullValueHandling.Ignore
                            });
                var Post = Pipeline.Post(session, PostData, "OITM");
                var Posresult = JsonConvert.DeserializeObject<StoresMDL>(Post);
                return "STORES Posted " + Posresult.DocNum;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static string Patch(string session, PatchStoresMDL data, int Doc)
        {
            try
            {

                var PostData = JsonConvert.SerializeObject(data, Newtonsoft.Json.Formatting.None,
                            new JsonSerializerSettings
                            {
                                NullValueHandling = NullValueHandling.Ignore
                            });
                var Post = Pipeline.Patch(session, PostData, "OITM(" + Doc + ")");
                return "Stores has been Updated";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
