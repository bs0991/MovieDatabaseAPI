using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string title { get; set; }
        public DateTime releaseDate { get; set; }
    }
}
