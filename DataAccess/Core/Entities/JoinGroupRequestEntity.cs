using DataAccess.Core.Entities.Base;

namespace DataAccess.Core.Entities
{
    public class JoinGroupRequestEntity : 
        GuidEntity,
        ICreatedEntity
    {
        public Guid GroupId { get; set; }

        public DateTime CreatedAt { get; set; }

        public Guid CreatedBy { get; set; }

        #region Relationships
        public GroupEntity Group { get; set; }

        public UserEntity Creator { get; set; }
        #endregion

        #region MetaData
        public static class MetaData
        {
            public const string TableName = "JoinGroupRequests";
        }
        #endregion
    }
}
