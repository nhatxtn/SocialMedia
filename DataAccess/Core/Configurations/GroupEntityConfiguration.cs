using DataAccess.Commons.SqlConstants;
using DataAccess.Commons.SystemConstants;
using DataAccess.Core.Configurations.Base;
using DataAccess.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Core.Configurations;

internal class GroupEntityConfiguration :
    IEntityConfiguration<GroupEntity>
{
    public void Configure(EntityTypeBuilder<GroupEntity> builder)
    {
        builder.ToTable(name: GroupEntity.MetaData.TableName);

        builder.HasKey(keyExpression: group => group.Id);
        
        // Properties Configuration,
        builder
            .Property(group => group.Name)
            .HasColumnType(SqlDataTypes.SqlServer.NVARCHAR_200)
            .IsRequired();

        builder
            .Property(group => group.CreatedAt)
            .HasColumnType(SqlDataTypes.SqlServer.DATETIME2)
            .IsRequired();

        builder
            .Property(group => group.CreatedBy)
            .IsRequired();

        // Relationships Configuration
        builder
            .HasOne(group => group.Creator)
            .WithMany(creator => creator.CreatedGroups)
            .HasForeignKey(group => group.CreatedBy)
            .OnDelete(DeleteBehavior.NoAction);

        builder
            .HasMany(group => group.GroupPosts)
            .WithOne(post => post.Group)
            .HasPrincipalKey(group => group.Id)
            .HasForeignKey(post => post.GroupId)
            .OnDelete(DeleteBehavior.NoAction);

        builder
            .HasMany(group => group.GroupMembers)
            .WithOne(groupMember => groupMember.Group)
            .HasPrincipalKey(group => group.Id)
            .HasForeignKey(groupMember => groupMember.GroupId)
            .OnDelete(DeleteBehavior.Cascade);

        builder
            .HasMany(group => group.JoinGroupRequests)
            .WithOne(joinRequest => joinRequest.Group)
            .HasPrincipalKey(group => group.Id)
            .HasForeignKey(joinRequest => joinRequest.GroupId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
