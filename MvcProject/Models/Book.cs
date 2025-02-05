﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MvcProject.Models
{

    [Table("Book")]
    public class Book
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
         public string? BookName { get; set; }

        [Required]
        [MaxLength(50)]
        public string? AuthorName { get; set; }


        public double? Price { get; set; }
        public string? Image {  get; set; }

        [Required]
        public int? GenreId { get; set; }

        public Genre Genre { get; set; }

        public List<CartDetail> CartDetail { get; set; }

        [NotMapped]

        public string GenreName { get; set; }
    }
}
