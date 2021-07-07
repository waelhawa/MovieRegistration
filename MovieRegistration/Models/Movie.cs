using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRegistration.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Exceeded maximum length allowed.")]
        public string Title { get; set; }
        [Required, Range(1, int.MaxValue, ErrorMessage = "Please choose one")]
        public string Genre { get; set; }

        [DateAttribute(ErrorMessage = "Date is not within range year 1880 to now")]
        public DateTime Year { get; set; }
        public string Actors { get; set; }
        public string Directors { get; set; }
    }

}
