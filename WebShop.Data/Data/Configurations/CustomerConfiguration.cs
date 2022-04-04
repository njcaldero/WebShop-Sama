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
    internal class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        void IEntityTypeConfiguration<Customer>.Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.Property(e => e.BillingAddress)
           .HasMaxLength(100)
           .IsUnicode(false);

            builder.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.Fullname)
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.Password)
                .HasMaxLength(8)
                .IsUnicode(false);

            builder.Property(e => e.Phone)
                .HasMaxLength(10)
                .IsUnicode(false);
        }
    }
}
