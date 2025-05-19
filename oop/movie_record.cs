using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    internal class movie_record
    {
        string name;
        string actors;
        string director;
        int views;


        public movie_record(string name, string actors, string director)
        {
            this.name = name;
            this.actors = actors;
            this.director = director;
            this.views = 0;
        }

        public void add_view()
        {
            this.views += 1;
        }

        public void print()
        {
            Console.WriteLine($"name: {this.name} , actors: {this.actors}, director: {this.director}, views: {this.views}");
        }
    }
}
