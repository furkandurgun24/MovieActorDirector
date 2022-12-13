using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace MovieActorsDirectors_10052022_5175.Models.Mapping
{
    public class MovieMapping : EntityTypeConfiguration<Movie>
    {
        public MovieMapping()
        {
            HasKey(a=>a.ID);
            Property(a => a.MovieName).HasMaxLength(80).IsRequired();
            // director ilişkisini söylemek isteresk
            HasRequired(a => a.Director).WithMany(a => a.Movies).HasForeignKey(a => a.DirectorID);
        }
    }
}