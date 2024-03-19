using DataAccess.Commons.SqlConstants;
using DataAccess.Core.Configurations.Base;
using DataAccess.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Core.Configurations
{
    internal class AttachedPostMediaEntityConfiguration : 
        IEntityConfiguration<AttachedPostMediaEntity>
    {
        public void Configure(EntityTypeBuilder<AttachedPostMediaEntity> builder)
        {
            builder.ToTable(AttachedPostMediaEntity.MetaData.TableName);

            builder.HasKey(attachedMedia => attachedMedia.Id);

            // Properties Configuration.
            builder
                .Property(attachedMedia => attachedMedia.PostId)
                .IsRequired();

            builder
                .Property(attachedMedia => attachedMedia.FileName)
                .HasColumnType(SqlDataTypes.SqlServer.NVARCHAR_200)
                .IsRequired();

            builder
                .Property(attachedMedia => attachedMedia.StorageUrl)
                .HasColumnType(SqlDataTypes.SqlServer.NVARCHAR_200)
                .IsRequired();

            builder
                .Property(attachedMedia => attachedMedia.CreatedAt)
                .HasColumnType(SqlDataTypes.SqlServer.DATETIME2)
                .IsRequired();
        }
    }
}
