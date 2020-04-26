using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Filters;

namespace FilterOverrideInMVC.Filters
{
    //This class will not be needed for MVC 5.1 and above. I add this class because MVC 5 does not support OverrideAuthentication.
    public class OverrideAuthenticationFilter : FilterAttribute , IOverrideFilter
    {
        public Type FiltersToOverride
        {
            get
            {
                return typeof(IAuthenticationFilter);
            }
        }
    }
}