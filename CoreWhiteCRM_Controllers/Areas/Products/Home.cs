﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace CoreWhiteCRM_Controllers.Areas.Products
{
    public class Home : Controller
    {
        public ActionResult Index() {
            return View();
        }
    }
}
