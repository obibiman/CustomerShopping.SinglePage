using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shopper.Domain;

namespace Shopper.DataAccess.SqlServer.Mapping
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
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasColumnType("INT");
            Property(t => t.FirstName)
                .IsRequired()
                .HasColumnName("FirstName")
                .HasMaxLength(25)
                .HasColumnType("NVARCHAR");
            Property(t => t.LastName)
                .IsOptional()
                .HasColumnName("LastName")
                .HasMaxLength(50)
                .HasColumnType("NVARCHAR");
        }
    }
}
