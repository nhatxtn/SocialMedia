using DataAccess.Core.Entities.Base;

namespace DataAccess.Core.Entities
{
    public class ParentChildPostCommentEntity : IEntity
    {
        public Guid ParentCommentId { get; set; }

        public Guid ChildCommentId { get; set; }

        #region Relationships
        public PostCommentEntity ParentComment { get; set; }
        #endregion

        #region MetaData
        public static class MetaData
        {
            public const string TableName = "ParentChildPostComments";
        }
        #endregion
    }
}
