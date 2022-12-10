using System.Text.RegularExpressions;

using WebApp501.Core.Models.Cocktail;

namespace WebApp501.Core.Extensions
{
    public static class ModelExtensions
    {
        public static string GetInformation(this ICocktailModel cocktail)
            => cocktail.Recipe.Replace(" ", "-") + "-" + GetPreparation(cocktail.Preparation);

        private static string GetPreparation(string preparation)
        {
            preparation = string.Join("-", preparation.Split(" ").Take(3));

            return Regex.Replace(preparation, @"[^a-zA-Z0-9\-]", string.Empty);
        }
    }
}