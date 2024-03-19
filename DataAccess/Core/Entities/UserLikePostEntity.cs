using DataAccess.Core.Entities.Base;

namespace DataAccess.Core.Entities
{
    public class UserLikePostEntity : IEntity
    {
        public Guid UserId { get; set; }

        public Guid PostId { get; set; }

        public string Value { get; set; }

        public DateTime LikedAt { get; set; }

        #region Relationships
        public UserEntity User { get; set; }

        public PostEntity Post { get; set; }
        #endregion

        #region MetaData
        public static class MetaData
        {
            public const string TableName = "UserLikePosts";
        }
        #endregion
    }
}
