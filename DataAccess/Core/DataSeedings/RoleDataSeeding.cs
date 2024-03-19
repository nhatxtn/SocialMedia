using DataAccess.Commons.DataSeedings;
using DataAccess.Commons.SystemConstants;
using DataAccess.Core.DataSeedings.Base;
using DataAccess.Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Core.DataSeedings
{
    internal class RoleDataSeeding : EntityDataSeeding<RoleEntity>
    {
        public override void Configure(EntityTypeBuilder<RoleEntity> builder)
        {
            var seedEntities = GetSeedEntities();

            builder.HasData(seedEntities);
        }

        protected override List<RoleEntity> GetSeedEntities()
        {
            var systemId = DefaultValues.SystemId;
            var dateTimeUtcNow = DateTime.UtcNow;

            var seedEntities = new List<RoleEntity>(capacity: 4)
            {
                new()
                {
                    Id = SeedingValues.Roles.System.Id,
                    Name = SeedingValues.Roles.System.Name,
                    NormalizedName = SeedingValues.Roles.System.Name.ToUpper(),
                    CreatedAt = dateTimeUtcNow,
                    CreatedBy = systemId
                },
                new()
                {
                    Id = SeedingValues.Roles.User.Id,
                    Name = SeedingValues.Roles.User.Name,
                    NormalizedName = SeedingValues.Roles.User.Name.ToUpper(),
                    CreatedAt = dateTimeUtcNow,
                    CreatedBy = systemId
                },
                new()
                {
                    Id = SeedingValues.Roles.GroupMember.Id,
                    Name = SeedingValues.Roles.GroupMember.Name,
                    NormalizedName = SeedingValues.Roles.GroupMember.Name.ToUpper(),
                    CreatedAt = dateTimeUtcNow,
                    CreatedBy = systemId
                },
                new()
                {
                    Id = SeedingValues.Roles.GroupManager.Id,
                    Name = SeedingValues.Roles.GroupManager.Name,
                    NormalizedName = SeedingValues.Roles.GroupManager.Name.ToUpper(),
                    CreatedAt = dateTimeUtcNow,
                    CreatedBy = systemId
                }
            };

            return seedEntities;
        }
    }
}
