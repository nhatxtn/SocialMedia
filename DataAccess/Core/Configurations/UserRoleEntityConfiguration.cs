using DataAccess.Core.Configurations.Base;
using DataAccess.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Core.Configurations
{
    internal class UserRoleEntityConfiguration :
        IEntityConfiguration<UserRoleEntity>
    {
        public void Configure(EntityTypeBuilder<UserRoleEntity> builder)
        {
            builder.ToTable(UserRoleEntity.MetaData.TableName);
        }
    }
}
