using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModel
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }
        [Required]
        public int? Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Display(Name = "Genre")]
        [Required]
        public int? GenreId { get; set; }
        [Required]
        [Display(Name = "Release Date")]
        [DisplayFormat(DataFormatString = "{0:d MMM yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? ReleaseDate { get; set; }
        [Required]
        [Range(1, 20)]
        [Display(Name = "Number in stock")]
        public int? NumberInStock { get; set; }
        //public Movie Movie { get; set; }
        public string Title { get
            {
                return Id != 0 ? "Edit Movie" : "New Movie";
            }
        }
        public MovieFormViewModel()
        {
            Id = 0;
        }
        public MovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            GenreId = movie.GenreId;
            ReleaseDate = movie.ReleaseDate;
            Name = movie.Name;
            NumberInStock = movie.NumberInStock;
        }
        
       
    }
}