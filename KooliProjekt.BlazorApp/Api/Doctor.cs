﻿using System.ComponentModel.DataAnnotations;

namespace KooliProjekt.BlazorApp
{
    public class Doctor
    {
        public int Id { get; set; }

        [Required]
        [StringLength(10)]
        public string Title { get; set; }
        public string Name { get; set; }

        public string Specialization { get; set; }
    }
}
    