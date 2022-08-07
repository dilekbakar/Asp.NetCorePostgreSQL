using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PostegreSQL.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PostegreSQL.Data.Configuration
{
    public class ArticleConfiguration : IEntityTypeConfiguration<Article> //Framework.Core içerisinde bulunan bir interface. IEntityTypeConfiguration, bir entity domaini istiyor.
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.Property(s => s.Title).HasMaxLength(300);
            builder.Property(s => s.Description).HasMaxLength(600);

        }
    }
}
