using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace modul9_1302210128
{
    public class Movie
    {
        public string Title { get; set; }
        public string Director { get; set; }
        public List<string> Stars { get; set; }
        public string description { get; set; }

        public Movie(string Title, string Director, List<string> Stars, string description)
        {
            this.Title = Title;
            this.Director = Director;
            this.Stars = Stars;
            this.description = description;
        }
    }

}
