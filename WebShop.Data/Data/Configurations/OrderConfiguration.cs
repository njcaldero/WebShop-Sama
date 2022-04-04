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
    internal class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        void IEntityTypeConfiguration<Order>.Configure(EntityTypeBuilder<Order> builder)
        {
            builder.Property(e => e.Ammount).HasColumnType("decimal(18, 0)");

            builder.Property(e => e.OrderAddress)
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.OrderEmail)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.ShippingAddress)
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.HasOne(d => d.Customer)
                .WithMany(p => p.Orders)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Orders_Customers");
        }
    }
}
