using DataAccess.Core.Entities.Base;
using Microsoft.AspNetCore.Identity;

namespace DataAccess.Core.Entities
{
    public class UserLoginEntity :
        IdentityUserLogin<Guid>,
        IEntity
    {
        #region MetaData
        public static class MetaData
        {
            public const string TableName = "UserLogins";
        }
        #endregion
    }
}
