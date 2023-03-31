using Newtonsoft.Json;
using PhotechxAPI.Models.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotechxAPI.BLL.Items
{
    public class ItemBLL
    {

        public static ItemMDL Getspecific(string session, string ItemCode)
        {
            try
            {
                var clause = "Items(" + ItemCode + ")";
                var getData = Pipeline.Get(session, clause);
                var data = (JsonConvert.DeserializeObject<ItemMDL>(getData));
                return data;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static ItemMDL Getspecificc(string session, string ItemName)
        {
            try
            {
                var clause = "Items(" + ItemName + ")";
                var getData = Pipeline.Get(session, clause);
                var data = (JsonConvert.DeserializeObject<ItemMDL>(getData));
                return data;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static List<ItemMDL> GetMultiple(string session, string clause)
        {
            try
            {               
                var getData = Pipeline.GetMultiples(session, clause);
                var dat = new List<ItemMDL>();
                foreach (string obj in getData)
                {
                    dat.AddRange((JsonConvert.DeserializeObject<List<ItemMDL>>(obj)));
                }
               
                return dat;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static string ValidateAppSession(string abc)
        {
            string sessionId = abc;
            if (Globals.Globals.AuthSessions.ContainsKey(sessionId))
                return sessionId;
            else
                throw new Exception("User not Logged in");
        }

    }
}
