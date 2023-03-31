using Microsoft.AspNetCore.Mvc;
using PhotechxAPI.BLL.Session;
using PhotechxAPI.BLL.Sheq;
using PhotechxAPI.Models;
using PhotechxAPI.Models.SHEQ;
using PhotechxAPI.Models.PlantMaintance;
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
    public class BricksDowntimeController : Controller
    {
        [HttpGet]
        public ErrorMDL Get(string session, int Doc)
        {
            try
            {
                SessionBLL.ValidateAppSession(session);
                return new ErrorMDL { Success = JsonConvert.SerializeObject(BricksdowntimeBLL.get(session, Doc)) };
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
                var query = "bricksdt?$filter = Status eq 'O'";
                return new ErrorMDL { Success = JsonConvert.SerializeObject(BricksdowntimeBLL.get(session, query)) };
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
        public ErrorMDL Post(string session, PostBricksDowntimeMDL data)
        {
            try
            {
                SessionBLL.ValidateAppSession(session);
                return new ErrorMDL { Success = JsonConvert.SerializeObject(BricksdowntimeBLL.Post(session, data)) };
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
        public ErrorMDL Post(string session, int Doc, PatchBricksDowntimeMDL data)
        {
            try
            {
                SessionBLL.ValidateAppSession(session);
                return new ErrorMDL { Success = JsonConvert.SerializeObject(BricksdowntimeBLL.Patch(session, data, Doc)) };
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
        [Route("GetByBrickType")]
        public ErrorMDL BrickType(string session, string BrickType)
        {
            try
            {
                SessionBLL.ValidateAppSession(session);
                var query = "bricksdt?$filter = U_BrickType eq '" + BrickType + "'";
                return new ErrorMDL { Success = JsonConvert.SerializeObject(BricksdowntimeBLL.gets(session, query)) };
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
        [Route("GetByPlant")]
        public ErrorMDL Plant(string session, string Plant)
        {
            try
            {
                SessionBLL.ValidateAppSession(session);
                var query = "bricksdt?$filter = U_Plant eq '" + Plant + "'";
                return new ErrorMDL { Success = JsonConvert.SerializeObject(BricksdowntimeBLL.gets(session, query)) };
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
        [Route("GetByOperator")]
        public ErrorMDL Operator(string session, string Operator)
        {
            try
            {
                SessionBLL.ValidateAppSession(session);
                var query = "bricksdt?$filter = U_Operator eq '" + Operator + "'";
                return new ErrorMDL { Success = JsonConvert.SerializeObject(BricksdowntimeBLL.gets(session, query)) };
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
        public ErrorMDL WeekNumber(string session, string WeekNumber)
        {
            try
            {
                SessionBLL.ValidateAppSession(session);
                var query = "bricksdt?$filter = U_WeekNumber eq '" + WeekNumber + "'";
                return new ErrorMDL { Success = JsonConvert.SerializeObject(BricksdowntimeBLL.get(session, query)) };
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
                var query = "bricksdt?$filter = U_Date eq '" + Date + "'";
                return new ErrorMDL { Success = JsonConvert.SerializeObject(BricksdowntimeBLL.get(session, query)) };
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
