﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcademyCRM.Controllers
{
    public class AccountController : Controller
    {
        [HttpPost]
        public IActionResult LoginPartial()
        {
            return View();
        }
    }
}