using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PhotechxAPI.BLL.GRPO;
using PhotechxAPI.BLL.Session;
using PhotechxAPI.Models;
using PhotechxAPI.Models.PurchaseOrder;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PhotechxAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GoodsReceiptPO : ControllerBase
    {
        // GET: api/<GoodsReceiptPO>
        [HttpGet]
        public ErrorMDL Get(string session, int DocNum)
        {
            try
            {
                SessionBLL.ValidateAppSession(session);
                return new ErrorMDL { Success = JsonConvert.SerializeObject(GRPOBLL.getOpen(session, DocNum)) };
            }
            catch (Exception ex)
            {
                return new ErrorMDL { Error = ex.Message };
            }
        }

        // GET api/<GoodsReceiptPO>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<GoodsReceiptPO>
        [HttpPost]
        public ErrorMDL Post(string session, PODNMDL data)
        {
            try
            {
                SessionBLL.ValidateAppSession(session);
                return new ErrorMDL { Success = JsonConvert.SerializeObject(GRPOBLL.Post(session, data)) };
            }
            catch (Exception ex)
            {
                return new ErrorMDL { Error = ex.Message };
            }

        }

        // PUT api/<GoodsReceiptPO>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<GoodsReceiptPO>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
