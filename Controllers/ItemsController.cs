using PhotechxAPI.BLL.Session;
using PhotechxAPI.BLL.Sheq;
using PhotechxAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PhotechxAPI.BLL.Items;


namespace PhotechxAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {

       [HttpGet]
       [Route("list")]

       public ErrorMDL Get(string session)
        {
            try
            {
                //var clause = "Items";
                var Items = ItemBLL.GetMultiple(session, "Items");
                return new ErrorMDL
                {
                    Success = JsonConvert.SerializeObject(Items)
                };
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
                ItemBLL.ValidateAppSession(session);
                var query = "Items?$filter = ItemCode eq " + ItemCode;
                return new ErrorMDL { Success = JsonConvert.SerializeObject(ItemBLL.Getspecific(session, query)) };
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
                ItemBLL.ValidateAppSession(session);
                var query = "Items?$filter = ItemName eq '" + ItemName + "'";
                return new ErrorMDL { Success = JsonConvert.SerializeObject(ItemBLL.Getspecificc(session, query)) };
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
