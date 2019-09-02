namespace MVC_CRUD_Migraciones_Automatica.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MVC_CRUD_Migraciones_Automatica.Models.MVC_CRUD_Migraciones_AutomaticaContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "MVC_CRUD_Migraciones_Automatica.Models.MVC_CRUD_Migraciones_AutomaticaContext";
        }

        protected override void Seed(MVC_CRUD_Migraciones_Automatica.Models.MVC_CRUD_Migraciones_AutomaticaContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
