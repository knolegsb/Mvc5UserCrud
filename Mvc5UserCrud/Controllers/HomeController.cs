using Mvc5UserCrud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc5UserCrud.Controllers
{
    public class HomeController : Controller
    {
        UserDbContext db = new UserDbContext();
        public static List<UserViewModel> userList = new List<UserViewModel>();
        public static List<Course> courses = new List<Course>();

        [HttpGet]
        [AllowAnonymous]
        public ActionResult Index()
        {
            userList.Clear();
            IList<User> users = db.Users.ToList();

            foreach(var user in users)
            {
                var countryId = db.UserCountries.Where(u => u.UserId == user.Id).Select(c => c.CountryId).FirstOrDefault();
                var country = db.Countries.Where(c => c.Id == countryId).Select(n => n.Name).FirstOrDefault();
                var description = db.UserDescription.Where(i => i.UserId == user.Id).Select(d => d.Description).FirstOrDefault();
                var courseIds = db.UserCourses.Where(u => u.UserId == user.Id).Select(x => x.CourseId).ToList();

                List<Course> courseNames = new List<Course>();
                foreach (var courseId in courseIds)
                {
                    courseNames.Add(new Models.Course { Name = db.Courses.Where(x => x.Id == courseId).Select(x => x.Name).FirstOrDefault() });
                }

                userList.Add(new UserViewModel
                {
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email,
                    Gender = user.Gender,
                    Country = country,
                    UserId = user.Id,
                    Description = description,
                    Courses = courseNames
                });
            }
            return View(userList);
        }


    }
}