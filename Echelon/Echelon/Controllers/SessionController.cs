﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Echelon.Controllers
{
    public class SessionController : Controller
    {
        public IActionResult Home()
        {
            return View();
        }

    }
}