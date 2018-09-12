using System;
using System.ComponentModel.DataAnnotations.Schema;


namespace RazorPagesMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public int Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int Genre { get; set; }
        public int Price { get; set; }

    }
}
