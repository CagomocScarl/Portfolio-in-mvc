using System.Web;
using System.Web.Mvc;

namespace Week2_Cagomoc_IPT102
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
