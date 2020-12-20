namespace ETicaretDersiProje.Eticaret.DataAccess.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ETicaretDersiProje.Eticaret.DataAccess.Concrete.EntityFramework.EticaretContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }
       
        protected override void Seed(ETicaretDersiProje.Eticaret.DataAccess.Concrete.EntityFramework.EticaretContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
