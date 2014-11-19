using System.Globalization;
using System.Threading;
using System.Web.Mvc;

namespace WhenIsItFriday
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new LocalizationAttribute());
        }
    }

    public class LocalizationAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var culture = (string)filterContext.RouteData.Values["culture"];
            if (!string.IsNullOrEmpty(culture))
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);
        }
    }
}
