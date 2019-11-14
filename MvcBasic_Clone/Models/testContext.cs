using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcBasic_Clone.Models
{
    public class testContext : DbContext
    {
        public testContext() : base("name=testContext")
        {
        }
        public System.Data.Entity.DbSet<MvcBasic_Clone.Models.test> tesr { get; set; }
    }
}