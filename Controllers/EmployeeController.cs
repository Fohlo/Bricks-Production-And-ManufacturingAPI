using Microsoft.AspNetCore.Mvc;
using System;
using PhotechxAPI.BLL.Session;
using PhotechxAPI.BLL.Sheq;
using PhotechxAPI.Models;
using PhotechxAPI.Models.SHEQ;
using PhotechxAPI.Models.PlantMaintance;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PhotechxAPI.BLL.Employee;
using PhotechxAPI.BLL.PlantMaintance;

namespace PhotechxAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : Controller
    {
        [HttpGet]
        public ErrorMDL Get(string session, EmployeeMDL empID)
        {
            try
            {
                SessionBLL.ValidateAppSession(session);
                return new ErrorMDL { Success = JsonConvert.SerializeObject(EmployeeBLLL.get(session, empID)) };
            }
            catch (Exception ex)
            {
                return new ErrorMDL
                {
                    Error = ex.Message
                };
            }
        }

        [HttpGet]
        [Route("GetOpen")]
        public ErrorMDL Get(string session)
        {
            try
            {
                SessionBLL.ValidateAppSession(session);
                var query = "OHEM";
                return new ErrorMDL { Success = JsonConvert.SerializeObject(EmployeeBLLL.get(session, query)) };
            }
            catch (Exception ex)
            {
                return new ErrorMDL
                {
                    Error = ex.Message
                };
            }
        }

        [HttpGet]
        [Route("GetByEmployeeID")]
        public ErrorMDL ItemCode(string session, string empID)
        {
            try
            {
                SessionBLL.ValidateAppSession(session);
                var query = "OHEM?$filter = empID eq " + empID;
                return new ErrorMDL { Success = JsonConvert.SerializeObject(EmployeeBLLL.get(session, query)) };
            }
            catch (Exception ex)
            {
                return new ErrorMDL
                {
                    Error = ex.Message
                };
            }
        }
        [HttpGet]
        [Route("GetBylastName")]
        public ErrorMDL lastName(string session, string lastName)
        {
            try
            {
                SessionBLL.ValidateAppSession(session);
                var query = "OHEM?$filter = lastName eq '" + lastName + "'";
                return new ErrorMDL { Success = JsonConvert.SerializeObject(EmployeeBLLL.get(session, query)) };
            }
            catch (Exception ex)
            {
                return new ErrorMDL
                {
                    Error = ex.Message
                };
            }
        }


    }
}
