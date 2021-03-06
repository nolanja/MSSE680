using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NewCustomerIntegration2.Models.Mapping
{
    public class SiteMap : EntityTypeConfiguration<Site>
    {
        public SiteMap()
        {
            // Primary Key
            this.HasKey(t => t.SiteId);

            // Properties
            this.Property(t => t.SiteName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.SiteCode)
                .HasMaxLength(50);

            this.Property(t => t.CreatedBy)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.ModifiedBy)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Site");
            this.Property(t => t.SiteId).HasColumnName("SiteId");
            this.Property(t => t.OrganizationId).HasColumnName("OrganizationId");
            this.Property(t => t.SiteTypeId).HasColumnName("SiteTypeId");
            this.Property(t => t.SiteName).HasColumnName("SiteName");
            this.Property(t => t.SiteCode).HasColumnName("SiteCode");
            this.Property(t => t.TimeZoneId).HasColumnName("TimeZoneId");
            this.Property(t => t.CreatedDateTime).HasColumnName("CreatedDateTime");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.ModifiedDateTime).HasColumnName("ModifiedDateTime");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
        }
    }
}
