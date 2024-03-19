using DataAccess.Core.Entities.Base;

namespace DataAccess.Core.Entities;

public class GroupEntity : 
    GuidEntity,
    ICreatedEntity
{
    public string Name { get; set; }

    public bool IsPrivate { get; set; } = true;

    public int MemberCount { get; set; }

    public DateTime CreatedAt { get; set; }

    public Guid CreatedBy { get; set; }

    #region Relationships
    public UserEntity Creator { get; set; }

    public IEnumerable<PostEntity> GroupPosts { get; set; }

    public IEnumerable<PinPostEntity> PinPosts { get; set; }

    public IEnumerable<GroupMemberEntity> GroupMembers { get; set; }

    public IEnumerable<JoinGroupRequestEntity> JoinGroupRequests { get; set; }
    #endregion

    #region MetaData
    public static class MetaData
    {
        public const string TableName = "Groups";
    }
    #endregion
}
