using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Shopper.Domain;

namespace Shopper.DataAccess.Mapping
{
    public class InventoryMap : EntityTypeConfiguration<Inventory>
    {
        public InventoryMap()
        {
            ToTable("Inventory");
            HasKey(t => t.InventoryId);
            Property(t => t.InventoryId)
                .IsRequired()
                .HasColumnName("InventoryId")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnType("INT");
            Property(t => t.ItemDescription)
                .IsRequired()
                .HasColumnName("ItemDescription")
                .HasMaxLength(100)
                .HasColumnType("NVARCHAR");
            Property(t => t.ItemName)
                .IsRequired()
                .HasColumnName("ItemName")
                .HasMaxLength(100)
                .HasColumnType("NVARCHAR");
            Property(t => t.Manufacturer)
                .IsRequired()
                .HasColumnName("Manufacturer")
                .HasMaxLength(100)
                .HasColumnType("NVARCHAR");
            Property(t => t.Supplier)
                .IsRequired()
                .HasColumnName("Supplier")
                .HasMaxLength(100)
                .HasColumnType("NVARCHAR");
            Property(t => t.UnitsInStock)
                .IsRequired()
                .HasColumnName("UnitsInStock")
                .HasColumnType("BIGINT");
            Property(t => t.Price)
                .IsRequired()
                .HasColumnName("Price")
                .HasColumnType("DECIMAL");
            Property(t => t.RetailDispense)
                .IsRequired()
                .HasColumnName("RetailDispense")
                .HasColumnType("INT");
        }
    }
}