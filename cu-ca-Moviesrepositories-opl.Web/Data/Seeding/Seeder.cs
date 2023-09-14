using Microsoft.EntityFrameworkCore;
using Core_MovieShop_opl_Afst_Core.Entities;

namespace Core_MovieShop_opl_Afst.Data.Seeding
{
    public static class Seeder
    {
        public static void Seed(ModelBuilder modelBuilder) 
        {
            //companies
            var companies = new Company[] 
            {
                new Company{Id = 1,Name = "Universal" },
                new Company{Id = 2,Name = "Sony" },
            };
            //Movie
            var movies = new Movie[]
            {
                new Movie{Id = 1, Title = "It",Price = 50.00M, ReleaseDate = DateTime.Now,CompanyId = 1,Image = "It.jpg"},
                new Movie{Id = 2, Title = "Pulp fiction", Price = 55.00M, ReleaseDate = DateTime.Now.AddYears(2),CompanyId = 2, Image = "pulpfiction.jpg"},
                new Movie{Id = 3, Title = "Get shorty", Price = 55.00M, ReleaseDate = DateTime.Now.AddYears(2),CompanyId = 2, Image = "getshorty.jpg"},
                new Movie{Id = 4, Title = "Star wars", Price = 55.00M, ReleaseDate = DateTime.Now.AddYears(2),CompanyId = 2, Image = "starwars.jpg"},
            };
            //users
            var users = new User[]
            {
                new User{Id = 1, Firstname = "Bart", Lastname = "Soete", Username = "bart.soete@movierating.com"},
                new User{Id = 2, Firstname = "Karel", Lastname = "Soete", Username = "karel.soete@movierating.com"},
            };
            //ratings
            var ratings = new Rating[]
            {
                new Rating{Id = 1,Score = 9,UserId = 1,MovieId = 1,Review = "Very good!!"},
                new Rating{Id = 2,Score = 8,UserId = 2,MovieId = 2, Review = "good!!"},
                new Rating{Id = 3,Score = 6,UserId = 2 ,MovieId = 1,Review = "Ok"},
                new Rating{Id = 4,Score = 5,UserId = 1,MovieId = 2,Review = "Average.."},
            };
            //Actors
            var actors = new Actor[] 
            {
                new Actor{Id = 1,Firstname = "Brad", Lastname = "Pitt"},
                new Actor{Id = 2,Firstname = "Julia", Lastname = "Roberts"},
            };
            //Directors
            var directors = new Director[]
            {
                new Director{Id = 1,Firstname = "Martin", Lastname = "Scorsese"},
                new Director{Id = 2,Firstname = "Ron", Lastname = "Wood"},
            };
            //many to manys
            //ActorMovie
            var actorsMovies = new[]
            {
                new {ActorsId = 1, MoviesId = 1 },
                new {ActorsId = 1, MoviesId = 2 },
                new {ActorsId = 2, MoviesId = 1 },
                new {ActorsId = 2, MoviesId = 2 },
                new {ActorsId = 1, MoviesId = 3 },
                new {ActorsId = 1, MoviesId = 4 },
                new {ActorsId = 2, MoviesId = 3 },
                new {ActorsId = 2, MoviesId = 4 },
            };
            //DirectorMovie
            var directorsMovies = new[]
            {
                new {DirectorsId = 1, MoviesId = 1},
                new {DirectorsId = 2, MoviesId = 1},
                new {DirectorsId = 1, MoviesId = 2},
                new {DirectorsId = 2, MoviesId = 2},
                new {DirectorsId = 1, MoviesId = 3},
                new {DirectorsId = 2, MoviesId = 3},
                new {DirectorsId = 1, MoviesId = 4},
                new {DirectorsId = 2, MoviesId = 4},
            };
            //call the hasdata methods
            modelBuilder.Entity<Company>().HasData(companies);
            modelBuilder.Entity<Movie>().HasData(movies);
            modelBuilder.Entity<User>().HasData(users);
            modelBuilder.Entity<Rating>().HasData(ratings);
            modelBuilder.Entity<Actor>().HasData(actors);
            modelBuilder.Entity<Director>().HasData(directors);
            modelBuilder.Entity($"{nameof(Actor)}{nameof(Movie)}").HasData(actorsMovies);
            modelBuilder.Entity($"{nameof(Director)}{nameof(Movie)}").HasData(directorsMovies);
        }
    }
}
