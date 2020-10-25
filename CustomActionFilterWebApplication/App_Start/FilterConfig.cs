using CustomActionFilterWebApplication.Filters;
using System.Web.Http.Filters;

namespace CustomActionFilterWebApplication
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(HttpFilterCollection filters)
        {
            filters.Add(new CustomFilter());
            filters.Add(new RequestTimingFilter());
            filters.Add(new CustomExceptionFilter());
        }
    }
}
