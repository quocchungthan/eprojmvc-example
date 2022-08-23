﻿using System.ComponentModel.DataAnnotations;

namespace eprojectinstruct.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}