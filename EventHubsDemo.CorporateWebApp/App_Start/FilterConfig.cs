using System.Web;
using System.Web.Mvc;

namespace EventHubsDemo.CorporateWebApp
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
