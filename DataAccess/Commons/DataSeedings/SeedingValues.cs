using DataAccess.Commons.SystemConstants;

namespace DataAccess.Commons.DataSeedings
{
    public static class SeedingValues
    {
        // Roles section
        public static class Roles
        {
            public static class System
            {
                public static readonly Guid Id = DefaultValues.SystemId;

                public const string Name = RoleNames.System;
            }

            public static class DoNotRemove
            {
                public static readonly Guid Id = new("3120575b-9f22-4330-9f73-8ac89ba3a15c");

                public const string Name = RoleNames.DoNotRemove;
            }

            public static class User
            {
                public static readonly Guid Id = new("cc751bfc-77b9-4a97-85d4-c88e1f3db4de");

                public const string Name = RoleNames.User;
            }

            public static class GroupMember
            {
                public static readonly Guid Id = new("c4cc80c2-c5b1-4852-8f32-f59c6d5b2213");

                public const string Name = RoleNames.GroupMember;
            }

            public static class GroupManager
            {
                public static readonly Guid Id = new("2d92a50b-6d0a-46f1-9f55-53de6b585600");

                public const string Name = RoleNames.GroupManager;
            }
        }

        public static class AccountStatuses
        {
            /// <summary>
            ///     Represent for the pending-to-confirm status.
            /// </summary>
            public static class Pending
            {
                public static readonly Guid Id = new("2d92a50b-6d0a-46f1-9f55-53de6b585600");

                public const string Name = "Pending";
            }

            /// <summary>
            ///     Represent for the email-confirmed-success status.
            /// </summary>
            public static class EmailConfirmed
            {
                public static readonly Guid Id = new("cc751bfc-77b9-4a97-85d4-c88e1f3db4de");

                public const string Name = "EmailConfirmed";
            }

            public static class Banned
            {
                public static readonly Guid Id = new("c4cc80c2-c5b1-4852-8f32-f59c6d5b2213");

                public const string Name = "Banned";
            }
        }

        // Users section
        public static class Users
        {
            /// <summary>
            ///     Represent for the user account of the system.
            /// </summary>
            public static class System
            {
                public static readonly Guid Id = DefaultValues.SystemId;
            }
        }
    }
}
