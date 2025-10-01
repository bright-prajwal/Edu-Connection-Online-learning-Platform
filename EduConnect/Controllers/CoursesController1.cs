using EduConnect.Data;
using EduConnect.Models;
using EduConnect.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace EduConnect.Controllers
{
    public class CoursesController1 : Controller
    {

       
       
        private readonly CoursesRepository _coursesRepository = null;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly AppDbContext _appDbContext;

        public CoursesController1(CoursesRepository coursesRepository, IWebHostEnvironment webHostEnvironment)
        {
            _coursesRepository = coursesRepository;
            _webHostEnvironment= webHostEnvironment;
        }

        [Authorize]
        public async Task <ViewResult> ViewAllCourses()
        {
            var data = await _coursesRepository.ViewAllCourses();

            return View(data);
        }

        //[Route("course-details/{id}", Name="courseDetailsRoute")]
        public async Task<ViewResult> En_rollCourses_or_ViewCourse(int id)
        {
            var data = await _coursesRepository.En_rollCourses_or_ViewCourse(id);
            return View(data);
        }

        public List<CourseModel> SearchCourses(string CoursesName, String Categories)
        {
            return _coursesRepository.SearchCourses(CoursesName, Categories);
            //return _appDbContext.Set<CourseModel>().ToList();

        }

        public ViewResult AddNewCourse(bool isSuccess =false, int courseId=0)

        {
             ViewBag.IsSuccess = isSuccess;
            ViewBag.CourseId = courseId;
            return View();
        }
       

        


        [HttpPost]
        public async Task<IActionResult> AddNewCourse(CourseModel courseModel)
        {

            if (ModelState.IsValid)
            {
                if (courseModel.CoverPhoto != null)
                {
                    string folder = "cours/cover/";

                    folder += Guid.NewGuid().ToString() + "_" + courseModel.CoverPhoto.FileName;

                    

                    string severFolder = Path.Combine(_webHostEnvironment.WebRootPath, folder);

                    await courseModel.CoverPhoto.CopyToAsync(new FileStream(severFolder, FileMode.Create));

                    //courseModel.Coverphotourl = "/" + folder;


                }
                int id = await _coursesRepository.AddNewCourse(courseModel);
                if (id > 0)
                {
                    return RedirectToAction(nameof(AddNewCourse), new { isSuccess = true, courseId = id });
                }


            }
            //ViewBag.IsSuccess = false;
            //ViewBag.CourseId = 0;

            //ModelState.AddModelError("", "Any More");
            return View();
        }


        //public async Task<IActionResult> Enroll(MycourseModel mycourseModel)

        //{

        //    if (ModelState.IsValid)
        //    {
        //        int id = await _coursesRepository.Enroll(mycourseModel);
        //        if (id > 0)
        //        {
        //            return RedirectToAction(nameof(), new { isSuccess = true, courseId = id });
        //        }
        //        return View(mycourseModel);

        //    }
        //}


        //public async Task<IActionResult> AdMycorse(Mycourse mycourse)
        //{

        //    if (ModelState.IsValid)
        //    {
        //        int id = await _coursesRepository.AdMycorse(mycourse);
        //        if (id > 0)
        //        {
        //            return RedirectToAction(nameof(AddMycorse), new { isSuccess = true });
        //        }

        //    }
        //    return View();
        //}

        
        public IActionResult ModuleVideo()
        {
            return View();
        }



        public IActionResult JavaQuiz()
        {
            return View();
        }
    }
}
