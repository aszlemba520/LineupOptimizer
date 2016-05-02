using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace LineupOptimizer.Framework
{
    class LOViewEngine : RazorViewEngine
    {
        public LOViewEngine()
        {
            ViewLocationFormats = new[]
            {
                "~/Mvc/Views/{1}/{0}.cshtml",
                "~/Mvc/Views/Shared/{0}.cshtml"
            };
            MasterLocationFormats = new[]
            {
                "~/Mvc/Views/{1}/{0}.cshtml",
                "~/Mvc/Views/Shared/{0}.cshtml"
            };
            PartialViewLocationFormats = new[]
            {
                "~/Mvc/Views/{1}/{0}.cshtml",
                "~/Mvc/Views/Shared/{0}.cshtml"
            };
        }
    }
}
