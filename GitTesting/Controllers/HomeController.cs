﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GitTesting.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			ViewBag.Title = "Home Page";

			return View();
		}

		public ActionResult Reload()
		{
			return View();
		}
		public ActionResult Reload1()
		{
			return View();
		}

		public ActionResult Reload2()
		{
			return View();
		}
	}
}
