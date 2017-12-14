using System.Web;
using System.Web.Mvc;

namespace SHOPPSTER_WEBSITE
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
