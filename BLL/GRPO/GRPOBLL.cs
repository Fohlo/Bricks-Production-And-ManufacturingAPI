using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PhotechxAPI.BLL.Session;
using PhotechxAPI.Models.PurchaseOrder;
using PhotechxAPI.VC;

namespace PhotechxAPI.BLL.GRPO
{
    public class GRPOBLL
    {

        public static PODNMDL getOpen(string session, int Doc)
        {
            try
            {
                var clause = "PurchaseDeliveryNotes?$filter = DocNum eq " + Doc;
                var Alldata = new List<PODNMDL>();
                var data = Pipeline.Get(session, clause);
                var values = ClassVC.B1JsonListToApiJson3(data).ListValues;
                var settings = new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore,
                    MissingMemberHandling = MissingMemberHandling.Ignore
                };
                return JsonConvert.DeserializeObject<List<PODNMDL>>(values, settings)[0];

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static PODNMDL getOpenByDocEntry(string session, int DocEntry)
        {
            try
            {
                var clause = "PurchaseDeliveryNotes(" + DocEntry + ")";
                var Alldata = new List<PODNMDL>();
                var data = Pipeline.Get(session, clause);
                var settings = new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore,
                    MissingMemberHandling = MissingMemberHandling.Ignore
                };
                return JsonConvert.DeserializeObject<PODNMDL>(data,settings);
                //return JsonConvert.DeserializeObject<List<POMDL>>(ClassVC.B1JsonListToApiJson3(data).ListValues)[0];
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static string Post(string session, PODNMDL data)
        {
            try
            {
                data.DocumentsOwner =(int) Globals.Globals.AuthSessions[session].EmployeeID;
                var PostData = JsonConvert.SerializeObject(data, Newtonsoft.Json.Formatting.None,
                            new JsonSerializerSettings
                            {
                                NullValueHandling = NullValueHandling.Ignore
                            });
                var Post = Pipeline.Post(session, PostData, "PurchaseDeliveryNotes");
                var Posresult = JsonConvert.DeserializeObject<PODNMDL>(Post);
                return "Goods receipt PO " + Posresult.DocNum;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
