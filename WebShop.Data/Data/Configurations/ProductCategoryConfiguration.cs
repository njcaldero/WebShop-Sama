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
    internal class ProductCategoryConfiguration : IEntityTypeConfiguration<ProductCategory>
    {
        void IEntityTypeConfiguration<ProductCategory>.Configure(EntityTypeBuilder<ProductCategory> builder)
        {
            builder.HasOne(d => d.Category)
                   .WithMany(p => p.ProductCategories)
                   .HasForeignKey(d => d.CategoryId)
                   .OnDelete(DeleteBehavior.ClientSetNull)
                   .HasConstraintName("FK_ProductCategories_Categories");

            builder.HasOne(d => d.Product)
                .WithMany(p => p.ProductCategories)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductCategories_Products");
        }
    }
}
