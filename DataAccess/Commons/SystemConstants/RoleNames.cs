namespace DataAccess.Commons.SystemConstants
{
    public static class RoleNames
    {
        public const string System = "system";
     
        public const string User = "user";

        public const string GroupMember = "group_member";

        public const string GroupManager = "group_manager";
        
        /// <summary>
        ///     This role is only used for situation
        ///     when one of important role is removed by accident
        ///     and need to recover the consistence quickly.
        /// </summary>
        public const string DoNotRemove = "do_not_remove";
    }
}
