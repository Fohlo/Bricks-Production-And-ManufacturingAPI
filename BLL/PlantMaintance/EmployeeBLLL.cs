using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.Threading.Tasks;
using PhotechxAPI.Models;

namespace PhotechxAPI.BLL.PlantMaintance
{
    public class EmployeeBLLL
    {

        public static EmployeeMDL get(string session, EmployeeMDL empID)
        {
            try
            {
                try
                {
                    var clause = "OHEM(" + empID + ")";
                    var data = Pipeline.Get(session, clause);
                    return JsonConvert.DeserializeObject<EmployeeMDL>(data);
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


        public static List<EmployeeMDL> get(string session, string Query)
        {
            try
            {
                try
                {
                    var Alldata = new List<EmployeeMDL>();
                    var data = Pipeline.GetMultiple(session, Query);
                    foreach (string infor in data)
                    {
                        Alldata.AddRange(JsonConvert.DeserializeObject<List<EmployeeMDL>>(infor));
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


    }
}
