using BigSchool_VuTuanTu_2011061955.Models;
using BigSchool_VuTuanTu_2011061955.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BigSchool_VuTuanTu_2011061955.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        public CoursesController()
        {
            _dbContext = new ApplicationDbContext();
        }
        public ActionResult Create()
        {
            var viewModel = new CourseViewModel
            {
                Categories = _dbContext.Categories.ToList()
            };

            return View(viewModel);
        }
    }
}