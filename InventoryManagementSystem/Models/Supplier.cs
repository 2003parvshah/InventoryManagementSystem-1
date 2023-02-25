﻿using System.ComponentModel.DataAnnotations;

namespace InventoryManagementSystem.Models
{
    public class Supplier
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Principal { get; set; }
    }
}
