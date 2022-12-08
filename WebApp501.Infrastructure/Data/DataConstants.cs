namespace WebApp501.Infrastructure.Data
{
    public class DataConstants
    {
        public class Alcohols
        {
            public const int MaxNameLength = 40;
            public const int MinNameLength = 1;
        }

        public class Bartenders
        {
            public const int MaxFirstNameLength = 30;
            public const int MinFirstNameLength = 1;

            public const int MaxLastNameLength = 30;
            public const int MinLastNameLength = 1;

            public const int MinAge = 18;
        }

        public class Cocktails
        {
            public const int MaxNameLength = 40;
            public const int MinNameLength = 1;

            public const int MaxRecipeLength = 500;
            public const int MinRecipeLength = 1;

            public const int MaxPreparationLength = 2000;
            public const int MinPreparationLength = 1;
        }

        public class Glasses
        {
            public const int MaxNameLength = 30;
            public const int MinNameLength = 1;
        }
    }
}