using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public enum Genre { Action, Comedy, Drama, Horror }

    public class AddMovie
    {
        public int MovieID { get; set; }
        public string Name { get; set; }
        public decimal Cost { get; set; }
        public string Actors { get; set; }
        public string Director { get; set; }
        public string Times { get; set; }
        public string Rating { get; set; }
        public Genre TypeOfGenre { get; set; }
        public string ImageName { get; set; }

        public int CinemaID { get; set; }
        public virtual Cinema Cinema { get; set; }
    }

    public class Cinema
    {
        public int CinemaID { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Website { get; set; }

        public virtual List<AddMovie> AddMovie { get; set; }
    }

    public class CinemaData : DbContext
    {
        public CinemaData() : base("AddMovie") { }

        public DbSet<AddMovie> AddMovies { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
    }
}
