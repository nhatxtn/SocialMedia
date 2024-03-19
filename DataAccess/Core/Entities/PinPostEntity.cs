using DataAccess.Core.Entities.Base;

namespace DataAccess.Core.Entities
{
    public class PinPostEntity : 
        IEntity,
        ICreatedEntity
    {
        public Guid GroupId { get; set; }

        public Guid PostId { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreatedAt { get; set; }

        #region Relationships
        public UserEntity Creator { get; set; }

        public GroupEntity Group { get; set; }

        public PostEntity Post { get; set; }
        #endregion

        #region MetaData
        public static class MetaData
        {
            public const string TableName = "PinPosts";
        }
        #endregion
    }
}
