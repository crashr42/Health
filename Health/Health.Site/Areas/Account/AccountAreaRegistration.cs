﻿using System.Web.Mvc;

namespace Health.Site.Areas.Account
{
    public class AccountAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get { return "Account"; }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Account_default",
                "Account/{controller}/{action}",
                new {controller = "Home", action = "Index"}
                );
        }
    }
}