namespace MovieActorsDirectors_10052022_5175.Models
{
    public class MovieActors
    {
        // ara tablo olduğudan buradaki anahtarlar zaten  PK.+FK. olacaktır dolayısıyla bir kere daaha BaseClasstan kalıtım alıp satırlara ID vermeye gerek yoktur.
        public int MovieID { get; set; }

        public virtual Movie  Movie { get; set; }

        public int ActorID { get; set; }
        public virtual Actor  Actor { get; set; }
    }
}