using DataAccess.Core.Configurations.Base;
using DataAccess.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Core.Configurations
{
    internal class ParentChildPostCommentEntityConfiguration :
        IEntityConfiguration<ParentChildPostCommentEntity>
    {
        public void Configure(EntityTypeBuilder<ParentChildPostCommentEntity> builder)
        {
            builder.ToTable(ParentChildPostCommentEntity.MetaData.TableName);

            builder.HasKey(parentChildComment => new
            {
                parentChildComment.ParentCommentId,
                parentChildComment.ChildCommentId
            });
        }
    }
}
