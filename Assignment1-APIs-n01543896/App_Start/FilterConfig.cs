using System.Web;
using System.Web.Mvc;

namespace Assignment1_APIs_n01543896 {
    public class FilterConfig {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters) {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
