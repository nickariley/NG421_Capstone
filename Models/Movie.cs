using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace capstone.Models
{
    public class Movie
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public string MovieTitle { get; set; }
        public string Genre { get; set; }
        public DateTime ReleaseDate { get; set; }
        public Boolean Watched { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}
