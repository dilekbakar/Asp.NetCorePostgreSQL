using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace PostegreSQL.Data
{
    public class PostgreSQLDBContext : DbContext
    {
        //constructor
        public PostgreSQLDBContext(DbContextOptions<PostgreSQLDBContext> options) : base(options)
        {

        }

        //DbContextin içine DbSet ile tablo tanımlamak yerine onModelCreating metodu override ettik. 
        //onModelCreating metodunda yapacağımız düzenlemeler ile otomatik olarak ArticleConfigurationla , 
        //Article modelinin bir database tablosu olduğunu ve içerisindeki validationların database tarafından düzenlenmesi gerektiği biliniyor.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(PostgreSQLDBContext).Assembly);

        }

    }
}
