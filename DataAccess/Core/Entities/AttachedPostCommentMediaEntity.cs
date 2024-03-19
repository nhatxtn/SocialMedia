using DataAccess.Core.Entities.Base;

namespace DataAccess.Core.Entities
{
    public class AttachedPostCommentMediaEntity : 
        AttachedMediaEntity
    {
        public Guid PostCommentId { get; set; }

        #region Relationships
        public PostCommentEntity PostComment { get; set; }
        #endregion

        #region MetaData
        public static class MetaData
        {
            public const string TableName = "AttachedPostCommentMedias";
        }
        #endregion
    }
}
