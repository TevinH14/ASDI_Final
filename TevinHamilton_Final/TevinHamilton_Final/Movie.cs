using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TevinHamilton_Final
{
    class Movie
    {
        public string Titel { get; set; }
        public string Director { get; set; }
        public decimal Cost { get; set; }
        public Movie(string titel,string director,decimal cost)
        {
            Titel = titel;
            Director = director;
            Cost = cost;
            Console.WriteLine("movie created");
        }
        public string ToString()
        {
            return $"Titel:{Titel}, Director: {Director}, Cost: {Cost.ToString()} ";
        }
    }
}
