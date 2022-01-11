using System.Web;
using System.Web.Mvc;

namespace BachQuocDong_425_16762
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
