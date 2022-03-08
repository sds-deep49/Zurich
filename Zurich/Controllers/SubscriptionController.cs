using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Threading.Tasks;
using Zurich.Common.Constants;
using Zurich.Domain.Interfaces;
using Zurich.Domain.Models;

namespace Zurich.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscriptionController : ControllerBase
    {
        #region "Private Properties"
        private readonly IUnitOfWork _unitOfWork;
        #endregion

        #region "Constructor"
        public SubscriptionController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        #endregion

        #region "Action Methods"
        /// <summary>
        /// To create a subscription
        /// </summary>
        /// <param name="subscription"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult CreateSubscription(Subscription subscription)
        {
            if (subscription == null)
            {
                return BadRequest();
            }

            var result = _unitOfWork.Subscriptions.Add(subscription);
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
        /// To get a subscriptions
        /// </summary>
        /// <param name="subscriptionParameters"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetSubScriptions(SubscriptionParameters subscriptionParameters)
        {
            var subscription = _unitOfWork.Subscriptions.GetSubscriptions(subscriptionParameters);

            var pagingData = new
            {
                subscription.TotalCount,
                subscription.PageSize,
                subscription.CurrentPage,
                subscription.TotalPages,
                subscription.HasNext,
                subscription.HasPrevious
            };

            Response?.Headers.Add(CommonConstants.REQUEST_HEADER_PAGINATION, JsonConvert.SerializeObject(pagingData));

            return Ok(subscription);
        }

        /// <summary>
        /// To get a user subscriptions
        /// </summary>
        /// <param name="userSubscriptionParameter"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetUserSubScriptions")]
        public async Task<ActionResult> GetUserSubScriptions(UserSubscriptionParameter userSubscriptionParameter)
        {
            var userSubscription = _unitOfWork.Subscriptions.GetUserSubscriptions(userSubscriptionParameter);

            var pagingData = new
            {
                userSubscription.TotalCount,
                userSubscription.PageSize,
                userSubscription.CurrentPage,
                userSubscription.TotalPages,
                userSubscription.HasNext,
                userSubscription.HasPrevious
            };

            Response?.Headers.Add(CommonConstants.REQUEST_HEADER_PAGINATION, JsonConvert.SerializeObject(pagingData));

            return Ok(userSubscription);
        }
        #endregion
    }
}