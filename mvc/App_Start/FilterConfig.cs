using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace mvc
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            //NOTE - remove XML formatter / no xml
            var formatters = GlobalConfiguration.Configuration.Formatters;
            formatters.Remove(formatters.XmlFormatter);

            filters.Add(new HandleErrorAttribute());
        }
    }
}
