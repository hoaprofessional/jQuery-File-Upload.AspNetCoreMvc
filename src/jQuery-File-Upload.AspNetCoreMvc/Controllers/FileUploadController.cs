﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace jQuery_File_Upload.AspNetCoreMvc.Controllers
{
    public class FileUploadController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Upload()
        {
            return Json(new { success = true });
        }
    }
}