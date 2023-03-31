using Microsoft.AspNetCore.Mvc;
using System;
using PhotechxAPI.BLL.PlantMaintance;
using PhotechxAPI.BLL.Session;
using PhotechxAPI.Models;
using PhotechxAPI.Models.PlantMaintance;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PhotechxAPI.BLL.Production.ProductionBricks;
using PhotechxAPI.Models.Production.ProductionBricks;

namespace PhotechxAPI.Controllers.Production.ProductionBricks
{
    [Route("api/[controller]")]
    [ApiController]
    public class OffloadController : Controller
    {

        [HttpGet]
        public ErrorMDL Get(string session, int DocEntry)
        {
            try
            {
                SessionBLL.ValidateAppSession(session);
                return new ErrorMDL { Success = JsonConvert.SerializeObject(OffLoadBLL.get(session, DocEntry)) };
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
                var query = "OFFLOAD?$filter = Status eq 'O'";
                return new ErrorMDL { Success = JsonConvert.SerializeObject(OffLoadBLL.get(session, query)) };
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
        public ErrorMDL Post(string session, PostOffLoadMDL data)
        {
            try
            {
                SessionBLL.ValidateAppSession(session);
                return new ErrorMDL { Success = JsonConvert.SerializeObject(OffLoadBLL.Post(session, data)) };
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
        public ErrorMDL Post(string session, int DocEntry, PatchOffLoadMDL data)
        {
            try
            {
                SessionBLL.ValidateAppSession(session);
                return new ErrorMDL { Success = JsonConvert.SerializeObject(OffLoadBLL.Patch(session, data, DocEntry)) };
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
        [Route("GetByDocNum")]
        public ErrorMDL DocNum(string session, int DocNum)
        {
            try
            {
                SessionBLL.ValidateAppSession(session);
                var query = "OFFLOAD?$filter = DocNum eq " + DocNum;
                return new ErrorMDL { Success = JsonConvert.SerializeObject(OffLoadBLL.get(session, query)) };
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
        [Route("GetByBatch")]
        public ErrorMDL Batch(string session, string Batch)
        {
            try
            {
                SessionBLL.ValidateAppSession(session);
                var query = "OFFLOAD?$filter = U_Date eq '" + Batch + "'";
                return new ErrorMDL { Success = JsonConvert.SerializeObject(OffLoadBLL.get(session, query)) };
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



        