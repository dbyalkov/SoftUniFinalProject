namespace WebApp501.Infrastructure.Data
{
    /// <summary>
    /// Class holding data constraints.
    /// </summary>
    public class DataConstants
    {
        /// <summary>
        /// Class holding the "Alcohols" constraints.
        /// </summary>
        public class Alcohols
        {
            public const int MaxNameLength = 40;
            public const int MinNameLength = 1;
        }

        /// <summary>
        /// Class holding the "Bartenders" constraints.
        /// </summary>
        public class Bartenders
        {
            public const int MaxFirstNameLength = 30;
            public const int MinFirstNameLength = 1;

            public const int MaxLastNameLength = 30;
            public const int MinLastNameLength = 1;

            public const int MinAge = 18;
        }

        /// <summary>
        /// Class holding the "Cocktails" constraints.
        /// </summary>
        public class Cocktails
        {
            public const int MaxNameLength = 40;
            public const int MinNameLength = 1;

            public const int MaxRecipeLength = 500;
            public const int MinRecipeLength = 1;

            public const int MaxPreparationLength = 2000;
            public const int MinPreparationLength = 1;
        }

        /// <summary>
        /// Class holding the "Glasses" constraints.
        /// </summary>
        public class Glasses
        {
            public const int MaxNameLength = 30;
            public const int MinNameLength = 1;
        }

        /// <summary>
        /// Class holding the "Users" constraints.
        /// </summary>
        public class Users
        {
            public const int MaxMiddleNameLength = 30;
            public const int MinMiddleNameLength = 1;
        }
    }
}