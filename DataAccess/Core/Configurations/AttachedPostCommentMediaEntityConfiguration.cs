using DataAccess.Commons.SqlConstants;
using DataAccess.Core.Configurations.Base;
using DataAccess.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Core.Configurations
{
    internal class AttachedPostCommentMediaEntityConfiguration :
        IEntityConfiguration<AttachedPostCommentMediaEntity>
    {
        public void Configure(EntityTypeBuilder<AttachedPostCommentMediaEntity> builder)
        {
            builder.ToTable(AttachedPostCommentMediaEntity.MetaData.TableName);

            builder.HasKey(attachedMedia => attachedMedia.Id);

            // Properties Configuration.
            builder
                .Property(attachedMedia => attachedMedia.PostCommentId)
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
