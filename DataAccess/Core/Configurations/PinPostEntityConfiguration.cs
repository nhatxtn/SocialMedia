using DataAccess.Commons.SqlConstants;
using DataAccess.Core.Configurations.Base;
using DataAccess.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Core.Configurations
{
    internal class PinPostEntityConfiguration :
        IEntityConfiguration<PinPostEntity>
    {
        public void Configure(EntityTypeBuilder<PinPostEntity> builder)
        {
            builder.ToTable(PinPostEntity.MetaData.TableName);

            builder.HasKey(pinPost => new
            {
                pinPost.GroupId,
                pinPost.PostId,
                pinPost.CreatedBy
            });

            // Properties Configuration.
            builder
                .Property(pinPost => pinPost.CreatedAt)
                .HasColumnType(SqlDataTypes.SqlServer.DATETIME2)
                .IsRequired();

            // Relationships Configuration.
            builder
                .HasOne(pinPost => pinPost.Group)
                .WithMany(group => group.PinPosts)
                .HasPrincipalKey(group => group.Id)
                .HasForeignKey(pinPost => pinPost.GroupId)
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasOne(pinPost => pinPost.Post)
                .WithMany(group => group.PinPosts)
                .HasPrincipalKey(post => post.Id)
                .HasForeignKey(pinPost => pinPost.GroupId)
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasOne(pinPost => pinPost.Creator)
                .WithMany(group => group.UserPinPosts)
                .HasPrincipalKey(user => user.Id)
                .HasForeignKey(pinPost => pinPost.CreatedBy)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
