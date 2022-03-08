using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Zurich.Common.Constants;
using Zurich.Domain.Interfaces;
using Zurich.Domain.Models;

namespace Zurich.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        #region "Private Properties"
        private readonly IUnitOfWork _unitOfWork;
        #endregion

        #region "Constructor"
        public CoursesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        #endregion

        #region "Action Methods"
        /// <summary>
        /// To create a course
        /// </summary>
        /// <param name="course"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult CreateCourse(Courses course)
        {
            var result = _unitOfWork.Courses.Add(course);
            _unitOfWork.Complete();
            if (result is not null)
            {
                return Ok(CommonConstants.SAVED_SUCCESSFULLY);
            }
            else
            {
                return BadRequest(CommonConstants.ERROR_WHILE_SAVING);
            }
        }

        /// <summary>
        /// To update a course
        /// </summary>
        /// <param name="course"></param>
        /// <returns></returns>
        [HttpPut]
        public IActionResult UpdateCourse(Courses course)
        {
            _unitOfWork.Courses.Update(course);
            _unitOfWork.Complete();
            return Ok(CommonConstants.UPDATED_SUCCESSFULLY);
        }

        /// <summary>
        /// To get a course
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetCourses()
        {
            return Ok(await _unitOfWork.Courses.GetAll());
        }
        #endregion
    }
}