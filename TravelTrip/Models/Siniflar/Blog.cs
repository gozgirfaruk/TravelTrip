using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelTrip.Models.Siniflar
{
    public class Blog
    {
        public int ID { get; set; }
        public string Header { get; set; }
        public  DateTime  Year { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string  Explanation { get; set; }

      //  public ICollection<Yorumlar> Yorumlars { get; set; }

    }
}