using Microsoft.AspNetCore.Mvc.Rendering;

namespace han2_print_studio
{
    public static class HtmlHelperExtensions
    {
        public static string ActiveClass(this IHtmlHelper htmlHelper, string route)
        {
            var routeData = htmlHelper.ViewContext.RouteData;

            var pageRoute = routeData.Values["page"]?.ToString()?.ToLower();

            if (string.IsNullOrEmpty(pageRoute))
                return "";

            var split = pageRoute.Split("/");
            var splitRoute = split[1];

            return splitRoute == route ? "active" : "";
        }
    }
}
