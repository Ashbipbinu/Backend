﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleBlog.Controllers
{
    public class AuthController : Controller
    {
       public ActionResult Login()
        {
            return Content("This is login");
        }
    }
}