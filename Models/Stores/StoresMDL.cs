using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotechxAPI.Models.Stores
{
    public class StoresMDL
    {
        public int DocNum { get; set; }
        public int DocEntry { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string ItmsGrpCod { get; set; }
        public string ItemType { get; set; }
        public List<oitwcollection> OITWCollection { get; set; }


        public class oitwcollection
        {
            
            public int OnHand { get; set; }
            public int OnOrder { get; set; }
            public string WhsCode{ get; set; }
            public string WhsName { get; set; }
            public string Iscommited { get; set; }
        }


    }

    public class PostStoresMDL
    {
        public int DocNum { get; set; }
        public int DocEntry { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string ItmsGrpCod { get; set; }
        public string ItemType { get; set; }
        public List<oitwcollection> OITWCollection { get; set; }


        public class oitwcollection
        {

            public int OnHand { get; set; }
            public int OnOrder { get; set; }
            public string WhsCode { get; set; }
            public string WhsName { get; set; }
            public string Iscommited { get; set; }
        }


    }

    public class PatchStoresMDL
    {
        public int DocNum { get; set; }
        public int DocEntry { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string ItmsGrpCod { get; set; }
        public string ItemType { get; set; }
        public List<oitwcollection> OITWCollection { get; set; }


        public class oitwcollection
        {

            public int OnHand { get; set; }
            public int OnOrder { get; set; }
            public string WhsCode { get; set; }
            public string WhsName { get; set; }
            public string Iscommited { get; set; }
        }


    }
}