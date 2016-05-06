using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Shopper.Domain;

namespace Shopper.DataAccess.Mapping
{
    public class CustomerMap : EntityTypeConfiguration<Customer>
    {
        public CustomerMap()
        {
            ToTable("Customer");
            HasKey(t => t.CustomerId);
            Property(t => t.CustomerId)
                .IsRequired()
                .HasColumnName("CustomerId")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnType("INT");
            Property(t => t.FirstName)
                .IsRequired()
                .HasColumnName("FirstName")
                .HasMaxLength(100)
                .HasColumnType("NVARCHAR");
            Property(t => t.LastName)
                .IsOptional()
                .HasColumnName("LastName")
                .HasMaxLength(100)
                .HasColumnType("NVARCHAR");
            HasMany(t => t.ShoppingCarts);
        }
    }
}
