using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using TravelTrip.Models.Siniflar;

namespace TravelTrip.Context
{
    public class TravelContext :DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Konum> Konums { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Hakkimizda> Hakkimizdas { get; set; }
        public DbSet<Iletisim> Iletisims { get; set; }
        public DbSet<Yorumlar> Yorumlars { get; set; }
    }
}