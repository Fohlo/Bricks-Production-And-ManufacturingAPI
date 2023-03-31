using PhotechxAPI.BLL.Session;
using PhotechxAPI.BLL.Sheq;
using PhotechxAPI.Models;
using PhotechxAPI.Models.SHEQ;
using PhotechxAPI.Models.PlantMaintance;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PhotechxAPI.BLL.PlantMaintance;
namespace PhotechxAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DowntimeController : Controller
    {
        [HttpGet]
        public ErrorMDL Get(string session, int Doc)
        {
            try
            {
                SessionBLL.ValidateAppSession(session);
                return new ErrorMDL { Success = JsonConvert.SerializeObject(DowntimeBLL.get(session, Doc)) };
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
                var query = "downtime?$filter = Status eq 'O'";
                return new ErrorMDL { Success = JsonConvert.SerializeObject(DowntimeBLL.get(session, query)) };
            }
            catch (Exception ex)
            {
                return new ErrorMDL
                {
                    Error = ex.Message
                };
            }
        }

        [HttpPost]
        public ErrorMDL Post(string session, PostDownTimeMDL data)
        {
            try
            {
                SessionBLL.ValidateAppSession(session);
                return new ErrorMDL { Success = JsonConvert.SerializeObject(DowntimeBLL.Post(session, data)) };
            }
            catch (Exception ex)
            {
                return new ErrorMDL
                {
                    Error = ex.Message
                };
            }
        }


        [HttpPost]
        [Route("Update")]
        public ErrorMDL Post(string session, int Doc, PatchDownTimeMDL data)
        {
            try
            {
                SessionBLL.ValidateAppSession(session);
                return new ErrorMDL { Success = JsonConvert.SerializeObject(DowntimeBLL.Patch(session, data, Doc)) };
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
        [Route("GetByMachineNo")]
        public ErrorMDL MachineNo(string session, string MachineNo)
        {
            try
            {
                SessionBLL.ValidateAppSession(session);
                var query = "downtime?$filter = U_MachineNo eq '" + MachineNo + "'";
                return new ErrorMDL { Success = JsonConvert.SerializeObject(DowntimeBLL.gets(session, query)) };
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
        [Route("GetByMachineGrp")]
        public ErrorMDL MachineGrp(string session, string MachineGrp)
        {
            try
            {
                SessionBLL.ValidateAppSession(session);
                var query = "downtime?$filter = U_MachineGrp eq '" + MachineGrp + "'";
                return new ErrorMDL { Success = JsonConvert.SerializeObject(DowntimeBLL.gets(session, query)) };
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
        [Route("GetByWeekNo")]
        public ErrorMDL WeekNo(string session, int WeekNo)
        {
            try
            {
                SessionBLL.ValidateAppSession(session);
                var query = "downtime?$filter = U_WeekNo eq " + WeekNo;
                return new ErrorMDL { Success = JsonConvert.SerializeObject(DowntimeBLL.get(session, query)) };
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
        [Route("GetByDate")]
        public ErrorMDL Date(string session, string Date)
        {
            try
            {
                SessionBLL.ValidateAppSession(session);
                var query = "downtime?$filter = U_Date eq '" + Date + "'";
                return new ErrorMDL { Success = JsonConvert.SerializeObject(DowntimeBLL.get(session, query)) };
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
