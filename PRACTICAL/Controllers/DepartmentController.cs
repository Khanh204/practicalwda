﻿using Microsoft.AspNetCore.Mvc;

namespace PRACTICAL.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
