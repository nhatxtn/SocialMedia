using DataAccess.Core.Entities.Base;

namespace DataAccess.Core.Entities;

public class PostEntity : 
    GuidEntity,
    ICreatedEntity
{
    public string Content { get; set; }

    public int NumberOfLikes { get; set; }

    public Guid GroupId { get; set; }

    public bool IsApproved { get; set; }

    public DateTime ApprovedAt { get; set; }

    public DateTime CreatedAt { get; set; }

    public Guid CreatedBy { get; set; }

    public DateTime UpdatedAt { get; set; }

    #region Relationships
    public GroupEntity Group { get; set; }

    public UserEntity Creator { get; set; }

    public IEnumerable<AttachedPostMediaEntity> AttachedMedias { get; set; }

    public IEnumerable<UserLikePostEntity> UserLikePosts { get; set; }

    public IEnumerable<PinPostEntity> PinPosts { get; set; }

    public IEnumerable<PostCommentEntity> PostComments { get; set; }
    #endregion

    #region MetaData
    public static class MetaData
    {
        public const string TableName = "Posts";
    }
    #endregion
}