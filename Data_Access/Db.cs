using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Business_Entity;

namespace Data_Access
{
    public class Db : DbContext
    {
        public Db() : base("Con_Str") { }
        public DbSet<Contact> Db_Context { get; set; }
    }
}
