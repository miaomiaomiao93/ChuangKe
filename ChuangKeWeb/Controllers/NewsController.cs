﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChuangKeWeb.Controllers
{
    public class NewsController : Controller
    {
        //
        // GET: /News/
        public ActionResult News()
        {
            return View();
        }
        public ActionResult NewContent()
        {
            return View();
        }
	}
}