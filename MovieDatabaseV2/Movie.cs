using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDatabaseLab
{
    internal class Movie
    {
        //properties
        public string Title;
        public string Category;

        //constructor
        public Movie(string _title, string _category)
        {
            Title = _title;
            Category = _category;
        }
    }
}
