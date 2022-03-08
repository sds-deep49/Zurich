using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Linq;
using Xunit;
using Zurich.Common.Constants;
using Zurich.Controllers;
using Zurich.Domain.DTO;
using Zurich.Domain.Interfaces;
using Zurich.Domain.Models;

namespace Zurich.UnitTest
{
    public class SubscriptionControllerTest
    {
        #region "Private Properties"
        private readonly Mock<IUnitOfWork> _unitOfWork;
        private UserSubscriptionParameter userSubscriptionParameter = new UserSubscriptionParameter();
        #endregion

        #region "Constructor"
        public SubscriptionControllerTest()
        {
            _unitOfWork = new Mock<IUnitOfWork>();
        }
        #endregion

        #region "Unit Test Cases Methods"
        /// <summary>
        /// Check the test cases by Training Name
        /// </summary>
        [Fact]
        public void GetTrainingExistsInUserSubscription()
        {
            //arrange
            var trainingUser = TestCasesConstants.USER_SUBSCRIPTION_LIST.
                Where(i => i.TrainingName.Equals(TestCasesConstants.TRAINING_ANGULAR)).ToList();
            var userSubscription = new PagedList<UserSubscriptionDTO>(trainingUser, TestCasesConstants.TOTAL_COUNT,
                TestCasesConstants.PAGE_NUMBER, TestCasesConstants.PAGE_SIZE);
            userSubscriptionParameter.PageNumber = TestCasesConstants.PAGE_NUMBER;
            userSubscriptionParameter.PageSize = TestCasesConstants.PAGE_SIZE;
            userSubscriptionParameter.TrainingName = TestCasesConstants.TRAINING_ANGULAR;
            _unitOfWork.Setup(u => u.Subscriptions.GetUserSubscriptions(userSubscriptionParameter)).Returns(userSubscription);
            var controller = new SubscriptionController(_unitOfWork.Object);

            //act
            var actionResult = controller.GetUserSubScriptions(userSubscriptionParameter);
            var result = actionResult.Result as OkObjectResult;
            var actual = result.Value as PagedList<UserSubscriptionDTO>;

            //Assert
            Assert.IsType<OkObjectResult>(result);
            Assert.Equal(trainingUser.Count, actual.Count);
        }

        /// <summary>
        /// Check the test cases by Course Name
        /// </summary>
        [Fact]
        public void GetCourseExistsInUserSubscription()
        {
            //arrange
            var courseUser = TestCasesConstants.USER_SUBSCRIPTION_LIST.
                Where(i => i.CourseName.Equals(TestCasesConstants.COURSE_WEB_API)).ToList();
            var userSubscription = new PagedList<UserSubscriptionDTO>(courseUser, TestCasesConstants.TOTAL_COUNT,
                TestCasesConstants.PAGE_NUMBER, TestCasesConstants.PAGE_SIZE);
            userSubscriptionParameter.PageNumber = TestCasesConstants.PAGE_NUMBER;
            userSubscriptionParameter.PageSize = TestCasesConstants.PAGE_SIZE;
            userSubscriptionParameter.TrainingName = TestCasesConstants.COURSE_WEB_API;
            _unitOfWork.Setup(u => u.Subscriptions.GetUserSubscriptions(userSubscriptionParameter)).Returns(userSubscription);
            var controller = new SubscriptionController(_unitOfWork.Object);

            //act
            var actionResult = controller.GetUserSubScriptions(userSubscriptionParameter);
            var result = actionResult.Result as OkObjectResult;
            var actual = result.Value as PagedList<UserSubscriptionDTO>;

            //Assert
            Assert.IsType<OkObjectResult>(result);
            Assert.Equal(courseUser.Count, actual.Count);
        }
        #endregion
    }
}