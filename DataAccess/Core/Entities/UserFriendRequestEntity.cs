using DataAccess.Core.Entities.Base;

namespace DataAccess.Core.Entities
{
    public class UserFriendRequestEntity : IEntity, ICreatedEntity
    {
        public Guid FriendId { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreatedAt { get; set; }

        public bool IsAccepted { get; set; } = false;

        #region Relationships
        public UserEntity Creator { get; set; }

        public UserEntity Friend { get; set; }
        #endregion

        #region MetaData
        public static class MetaData
        {
            public const string TableName = "UserFriendRequests";
        }
        #endregion
    }
}
