namespace WebApp501.Infrastructure.Data
{
    public class DataConstants
    {
        public class Alcohol
        {
            public const int MaxNameLength = 30;
            public const int MinNameLength = 1;
        }

        public class Cocktail
        {
            public const int MaxNameLength = 40;
            public const int MinNameLength = 1;

            public const int MaxRecipeLength = 100;
            public const int MinRecipeLength = 10;

            public const int MaxPreparationLength = 2000;
            public const int MinPreparationLength = 10;
        }

        public class Glass
        {
            public const int MaxNameLength = 30;
            public const int MinNameLength = 1;
        }
    }
}