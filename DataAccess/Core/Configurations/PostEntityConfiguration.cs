using DataAccess.Commons.SqlConstants;
using DataAccess.Core.Configurations.Base;
using DataAccess.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Core.Configurations;

public class PostEntityConfiguration : IEntityConfiguration<PostEntity>
{
    public void Configure(EntityTypeBuilder<PostEntity> builder)
    {
        builder.ToTable(PostEntity.MetaData.TableName);

        builder.HasKey(post => post.Id);

        // Properties Configuration.
        builder
            .Property(post => post.Content)
            .HasColumnType(SqlDataTypes.SqlServer.NVARCHAR_MAX)
            .IsRequired();

        builder
            .Property(post => post.GroupId)
            .IsRequired();

        builder
            .Property(post => post.ApprovedAt)
            .HasColumnType(SqlDataTypes.SqlServer.DATETIME2)
            .IsRequired();

        builder
            .Property(post => post.CreatedAt)
            .HasColumnType(SqlDataTypes.SqlServer.DATETIME2)
            .IsRequired();

        builder
            .Property(post => post.CreatedBy)
            .IsRequired();

        builder
            .Property(post => post.UpdatedAt)
            .HasColumnType(SqlDataTypes.SqlServer.DATETIME2)
            .IsRequired();

        // Relationships Configuration.
        builder
            .HasOne(post => post.Creator)
            .WithMany(user => user.CreatedPosts)
            .HasForeignKey(post => post.CreatedBy)
            .OnDelete(DeleteBehavior.NoAction);

        builder
            .HasMany(post => post.PostComments)
            .WithOne(comment => comment.Post)
            .HasPrincipalKey(post => post.Id)
            .HasForeignKey(comment => comment.PostId)
            .OnDelete(DeleteBehavior.Cascade);

        builder
            .HasMany(post => post.AttachedMedias)
            .WithOne(attachMedia => attachMedia.Post)
            .HasPrincipalKey(post => post.Id)
            .HasForeignKey(attachMedia => attachMedia.PostId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}