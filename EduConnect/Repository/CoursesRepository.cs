using EduConnect.Models;
using EduConnect.Data;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace EduConnect.Repository
{
    public class CoursesRepository
    {
        private readonly AppDbContext _context = null;
        public CoursesRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<int> AddNewCourse(CourseModel model)
        {
            var newCourse = new Courses()
            {


                CoursesName = model.CoursesName,
                Instructor = model.Instructor,
                Categories = model.Categories,
                Description = model.Description,
                //Coverphotourl = model.Coverphotourl'
                Module1 = model.Module1,
                Module2 = model.Module2,
                Module3 = model.Module3,
                Module4 = model.Module4,
                Module5 = model.Module5,
                Module6 = model.Module6,
                Url = model.UrlAttribute,
                Url2 = model.Url2,
                Url3 = model.Url3,
                Url4 = model.Url4,
                Url5 = model.Url5,
                Url6 = model.Url6,
                Url7 = model.Url7
                







            };

          await  _context.Courses.AddAsync(newCourse);
          await _context.SaveChangesAsync();
          return newCourse.Id;
        }


      public async Task<int> AdMycorse(MycourseModel model)
        {
            var myCourse = new Mycourse()
            {
                
                Name = model.Name,
                Email = model.Email,
                coursename=model.coursename

            };

            await _context.Mycourse.AddAsync(myCourse);
            await _context.SaveChangesAsync();
            return myCourse.Id;



        }


        public async  Task<List<CourseModel>> ViewAllCourses()
        {
            //var Course1=new List<CourseModel>(); 
            //var AllCourse= await _context.Courses.ToListAsync();
            //if (AllCourse?.Any() == true)
            //{
            //    foreach (var course in AllCourse)
            //    {
            return await _context.Courses
                    .Select(course => new CourseModel(){ 
                    
                    
                        Id=course.Id,
                        CoursesName=course.CoursesName,
                        Description=course.Description,
                        Instructor=course.Instructor,
                        Categories=course.Categories,
                        //Coverphotourl=course.Coverphotourl

                        Module1=course.Module1,
                        Module2 = course.Module2,
                        Module3 = course.Module3,
                        Module4 = course.Module4,
                        Module5 = course.Module5,
                        Module6 = course.Module6,
                        UrlAttribute=course.Url,
                        Url2 = course.Url2,
                        Url3 = course.Url3,
                        Url4 = course.Url4,
                        Url5 = course.Url5,
                        Url6 = course.Url6,
                        Url7 = course.Url7,
                        




                    }).ToListAsync();
              
        }
        public async Task <CourseModel> En_rollCourses_or_ViewCourse(int id)

        {
            var course = await _context.Courses.FindAsync(id);
            if(course != null)
            {
                var courseDetails = new CourseModel()
                {
                    Id=course.Id,
                    CoursesName = course.CoursesName,
                    Description = course.Description,
                    Instructor = course.Instructor,
                    Categories = course.Categories,
                    Module1 = course.Module1,
                    Module2 = course.Module2,
                    Module3 = course.Module3,
                    Module4 = course.Module4,
                    Module5 = course.Module5,
                    Module6 = course.Module6,
                    UrlAttribute = course.Url,
                    Url2 = course.Url2,
                    Url3 = course.Url3,
                    Url4 = course.Url4,
                    Url5 = course.Url5,
                    Url6 = course.Url6,
                    Url7 = course.Url7


                };
                return courseDetails;
            }
            return null;

            //_context.Courses.Where(x => x.Id == id).FirstOrDefaultAsync();
        }
        public List<CourseModel> SearchCourses(string coursesName, string categories)
        {
            return DataSource().Where(x => x.CoursesName.Contains(coursesName) || x.Categories == categories).ToList();
        }
        private List<CourseModel> DataSource()
        {
            return new List<CourseModel>()
            {
                new CourseModel() {Id = 1, CoursesName = "Computer Architecture", Instructor = "Prof. Smruti Ranjan Sarangi" , Categories="Computer Science",Description="This course is on Advanced Computer Architecture. It will introduce students to advanced aspects of processor design and will specifically focus on out-of-order pipelines, GPUs, and compiler techniques for enhancing ILP. The course will subsequently move on to cache design and main memory technologies such as DDR-4. A substantial portion of the course will be devoted to the theory of on-chip networks and memory models. The last part of the course will cover aspects of low-power design, hardware security, and reliability.\r\n"  },
                new CourseModel() {Id = 2, CoursesName = "Programming in \n C ", Instructor = "Prof. Anupam Basu" ,Categories="Programming", Description="" },
                new CourseModel() {Id = 3, CoursesName = "Computer Networks ", Instructor = "Prof. Neminath Hubballi, ",Categories="Computer Science"  },
                new CourseModel() {Id = 4, CoursesName = "Programming in Python ", Instructor = "Prof. Sudarshan Iyengar" ,Categories="Programming"  },
                new CourseModel() {Id = 1, CoursesName = "Business Intelligence ", Instructor = "Prof. Saji K Mathew" , Categories="Data science"  },
                new CourseModel() {Id = 1, CoursesName = "Cloud Computing", Instructor = "Prof. Soumya Kanti Ghosh" , Categories="Cloud"  },
                new CourseModel() {Id = 1, CoursesName = "Deep Learning", Instructor = "Prof. Sudarshan Iyengar" , Categories="ML"  },
               new CourseModel() {Id = 1, CoursesName = "Java Programming", Instructor = "NPTEL" , Categories="Programming"  },

                new CourseModel() {Id = 1, CoursesName = "Introduction To Haskell Programming", Instructor = "By Prof. S. P Suresh" , Categories="Programming"  },




            };


        }

        
    }
}
