﻿using System.Web.Mvc;

namespace MvcApplication
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());

			filters.Add(new CustomActionFilter());
		}
	}
}
