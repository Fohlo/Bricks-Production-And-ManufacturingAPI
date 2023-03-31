using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PhotechxAPI.Models.PickList;

namespace PhotechxAPI.BLL.PickList
{
    public class PickListBLL
    {
        public static PicklistMDL GetByDocEntry(string session, int Doc)
        {
            try
            {
                var clause = "PickLists(" + Doc + ")";
                var Alldata = new List<PicklistMDL>();
                var data = Pipeline.Get(session, clause);
                return JsonConvert.DeserializeObject<PicklistMDL>(data);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static PicklistMDL GetByDcNum(string session, string Doc)
        {
            try
            {
                var clause = "PickLists?$filter =DocNum eq "+ Doc;
                var Alldata = new List<PicklistMDL>();
                var data = Pipeline.GetMultiple(session, clause);

                foreach (string docs in data)
                {
                    Alldata.AddRange(JsonConvert.DeserializeObject<List<PicklistMDL>>(docs));
                }

                return Alldata[0];
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<PicklistMDL> GetAllOpen(string session)
        {
            try
            {
                var clause = "PickLists?$filter =Status eq 'ps_Released' or Status eq 'ps_PartiallyPicked'";
                var Alldata = new List<PicklistMDL>();
                var data = Pipeline.GetMultiple(session, clause);

                foreach (string docs in data)
                {
                    Alldata.AddRange(JsonConvert.DeserializeObject<List<PicklistMDL>>(docs));
                }

                return Alldata;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static string Patchpick()
        {
            try
            {
                return null;
            }
            catch (Exception ex )
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
