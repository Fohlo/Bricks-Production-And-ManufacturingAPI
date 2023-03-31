using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotechxAPI.Models.Shipment
{
    public class ShipmentMDL
    {

        public int DocNum { get; set; }
        public int DocEntry { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string ItmsGrpCod { get; set; }
        public string ItemType { get; set; }

        public List<ShipmentCollection> OITWCollection { get; set; }

        public class ShipmentCollection
        {
            public int OnHand { get; set; }
            public int OnOrder { get; set; }
            public string WhsCode { get; set; }
            public string WhsName { get; set; }
            public string Iscommited { get; set; }
        }
    }
}
