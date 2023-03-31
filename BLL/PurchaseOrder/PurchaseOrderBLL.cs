using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PhotechxAPI.BLL.Session;
using PhotechxAPI.Models.PurchaseOrder;
using PhotechxAPI.VC;

namespace PhotechxAPI.BLL.PurchaseOrder
{
    public class PurchaseOrderBLL
    {

        public static List<POMDL> getOpen(string session)
        {
            try
            {
                var clause = "PurchaseOrders?$filter = DocumentStatus eq 'bost_Open'";
                var Alldata = new List<POMDL>();
                var data = Pipeline.GetMultiple(session, clause);
                foreach (string list in data)
                {
                    var settings = new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore,
                        MissingMemberHandling = MissingMemberHandling.Ignore
                    };
                    //var jsonModel = JsonConvert.DeserializeObject<Customer>(jsonString, settings);

                    Alldata.AddRange(JsonConvert.DeserializeObject<List<POMDL>>(list, settings));
                }

                return Alldata;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // the boolean is to confirm if its DocEntry Search
        public static POMDL getOpen(string session, int Doc)
        {
            try
            {
               var  clause = "PurchaseOrders?$filter = DocNum eq " + Doc;
                var Alldata = new List<POMDL>();
                var data = Pipeline.Get(session, clause);
                return JsonConvert.DeserializeObject<List<POMDL>>(ClassVC.B1JsonListToApiJson3(data).ListValues)[0];
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static POMDL getOpenByDocEntry(string session, int Doc)
        {
            try
            {
                var clause = "PurchaseOrders(" + Doc + ")";
                var Alldata = new List<POMDL>();
                var data = Pipeline.Get(session, clause);
                return JsonConvert.DeserializeObject<POMDL>(data);
                //return JsonConvert.DeserializeObject<List<POMDL>>(ClassVC.B1JsonListToApiJson3(data).ListValues)[0];
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }




    }
}
