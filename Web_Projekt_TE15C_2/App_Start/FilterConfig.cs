using System.Web;
using System.Web.Mvc;

namespace Web_Projekt_TE15C_2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
