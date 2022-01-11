using System.Web;
using System.Web.Mvc;

namespace NguyenTrongCuong_2018604343_proj7
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
