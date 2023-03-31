using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PhotechxAPI.Models.Items;

namespace PhotechxAPI.BLL.Items
{
    public class ItemsBLL
    {
        public static ItemsMDL getOpen(string session, string Doc)
        {
            try
            {
                var clause = "Items('" + Doc + "')";
                var Alldata = new List<ItemsMDL>();
                var data = Pipeline.Get(session, clause);
                return JsonConvert.DeserializeObject<ItemsMDL>(data);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<ItemsMDL> get(string session, string Doc)
        {
            try
            {
                var clause = "Items";
                var Alldata = new List<ItemsMDL>();
                var data = Pipeline.GetMultiple(session, clause);
                foreach (string infor in data)
                {
                    Alldata.AddRange(JsonConvert.DeserializeObject<List<ItemsMDL>>(infor));
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
