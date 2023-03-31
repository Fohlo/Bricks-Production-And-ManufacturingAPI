using PhotechxAPI.BLL.ProductionOrder;
using PhotechxAPI.BLL.Session;
using PhotechxAPI.Models;
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
    public class ProductionOrdersController : ControllerBase
    {

        [HttpGet]
        public ErrorMDL Get(string session, string Date)
        {
            try
            {
                SessionBLL.ValidateAppSession(session);
                return new ErrorMDL { Success = JsonConvert.SerializeObject(ProductionOrderBLL.getOpen(session, Date)) };
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
