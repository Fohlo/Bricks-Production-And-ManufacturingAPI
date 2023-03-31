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
using PhotechxAPI.BLL.Stores;
using PhotechxAPI.Models.Stores;

namespace PhotechxAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoresController : Controller
    {
        [HttpGet]
        public ErrorMDL Get(string session, StoresMDL ItemCode)
        {
            try
            {
                SessionBLL.ValidateAppSession(session);
                return new ErrorMDL { Success = JsonConvert.SerializeObject(StoresBLL.get(session, ItemCode)) };
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
                var query = "OITM?$filter = Status eq 'Open'";
                return new ErrorMDL { Success = JsonConvert.SerializeObject(StoresBLL.get(session, query)) };
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
        public ErrorMDL Post(string session, PostStoresMDL data)
        {
            try
            {
                SessionBLL.ValidateAppSession(session);
                return new ErrorMDL { Success = JsonConvert.SerializeObject(StoresBLL.Post(session, data)) };
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
        public ErrorMDL Post(string session, int Doc, PatchStoresMDL data)
        {
            try
            {
                SessionBLL.ValidateAppSession(session);
                return new ErrorMDL { Success = JsonConvert.SerializeObject(StoresBLL.Patch(session, data, Doc)) };
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
        [Route("GetByItemCode")]
        public ErrorMDL ItemCode(string session, string ItemCode)
        {
            try
            {
                SessionBLL.ValidateAppSession(session);
                var query = "OITM?$filter = ItemCode eq " + ItemCode;
                return new ErrorMDL { Success = JsonConvert.SerializeObject(StoresBLL.get(session, query)) };
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
        [Route("GetByItemName")]
        public ErrorMDL ItemName(string session, string ItemName)
        {
            try
            {
                SessionBLL.ValidateAppSession(session);
                var query = "OITM?$filter = ItemName eq '" + ItemName + "'";
                return new ErrorMDL { Success = JsonConvert.SerializeObject(StoresBLL.get(session, query)) };
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