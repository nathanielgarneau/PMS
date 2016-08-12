using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.Xam.DAL
{
    public class CodeFirstModel : System.Data.Entity.DbContext
    {
        public CodeFirstModel()
            : base("name=CodeFirstModel")
        {
            System.Data.Entity.Database.SetInitializer<CodeFirstModel>(null);
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<MicroQCCodeFirstModel, Migrations.Configuration>());
            //Configuration.LazyLoadingEnabled = false;
        }
        public virtual DbSet<Model.Address> Address { get; set; }
    }
}
