using PhotechxAPI.BLL.Session;
using PhotechxAPI.BLL.Sheq;
using PhotechxAPI.Models;
using PhotechxAPI.Models.SHEQ;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotechxAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WetBrickInpsectionController : ControllerBase
    {

        [HttpGet]
        public ErrorMDL Get(string session, int Doc)
        {
            try
            {
                SessionBLL.ValidateAppSession(session);
                return new ErrorMDL { Success = JsonConvert.SerializeObject(WetBrickInspectionBLL.get(session, Doc)) };
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
                var query = "WBIF?$filter =Status eq 'O'";
                return new ErrorMDL { Success = JsonConvert.SerializeObject(WetBrickInspectionBLL.get(session, query)) };
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
        public ErrorMDL Post(string session, PostWetBrickIFMDL data)
        {
            try
            {
                SessionBLL.ValidateAppSession(session);
                return new ErrorMDL { Success = JsonConvert.SerializeObject(WetBrickInspectionBLL.Post(session, data)) };
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
        public ErrorMDL Post(string session, int Doc ,PatchWetBrickIFMDL data)
        {
            try
            {
                SessionBLL.ValidateAppSession(session);
                return new ErrorMDL { Success = JsonConvert.SerializeObject(WetBrickInspectionBLL.Patch(session, data, Doc)) };
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
                var query = "WBIF?$filter = DocNum eq " + DocNum;
                return new ErrorMDL { Success = JsonConvert.SerializeObject(WetBrickInspectionBLL.get(session, query)) };
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
                var query = "WBIF?$filter = U_Batch eq '" + Batch+"'";
                return new ErrorMDL { Success = JsonConvert.SerializeObject(WetBrickInspectionBLL.get(session, query)) };
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
