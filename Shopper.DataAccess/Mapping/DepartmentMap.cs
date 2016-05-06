using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Shopper.Domain;

namespace Shopper.DataAccess.Mapping
{
    public class DepartmentMap : EntityTypeConfiguration<Department>
    {
        public DepartmentMap()
        {
            ToTable("Department");
            HasKey(t => t.DepartmentId);
            Property(t => t.DepartmentId)
                .IsRequired()
                .HasColumnName("DepartmentId")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnType("INT");
            Property(t => t.DepartmentName)
                .IsRequired()
                .HasColumnName("DepartmentName")
                .HasMaxLength(100)
                .HasColumnType("NVARCHAR");
        }
    }
}