using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PhotechxAPI.Models.Stock;

namespace PhotechxAPI.BLL.Stock
{
    public class InventoryCountBLL
    {
        public static InventoryCountMDL getOpen(string session)
        {
            try
            {
                var clause = "InventoryCountings?$filter = DocumentStatus eq 'cdsOpen'";
                var Alldata = new List<InventoryCountMDL>();
                var data = Pipeline.Get(session, clause);
                return JsonConvert.DeserializeObject<InventoryCountMDL>(data);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        
        public static List<InventoryCountMDL> getOpen(string session, string Doc)
        {
            try
            {
                var clause = "InventoryCountings?$filter = DocumentStatus eq 'cdsOpen'";
                var Alldata = new List<InventoryCountMDL>();
                var data = Pipeline.GetMultiple(session, clause);

                foreach (string dat in data)
                {
                    Alldata.AddRange(JsonConvert.DeserializeObject<List<InventoryCountMDL>>(dat));
                }

                return Alldata;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
