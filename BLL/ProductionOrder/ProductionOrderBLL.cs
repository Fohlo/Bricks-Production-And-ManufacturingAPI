using PhotechxAPI.Models.ProductionOrder;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotechxAPI.BLL.ProductionOrder
{
    public class ProductionOrderBLL
    {

        public static ProductionOrderMDL getOpen(string session, string Date)
        {
            try
            {
                var clause = "ProductionOrders?$filter = ReleaseDate eq '" + Date+"'";
                var Alldata = new List<ProductionOrderMDL>();
                var data = Pipeline.GetMultiple(session, clause);
                foreach (string list in data)
                {
                    var settings = new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore,
                        MissingMemberHandling = MissingMemberHandling.Ignore
                    };
                    //var jsonModel = JsonConvert.DeserializeObject<Customer>(jsonString, settings);

                    Alldata.AddRange(JsonConvert.DeserializeObject<List<ProductionOrderMDL>>(list, settings));
                }

                return Alldata[0];
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
