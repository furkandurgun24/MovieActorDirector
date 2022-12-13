using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace MovieActorsDirectors_10052022_5175.Models.Mapping
{
    public class MovieActorsMapping : EntityTypeConfiguration<MovieActors>
    {
        public MovieActorsMapping()
        {
            HasKey(a=> new { a.ActorID,a.MovieID }); // composite key oldukları için
        }
    }
}