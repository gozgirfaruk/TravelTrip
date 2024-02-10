using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelTrip.Models.Siniflar
{
    public class Yorumlar
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Mail { get; set; }
        public string Comment { get; set; }
       
        public Blog Blog { get; set; }
    }
}