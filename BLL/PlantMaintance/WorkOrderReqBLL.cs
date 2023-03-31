using PhotechxAPI.Models.PlantMaintance;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotechxAPI.BLL.PlantMaintance
{
    public class WorkOrderReqBLL
    {
        public static WorkOrderReqMDL get(string session, int Doc)
        {
            try
            {
                try
                {
                    var clause = "WorkOrderReq(" + Doc + ")";
                    var data = Pipeline.Get(session, clause);
                    return JsonConvert.DeserializeObject<WorkOrderReqMDL>(data);
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


        public static List<WorkOrderReqMDL> get(string session, string Query)
        {
            try
            {
                try
                {
                    var Alldata = new List<WorkOrderReqMDL>();
                    var data = Pipeline.GetMultiple(session, Query);
                    foreach (string infor in data)
                    {
                        Alldata.AddRange(JsonConvert.DeserializeObject<List<WorkOrderReqMDL>>(infor));
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


        public static string Post(string session, PostWorkOrderReqMDL data)
        {
            try
            {


                var PostData = JsonConvert.SerializeObject(data, Newtonsoft.Json.Formatting.None,
                            new JsonSerializerSettings
                            {
                                NullValueHandling = NullValueHandling.Ignore
                            });
                var Post = Pipeline.Post(session, PostData, "WorkOrderReq");
                var Posresult = JsonConvert.DeserializeObject<WorkOrderReqMDL>(Post);
                return "Work Order Request Posted " + Posresult.DocNum;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static string Patch(string session, PatchWorkOrderReqMDL data, int Doc)
        {
            try
            {

                var PostData = JsonConvert.SerializeObject(data, Newtonsoft.Json.Formatting.None,
                            new JsonSerializerSettings
                            {
                                NullValueHandling = NullValueHandling.Ignore
                            });
                var Post = Pipeline.Patch(session, PostData, "WorkOrderReq(" + Doc + ")");
                return "WorkOrder Request has been Updated";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


    }
}
