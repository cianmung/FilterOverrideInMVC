using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FilterOverrideInMVC.Filters
{
    public class CustomAuthorizationFilter : FilterAttribute , IAuthorizationFilter 
    {
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            if (string.IsNullOrEmpty(Convert.ToString(filterContext.HttpContext.Session["UserID"])))
            {
                filterContext.Result = new ViewResult
                {
                    ViewName = "Error"
                };
            }
        }
    }
}