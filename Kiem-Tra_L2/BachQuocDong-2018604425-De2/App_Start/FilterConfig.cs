using System.Web;
using System.Web.Mvc;

namespace BachQuocDong_2018604425_De2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
