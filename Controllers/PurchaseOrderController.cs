using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PhotechxAPI.BLL.PurchaseOrder;
using PhotechxAPI.BLL.Session;
using PhotechxAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PhotechxAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchaseOrderController : ControllerBase
    {
        // GET: api/<PurchaseOrderController>
        [HttpGet]
        public ErrorMDL Get(string session)
        {
            try
            {
                SessionBLL.ValidateAppSession(session);
                return new ErrorMDL { Success = JsonConvert.SerializeObject(PurchaseOrderBLL.getOpen(session)) };
            }
            catch (Exception ex)
            {
                return new ErrorMDL
                {
                    Error = ex.Message
                };
            }
        }

        // GET api/<PurchaseOrderController>/5
        [HttpGet]
        [Route("GetByDocNum")]
        public ErrorMDL Get(string session, int DocNum)
        {
            try
            {
                SessionBLL.ValidateAppSession(session);
                    return new ErrorMDL { Success = JsonConvert.SerializeObject(PurchaseOrderBLL.getOpen(session, DocNum)) };                              
            }
            catch (Exception ex)
            {
                return new ErrorMDL { Error = ex.Message };
            }
        }

        [HttpGet]
        [Route("GetByDocEntry")]
        public ErrorMDL Gets(string session, int DocEntry )
        {
            try
            {
                SessionBLL.ValidateAppSession(session);
                return new ErrorMDL { Success = JsonConvert.SerializeObject(PurchaseOrderBLL.getOpenByDocEntry(session, DocEntry)) };
            }
            catch (Exception ex)
            {
                return new ErrorMDL { Error = ex.Message };
            }
        }

        // POST api/<PurchaseOrderController>
        //[HttpPost]
        //public ErrorMDL Post(string session,  Purcha value)
        //{
        //    try
        //    {

        //    }
        //    catch (Exception ex)
        //    {
        //        return new ErrorMDL { Error = ex.Message };
        //    }

        //}

        // PUT api/<PurchaseOrderController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PurchaseOrderController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
