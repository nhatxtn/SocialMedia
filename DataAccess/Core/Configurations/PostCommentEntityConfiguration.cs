using DataAccess.Commons.SqlConstants;
using DataAccess.Core.Configurations.Base;
using DataAccess.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Core.Configurations
{
    internal class PostCommentEntityConfiguration :
        IEntityConfiguration<PostCommentEntity>
    {
        public void Configure(EntityTypeBuilder<PostCommentEntity> builder)
        {
            builder.ToTable(PostCommentEntity.MetaData.TableName);

            builder.HasKey(postComment => postComment.Id);

            // Properties Configuration.
            builder
                .Property(postComment => postComment.Content)
                .HasColumnType(SqlDataTypes.SqlServer.NVARCHAR_MAX)
                .IsRequired();

            builder
                .Property(postComment => postComment.PostId)
                .IsRequired();

            builder
                .Property(group => group.CreatedAt)
                .HasColumnType(SqlDataTypes.SqlServer.DATETIME2)
                .IsRequired();

            builder
                .Property(group => group.CreatedBy)
                .IsRequired();

            builder
                .Property(group => group.UpdatedAt)
                .HasColumnType(SqlDataTypes.SqlServer.DATETIME2)
                .IsRequired();

            // Relationships Configuration
            builder
                .HasOne(comment => comment.Creator)
                .WithMany(creator => creator.UserComments)
                .HasForeignKey(comment => comment.CreatedBy)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .HasMany(comment => comment.AttachedMedias)
                .WithOne(attachMedia => attachMedia.PostComment)
                .HasPrincipalKey(comment => comment.Id)
                .HasForeignKey(attachMedia => attachMedia.PostCommentId)
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasMany(comment => comment.ChildComments)
                .WithOne(childComment => childComment.ParentComment)
                .HasPrincipalKey(parentComment => parentComment.Id)
                .HasForeignKey(childComment => childComment.ParentCommentId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
