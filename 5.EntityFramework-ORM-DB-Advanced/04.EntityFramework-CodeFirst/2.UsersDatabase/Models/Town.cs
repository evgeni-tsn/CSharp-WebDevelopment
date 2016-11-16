﻿using System.ComponentModel.DataAnnotations;

namespace _2.UsersDatabase.Models
{
    public class Town
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string CountryName { get; set; }
    }
}