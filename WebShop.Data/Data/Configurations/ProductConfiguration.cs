using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShop.Core.Entities;

namespace WebShop.Data.Data.Configurations
{
    internal class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        void IEntityTypeConfiguration<Product>.Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(e => e.CreateDate).HasDefaultValueSql("(getdate())");

            builder.Property(e => e.Description)
                .HasMaxLength(500)
                .IsUnicode(false);

            builder.Property(e => e.Price).HasColumnType("decimal(18, 0)");

            builder.Property(e => e.Title)
                .HasMaxLength(200)
                .IsUnicode(false);
        }
    }
}
