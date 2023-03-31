using PhotechxAPI.Models.PlantMaintance;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotechxAPI.BLL.PlantMaintance
{
    public class WorkOrderBLL
    {


        public static WorkOrderMDL get(string session, int Doc)
        {
            try
            {
                try
                {
                    var clause = "WorkOrder(" + Doc + ")";
                    var data = Pipeline.Get(session, clause);
                    return JsonConvert.DeserializeObject<WorkOrderMDL>(data);
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


        public static List<WorkOrderMDL> get(string session, string Query)
        {
            try
            {
                try
                {
                    var Alldata = new List<WorkOrderMDL>();
                    var data = Pipeline.GetMultiple(session, Query);
                    foreach (string infor in data)
                    {
                        Alldata.AddRange(JsonConvert.DeserializeObject<List<WorkOrderMDL>>(infor));
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


        public static string Post(string session, PostWorkOrderMDL data)
        {
            try
            {


                var PostData = JsonConvert.SerializeObject(data, Newtonsoft.Json.Formatting.None,
                            new JsonSerializerSettings
                            {
                                NullValueHandling = NullValueHandling.Ignore
                            });
                var Post = Pipeline.Post(session, PostData, "WorkOrder");
                var Posresult = JsonConvert.DeserializeObject<WorkOrderMDL>(Post);
                return "Work Order Posted " + Posresult.DocNum;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static string Patch(string session, PatchWorkOrderMDL data, int Doc)
        {
            try
            {

                var PostData = JsonConvert.SerializeObject(data, Newtonsoft.Json.Formatting.None,
                            new JsonSerializerSettings
                            {
                                NullValueHandling = NullValueHandling.Ignore
                            });
                var Post = Pipeline.Patch(session, PostData, "WorkOrder(" + Doc + ")");
                return "WorkOrder has been Updated";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


    }
}
