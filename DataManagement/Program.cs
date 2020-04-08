using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project;

namespace DataManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            CinemaData db = new CinemaData();

            using (db)
            {
                
                //Create Cinema Objects
                Cinema c1 = new Cinema() { CinemaID = 1, Name = "Sligo Omniplex", Location = "Sligo", Website = "https://www.omniplex.ie/cinema/sligo" };
                Cinema c2 = new Cinema() { CinemaID = 2, Name = "IMC Ballina", Location = "Ballina", Website = "https://www.imccinemas.ie/Whats-On/Ballina" };
                Cinema c3 = new Cinema() { CinemaID = 3, Name = "Mayo Movie World", Location = "Castlebar", Website = "http://www.mayomovieworld.ie/" };
                Cinema c4 = new Cinema() { CinemaID = 4, Name = "IMC Galway", Location = "Galway", Website = "https://www.imccinemas.ie/Film-Times/Galway/" };

                //Create Movie Objects
                AddMovie m1 = new AddMovie()
                {
                    MovieID = 1,
                    Name = "Onward",
                    Cost = 8m,
                    Actors = "Tom Holland, Chris Pratt, Julia Louis-Dreyfus",
                    Director = "Dan Scanlon",
                    Times = "14:00, 17:30",
                    Rating = "PG",
                    TypeOfGenre = Genre.Comedy,
                    ImageName = "Onward.jpg",
                    CinemaID = 1,
                    Cinema = c1
                };

                AddMovie m2 = new AddMovie()
                {
                    MovieID = 2,
                    Name = "A Quiet Place Part II",
                    Cost = 8m,
                    Actors = "Emily Blunt, Millicent Simmonds, Cillian Murphy",
                    Director = "John Krasinski",
                    Times = "18:00, 20:30",
                    Rating = "PG-13",
                    TypeOfGenre = Genre.Horror,
                    ImageName = "AQuietPlace.jpg",
                    CinemaID = 2,
                    Cinema = c2
                };

                AddMovie m3 = new AddMovie()
                {
                    MovieID = 3,
                    Name = "The Way Back",
                    Cost = 8m,
                    Actors = "Ben Affleck, Al Madrigal, Janina Gavankar",
                    Director = "Gavin O'Connor",
                    Times = "15:30, 18:30",
                    Rating = "R",
                    TypeOfGenre = Genre.Drama,
                    ImageName = "TheWayBack.jpg",
                    CinemaID = 3,
                    Cinema = c3
                };

                AddMovie m4 = new AddMovie()
                {
                    MovieID = 4,
                    Name = "Bloodshot",
                    Cost = 8m,
                    Actors = "Vin Diesel, Eiza Ginzalez, Sam Heughan",
                    Director = "Dave Wilson",
                    Times = "16:00, 20:00",
                    Rating = "PG-13",
                    TypeOfGenre = Genre.Action,
                    ImageName = "Bloodshot.jpg",
                    CinemaID = 4,
                    Cinema = c4
                };

                AddMovie m5 = new AddMovie()
                {
                    MovieID = 5,
                    Name = "Bird of Prey",
                    Cost = 8m,
                    Actors = "Margot Robbie, Rosie Perez, Mary Elizabeth Winstead",
                    Director = "Cathy Yan",
                    Times = "14:30, 19:00",
                    Rating = "R",
                    TypeOfGenre = Genre.Action,
                    ImageName = "BirdsOfPrey.jpg",
                    CinemaID = 1,
                    Cinema = c1
                };

                AddMovie m6 = new AddMovie()
                {
                    MovieID = 6,
                    Name = "Downhill",
                    Cost = 8m,
                    Actors = "Julia Louis-Dreyfus, Will Ferrell, Miranda Otto",
                    Director = "Nat Faxon, Jim Rash",
                    Times = "14:00, 19:30",
                    Rating = "R",
                    TypeOfGenre = Genre.Comedy,
                    ImageName = "Downhill.jpg",
                    CinemaID = 2,
                    Cinema = c2
                };

                //Add Cinemas to the database
                db.Cinemas.Add(c1);
                db.Cinemas.Add(c2);
                db.Cinemas.Add(c3);
                db.Cinemas.Add(c4);

                Console.WriteLine("Added Cinemas to the Database");

                //Add movies to the database
                db.AddMovies.Add(m1);
                db.AddMovies.Add(m2);
                db.AddMovies.Add(m3);
                db.AddMovies.Add(m4);
                db.AddMovies.Add(m5);
                db.AddMovies.Add(m6);

                Console.WriteLine("Added Movies to Database");

                //Save changes to the database
                db.SaveChanges();

                Console.WriteLine("Saved to Database");
            }
        }
    }
}
