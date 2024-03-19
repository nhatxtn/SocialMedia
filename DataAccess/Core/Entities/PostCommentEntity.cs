using DataAccess.Core.Entities.Base;

namespace DataAccess.Core.Entities;

public class PostCommentEntity :
    GuidEntity,
    ICreatedEntity
{
    public string Content { get; set; }

    public Guid PostId { get; set; }

    public bool IsDirectlyComment { get; set; }

    public DateTime CreatedAt { get; set; }

    public Guid CreatedBy { get; set; }

    public DateTime UpdatedAt { get; set; }

    #region Relationships
    public PostEntity Post { get; set; }

    public UserEntity Creator { get; set; }

    public IEnumerable<AttachedPostCommentMediaEntity> AttachedMedias { get; set; }

    public IEnumerable<ParentChildPostCommentEntity> ChildComments { get; set; }
    #endregion

    #region MetaData
    public static class MetaData
    {
        public const string TableName = "PostComments";
    }
    #endregion
}
