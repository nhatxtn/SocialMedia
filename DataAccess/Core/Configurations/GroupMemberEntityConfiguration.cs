using DataAccess.Commons.SqlConstants;
using DataAccess.Core.Configurations.Base;
using DataAccess.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Core.Configurations
{
    internal class GroupMemberEntityConfiguration :
        IEntityConfiguration<GroupMemberEntity>
    {
        public void Configure(EntityTypeBuilder<GroupMemberEntity> builder)
        {
            builder.ToTable(name: GroupMemberEntity.MetaData.TableName);

            builder.HasKey(keyExpression: groupMember => new
            {
                groupMember.MemberId,
                groupMember.GroupId,
            });

            // Properties Configuration
            builder
                .Property(groupMember => groupMember.JoinedAt)
                .HasColumnType(SqlDataTypes.SqlServer.DATETIME2)
                .IsRequired();

            // Relationships Configuration
            builder
                .HasOne(navigationExpression: groupMember => groupMember.Member)
                .WithMany(navigationExpression: member => member.JoinGroupMembers)
                .HasForeignKey(foreignKeyExpression: groupMember => groupMember.MemberId)
                .OnDelete(deleteBehavior: DeleteBehavior.Cascade);

            builder
                .HasOne(navigationExpression: groupMember => groupMember.Group)
                .WithMany(navigationExpression: group => group.GroupMembers)
                .HasForeignKey(foreignKeyExpression: groupMember => groupMember.GroupId)
                .OnDelete(deleteBehavior: DeleteBehavior.Cascade);

            builder
                .HasOne(navigationExpression: groupMember => groupMember.Role)
                .WithMany(navigationExpression: group => group.GroupMembers)
                .HasForeignKey(foreignKeyExpression: groupMember => groupMember.RoleId)
                .OnDelete(deleteBehavior: DeleteBehavior.NoAction);
        }
    }
}
