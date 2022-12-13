using System.Web;
using System.Web.Mvc;

namespace MovieActorsDirectors_10052022_5175
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
