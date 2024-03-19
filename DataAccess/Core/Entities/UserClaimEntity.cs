using DataAccess.Core.Entities.Base;
using Microsoft.AspNetCore.Identity;

namespace DataAccess.Core.Entities
{
    public class UserClaimEntity :
        IdentityUserClaim<Guid>,
        IEntity
    {
        #region MetaData
        public static class MetaData
        {
            public const string TableName = "UserClaims";
        }
        #endregion
    }
}
