﻿using System.ComponentModel.DataAnnotations;

using static WebApp501.Infrastructure.Data.DataConstants.Alcohol;

namespace WebApp501.Infrastructure.Data.Entities
{
    public class TypeOfAlcohol
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(MaxNameLength)]
        public string Name { get; set; } = null!;

        public IEnumerable<Cocktail> Cocktails { get; set; } = new List<Cocktail>();
    }
}