using System.Web;
using System.Web.Mvc;

namespace MVC_BootStrap_TourExample
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
