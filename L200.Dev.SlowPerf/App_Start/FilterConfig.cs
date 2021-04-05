using System.Web;
using System.Web.Mvc;

namespace L200.Dev.SlowPerf
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
