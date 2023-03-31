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
    public class HackLineInspectionController : ControllerBase
    {

            [HttpGet]
            public ErrorMDL Get(string session, int Doc)
            {
                try
                {
                    SessionBLL.ValidateAppSession(session);
                    return new ErrorMDL { Success = JsonConvert.SerializeObject(HackLineInspectionFormBLL.get(session, Doc)) };
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
                    var query = "HACKLINEIS?$filter = Status eq 'O'";
                    return new ErrorMDL { Success = JsonConvert.SerializeObject(HackLineInspectionFormBLL.get(session, query)) };
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
            public ErrorMDL Post(string session, PostHackLineMDL data)
            {
                try
                {
                    SessionBLL.ValidateAppSession(session);
                    return new ErrorMDL { Success = JsonConvert.SerializeObject(HackLineInspectionFormBLL.Post(session, data)) };
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
            public ErrorMDL Post(string session, int Doc, PostHackLineMDL data)
            {
                try
                {
                    SessionBLL.ValidateAppSession(session);
                    return new ErrorMDL { Success = JsonConvert.SerializeObject(HackLineInspectionFormBLL.Patch(session, data, Doc)) };
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
                var query = "HACKLINEIS?$filter = DocNum eq " + DocNum;
                return new ErrorMDL { Success = JsonConvert.SerializeObject(HackLineInspectionFormBLL.get(session, query)) };
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
                var query = "HACKLINEIS?$filter = U_Batch eq '" + Batch+"'";
                return new ErrorMDL { Success = JsonConvert.SerializeObject(HackLineInspectionFormBLL.get(session, query)) };
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
