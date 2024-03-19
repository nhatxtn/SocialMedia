using DataAccess.Commons.SqlConstants;
using DataAccess.Core.Configurations.Base;
using DataAccess.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Core.Configurations
{
    internal class UserFriendRequestEntityConfiguration :
        IEntityConfiguration<UserFriendRequestEntity>
    {
        public void Configure(EntityTypeBuilder<UserFriendRequestEntity> builder)
        {
            builder.ToTable(UserFriendRequestEntity.MetaData.TableName);

            builder.HasKey(friendRequest => new
            {
                friendRequest.FriendId,
                friendRequest.CreatedBy
            });

            // Properties Configuration.
            builder
                .Property(post => post.CreatedAt)
                .HasColumnType(SqlDataTypes.SqlServer.DATETIME2)
                .IsRequired();

            // Relationships Configuration.
            builder
                .HasOne(friendRequest => friendRequest.Creator)
                .WithMany(creator => creator.CreatedFriendRequests)
                .HasPrincipalKey(creator => creator.Id)
                .HasForeignKey(friendRequest => friendRequest.CreatedBy)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .HasOne(friendRequest => friendRequest.Friend)
                .WithMany(friend => friend.ReceivedFriendRequests)
                .HasPrincipalKey(friend => friend.Id)
                .HasForeignKey(friendRequest => friendRequest.FriendId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
