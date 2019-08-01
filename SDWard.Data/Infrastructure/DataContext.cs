using SDWard.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDWard.Data.Infrastructure
{
   public class DataContext: DbContext, IDataContext
    {
        public DataContext(): base("Name=PoonamContext")
        {
            Database.SetInitializer<DataContext>(null);
        }
        public DbSet<Billing_table_Poonam> Billing_table_Poonam { get; set; }
        public DbSet<Department_tbl_poonam> Department_tbl_poonam { get; set; }
        public DbSet<User_tbl_Poonam> User_tbl_Poonam { get; set; }
        public DbSet<RecordSet_tbl_Poonam> RecordSet_tbl_Poonam { get; set; }
        public DbSet<UsersRole_tbl_poonam> UsersRole_tbl_poonam { get; set; }
        public DbSet<Verification_poonam> Verification_poonam { get; set; }
        public DbSet<Poonam_Patientschedule> Poonam_Patientschedule { get; set; }


    }
}
