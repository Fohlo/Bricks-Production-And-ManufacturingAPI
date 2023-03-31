using PhotechxAPI.BLL.Session;
using PhotechxAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PhotechxAPI.BLL.PlantMaintance;
using PhotechxAPI.Models.PlantMaintance;

namespace PhotechxAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CheckListItemController : ControllerBase
    {
        [HttpGet]
        public ErrorMDL Get(string session, string type)
        {
            try
            {
                SessionBLL.ValidateAppSession(session);
                string query = "CHECKITEMS?$filter =U_Type eq '"+type+"'";
                return new ErrorMDL { Success = JsonConvert.SerializeObject(CheckListItemsBLL.get(session,query)) };
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
                var query = "CHECKITEMS?$filter = Status eq 'O'";
                return new ErrorMDL { Success = JsonConvert.SerializeObject(CheckListItemsBLL.get(session, query)) };
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
        public ErrorMDL Post(string session, PostCheckListItemMDL data)
        {
            try
            {
                SessionBLL.ValidateAppSession(session);
                return new ErrorMDL { Success = JsonConvert.SerializeObject(CheckListItemsBLL.Post(session, data)) };
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
