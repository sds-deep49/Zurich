using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Zurich.Common.Constants;
using Zurich.Domain.Interfaces;
using Zurich.Domain.Models;

namespace Zurich.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainingsController : ControllerBase
    {
        #region "Private Properties"
        private readonly IUnitOfWork _unitOfWork;
        #endregion

        #region "Constructor"
        public TrainingsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        #endregion

        #region "Action Methods"
        /// <summary>
        /// To create a training
        /// </summary>
        /// <param name="training"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult CreateTraining(Trainings training)
        {
            if (training == null)
            {
                return BadRequest();
            }

            var result = _unitOfWork.Trainings.Add(training);
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
        /// To update a training
        /// </summary>
        /// <param name="training"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task<IActionResult> UpdateTraining(Trainings training)
        {
            var trainingToUpdate = await _unitOfWork.Trainings.Get(training.TrainingsId);
            if (trainingToUpdate is null)
            {
                return NotFound($"Training with training id= { training.TrainingsId } not found");
            }
            _unitOfWork.Trainings.Update(training);
            _unitOfWork.Complete();
            return Ok(CommonConstants.UPDATED_SUCCESSFULLY);
        }
        #endregion
    }
}