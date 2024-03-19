using DataAccess.Core.Entities.Base;

namespace DataAccess.Core.Entities;

public class GroupMemberEntity : IEntity
{
    public Guid MemberId { get; set; }

    public Guid GroupId { get; set; }

    public Guid RoleId { get; set; }

    public DateTime JoinedAt { get; set; }

    // Navigation Properties
    public UserEntity Member { get; set; }

    public GroupEntity Group { get; set; }

    public RoleEntity Role { get; set; }

    #region MetaData
    public static class MetaData
    {
        public const string TableName = "GroupMembers";
    }
    #endregion
}
