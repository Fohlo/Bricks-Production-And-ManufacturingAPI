using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhotechxAPI.Models
{
    public class LoginMDL
    {


        public string CompanyDB { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public LoginTypes LoginType { get; set; }
        public Department Department { get; set; }
    }

   public enum LoginTypes
        {
            Officer = 1,
            Driver = 2,
            Admin = 3,            
            Manager = 4,
            Scanner = 5,
            Uploader = 6,
            None = 0,
            Security =7
        }
    
   public enum Department
    {
         None = 0,
        Sheq = 1,
        Bricks = 2,
        Tiles = 3,
        Ridge = 4,
        Security = 5,
        Logistics = 6,
        Production = 7,
        IT = 8

    }
}