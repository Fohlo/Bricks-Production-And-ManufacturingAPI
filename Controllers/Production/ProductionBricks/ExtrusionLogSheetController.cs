using Microsoft.AspNetCore.Mvc;
using System;
using PhotechxAPI.BLL.Session;
using PhotechxAPI.Models;
using Newtonsoft.Json;
using PhotechxAPI.BLL.Production.ProductionBricks;
using PhotechxAPI.Models.Production.ProductionBricks;

namespace PhotechxAPI.Controllers.Production.ProductionBricks
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExtrusionLogSheetController : Controller
    {

        [HttpGet]
        public ErrorMDL Get(string session, int DocEntry)
        {
            try
            {
                SessionBLL.ValidateAppSession(session);
                return new ErrorMDL { Success = JsonConvert.SerializeObject(ExtrusionLogSheetBLL.get(session, DocEntry)) };
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
                var query = "EXLOGSHEET?$filter = Status eq 'O'";
                return new ErrorMDL { Success = JsonConvert.SerializeObject(ExtrusionLogSheetBLL.get(session, query)) };
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
        public ErrorMDL Post(string session, PostExtrusionLogSheetMDL data)
        {
            try
            {
                SessionBLL.ValidateAppSession(session);
                return new ErrorMDL { Success = JsonConvert.SerializeObject(ExtrusionLogSheetBLL.Post(session, data)) };
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
        public ErrorMDL Post(string session, int DocEntry, PatchExtrusionLogSheetMDL data)
        {
            try
            {
                SessionBLL.ValidateAppSession(session);
                return new ErrorMDL { Success = JsonConvert.SerializeObject(ExtrusionLogSheetBLL.Patch(session, data, DocEntry)) };
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
                var query = "EXLOGSHEET?$filter = DocNum eq " + DocNum;
                return new ErrorMDL { Success = JsonConvert.SerializeObject(ExtrusionLogSheetBLL.get(session, query)) };
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
                var query = "EXLOGSHEET?$filter = U_Date eq '" + Batch + "'";
                return new ErrorMDL { Success = JsonConvert.SerializeObject(ExtrusionLogSheetBLL.get(session, query)) };
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