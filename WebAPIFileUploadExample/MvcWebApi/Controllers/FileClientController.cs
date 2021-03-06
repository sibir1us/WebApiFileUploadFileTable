﻿using System.Linq;
using System.Web.Mvc;
using DataAccess;
using DataAccess.Model;

namespace MvcWebApi.Controllers
{
    public class FileClientController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Index Page";

            return View();
        }

        public ActionResult Client()
        {
            ViewBag.Title = "Ex Client";

            return View();
        }

        public ActionResult MultiClient()
        {
            ViewBag.Title = "Ex MultiClient";

            return View();
        }

        /// <summary>
        /// Just a test method to view all files.
        /// </summary>
        public ActionResult ViewAllFiles()
        {
            var fileRepository = new FileRepository();
            var model = new AllUploadedFiles {FileShortDescriptions = fileRepository.GetAllFiles().ToList()};
            return View(model);
        }
    }
}
