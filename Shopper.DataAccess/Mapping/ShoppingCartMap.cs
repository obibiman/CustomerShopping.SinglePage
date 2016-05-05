using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Shopper.Domain;

namespace Shopper.DataAccess.SqlServer.Mapping
{
    public class ShoppingCartMap : EntityTypeConfiguration<ShoppingCart>
    {
        public ShoppingCartMap()
        {
            ToTable("ShoppingCart");
            HasKey(t => t.ShoppingCartId);
            Property(t => t.ShoppingCartId)
                .IsRequired()
                .HasColumnName("ShoppingCartId")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasColumnType("INT");
            Property(t => t.PurchaseDate)
                .IsRequired()
                .HasColumnName("PurchaseDate")
                .HasColumnType("DateTime");
        }
    }
}