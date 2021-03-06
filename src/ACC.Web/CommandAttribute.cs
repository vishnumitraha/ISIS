﻿using System;
using System.Web.Mvc;

namespace ACC.Web
{

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, Inherited = true, AllowMultiple = false)]
    public class CommandAttribute : ActionFilterAttribute
    {

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            var filter = new CommandFilter();
            filter.OnActionExecuted(filterContext);
        }

    }

}
