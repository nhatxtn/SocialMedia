using DataAccess.Core.Entities.Base;

namespace DataAccess.Core.Entities
{
    public class AttachedPostMediaEntity :
        AttachedMediaEntity
    {
        public Guid PostId { get; set; }

        #region Relationships
        public PostEntity Post { get; set; }
        #endregion

        #region MetaData
        public static class MetaData
        {
            public const string TableName = "AttachedPostMedias";
        }
        #endregion
    }
}
