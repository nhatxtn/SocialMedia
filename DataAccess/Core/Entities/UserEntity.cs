using DataAccess.Core.Entities.Base;
using Microsoft.AspNetCore.Identity;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace DataAccess.Core.Entities;

public class UserEntity :
    IdentityUser<Guid>,
    IGuidEntity,
    IUpdatedEntity,
    ITemporarilyRemovedEntity
{
    public string FullName { get; set; }

    public string AvatarUrl { get; set; }

    public bool Gender { get; set; }

    public Guid AccountStatusId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public Guid UpdatedBy { get; set; }

    public DateTime RemovedAt { get; set; }

    public Guid RemovedBy { get; set; }

    // Navigation Properties
    public AccountStatusEntity AccountStatus { get; set; }

    /// <summary>
    ///     Represent the list of groups that 
    ///     the current user has joined.
    /// </summary>
    public IEnumerable<GroupMemberEntity> JoinGroupMembers { get; set; }

    /// <summary>
    ///     Represent the list of join-group-request that 
    ///     the current user has created.  
    /// </summary>
    public IEnumerable<JoinGroupRequestEntity> CreatedJoinGroupRequests { get; set; }

    /// <summary>
    ///     Represent the list of user-friend-request that 
    ///     the current user has created.  
    /// </summary>
    public IEnumerable<UserFriendRequestEntity> CreatedFriendRequests { get; set; }
    
    /// <summary>
    ///     Represent the list of user-friend-request that 
    ///     the current user has received from other user.  
    /// </summary>
    public IEnumerable<UserFriendRequestEntity> ReceivedFriendRequests { get; set; }

    /// <summary>
    ///     Represent the list of groups that 
    ///     the current user has created.
    /// </summary>
    public IEnumerable<GroupEntity> CreatedGroups { get; set; }

    /// <summary>
    ///     Represent the list of posts that 
    ///     the current user has created.
    /// </summary>
    public IEnumerable<PostEntity> CreatedPosts { get; set; }

    /// <summary>
    ///     Represent the list of posts that 
    ///     the current user has pinned in their groups.
    /// </summary>
    public IEnumerable<PinPostEntity> UserPinPosts { get; set; }

    /// <summary>
    ///     Represent the list of user-likes that 
    ///     the current user has liked.
    /// </summary>
    public IEnumerable<UserLikePostEntity> UserLikePosts { get; set; }

    /// <summary>
    ///     Represent the list of comments.
    /// </summary>
    public IEnumerable<PostCommentEntity> UserComments { get; set; }

    /// <summary>
    ///     Represent the list of roles that 
    ///     the current user has created.
    /// </summary>
    public IEnumerable<RoleEntity> CreatedRoles { get; set; }

    /// <summary>
    ///     Represent the list of refresh tokens that 
    ///     the current user has.
    /// </summary>
    public IEnumerable<RefreshTokenEntity> RefreshTokens { get; set; }

    #region MetaData
    public static class MetaData
    {
        public const string TableName = "Users";
    }
    #endregion
}
