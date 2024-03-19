using DataAccess.Commons.SqlConstants;
using DataAccess.Core.Configurations.Base;
using DataAccess.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Core.Configurations
{
    internal class JoinGroupRequestEntityConfiguration :
        IEntityConfiguration<JoinGroupRequestEntity>
    {
        public void Configure(EntityTypeBuilder<JoinGroupRequestEntity> builder)
        {
            builder.ToTable(JoinGroupRequestEntity.MetaData.TableName);

            builder.HasKey(joinGroupRequest => joinGroupRequest.Id);

            // Properties Configuration.
            builder
                .Property(joinGroupRequest => joinGroupRequest.GroupId)
                .IsRequired();

            builder
                .Property(joinGroupRequest => joinGroupRequest.CreatedBy)
                .IsRequired();

            builder
                .Property(joinGroupRequest => joinGroupRequest.CreatedAt)
                .HasColumnType(SqlDataTypes.SqlServer.DATETIME2)
                .IsRequired();

            // Relationships Configuration.
            builder
                .HasOne(joinGroupRequest => joinGroupRequest.Creator)
                .WithMany(user => user.CreatedJoinGroupRequests)
                .HasPrincipalKey(user => user.Id)
                .HasForeignKey(joinGroupRequest => joinGroupRequest.CreatedBy)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
