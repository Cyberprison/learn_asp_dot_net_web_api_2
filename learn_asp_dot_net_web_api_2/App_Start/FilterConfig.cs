using System.Web;
using System.Web.Mvc;

namespace learn_asp_dot_net_web_api_2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
