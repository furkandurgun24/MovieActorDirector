using MovieActorsDirectors_10052022_5175.Models.Mapping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MovieActorsDirectors_10052022_5175.Models.Context
{
    public class ProjectContext : DbContext
    {

        public ProjectContext()
        {
            Database.Connection.ConnectionString = @"Server=DESKTOP-MK2OO7R;Database=BlogProjectDb;Trusted_Connection=True;";
        }

        public DbSet<Movie>  Movies { get; set; }
        public DbSet<Actor>  Actors { get; set; }
        public DbSet<Director>  Directors { get; set; }
        public DbSet<MovieActors>  MovieActors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new MovieMapping());
            modelBuilder.Configurations.Add(new MovieActorsMapping());

            base.OnModelCreating(modelBuilder);
        }

    }
}