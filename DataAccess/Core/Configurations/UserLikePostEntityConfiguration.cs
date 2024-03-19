using DataAccess.Commons.SqlConstants;
using DataAccess.Core.Configurations.Base;
using DataAccess.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Core.Configurations
{
    internal class UserLikePostEntityConfiguration :
        IEntityConfiguration<UserLikePostEntity>
    {
        public void Configure(EntityTypeBuilder<UserLikePostEntity> builder)
        {
            builder.ToTable(UserLikePostEntity.MetaData.TableName);

            builder.HasKey(userLike => new
            {
                userLike.UserId,
                userLike.PostId,
            });

            // Properties Configuration.
            builder
                .Property(userLike => userLike.Value)
                .HasColumnType(SqlDataTypes.SqlServer.NVARCHAR_200)
                .IsRequired();

            builder
                .Property(userLike => userLike.LikedAt)
                .HasColumnType(SqlDataTypes.SqlServer.DATETIME2)
                .IsRequired();

            // Relationships Configuration.
            builder
                .HasOne(userLike => userLike.User)
                .WithMany(user => user.UserLikePosts)
                .HasPrincipalKey(user => user.Id)
                .HasForeignKey(userLike => userLike.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasOne(userLike => userLike.Post)
                .WithMany(post => post.UserLikePosts)
                .HasPrincipalKey(post => post.Id)
                .HasForeignKey(userLike => userLike.PostId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
