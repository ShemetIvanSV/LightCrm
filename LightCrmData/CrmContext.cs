using LightCrmData.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightCrmData
{
    public class CrmContext : DbContext
    {
        public CrmContext() : base("CrmDataBase")
        {

        }

        public DbSet<User> Users { get; set; }
    }
}
