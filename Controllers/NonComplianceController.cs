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
    public class NonComplianceController : ControllerBase
    {

        [HttpGet]
        public ErrorMDL Get(string session, int Doc)
        {
            try
            {
                SessionBLL.ValidateAppSession(session);
                return new ErrorMDL { Success = JsonConvert.SerializeObject(NonComplianceBLL.get(session, Doc)) };
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
                var query = "NonCompliance?$filter = U_Status eq 'Open'";
                return new ErrorMDL { Success = JsonConvert.SerializeObject(NonComplianceBLL.get(session, query)) };
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
        public ErrorMDL Post(string session, PostNonComplianceMDL data)
        {
            try
            {
                SessionBLL.ValidateAppSession(session);
                var query = "NonCompliance";
                return new ErrorMDL { Success = JsonConvert.SerializeObject(NonComplianceBLL.Post(session, data)) };
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
        public ErrorMDL Post(string session, PatchNonComplianceMDL data, int Doc)
        {
            try
            {
                SessionBLL.ValidateAppSession(session);
                return new ErrorMDL { Success = JsonConvert.SerializeObject(NonComplianceBLL.Patch(session, data, Doc)) };
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
                var query = "NonCompliance?$filter = DocNum eq " + DocNum;
                return new ErrorMDL { Success = JsonConvert.SerializeObject(WetTileInspectionBLL.get(session, query)) };
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
                var query = "NonCompliance?$filter = U_Batch eq '" + Batch+"'";
                return new ErrorMDL { Success = JsonConvert.SerializeObject(WetTileInspectionBLL.get(session, query)) };
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
