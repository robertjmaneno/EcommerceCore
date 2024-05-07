﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("Display Name")]
        [MaxLength(20, ErrorMessage ="The maximum length must be less than 20")]
        public required string Name { get; set; }
        [DisplayName("Display Order")]
       [Range(0, 100, ErrorMessage ="The display order must range from 0 to 100")]
        public int DisplayOrder { get; set; }
    }
}
