using System.Collections.Generic;
using Zurich.Domain.DTO;

namespace Zurich.Common.Constants
{
    public class TestCasesConstants
    {
        #region "User Subscription"
        public static List<UserSubscriptionDTO> USER_SUBSCRIPTION_LIST = new List<UserSubscriptionDTO>()
        {
              new UserSubscriptionDTO
              {
                  TrainingName = "Web API Spring Session",
                  TrainingCode = "T101",
                  CourseName = ".Net Web API",
                  CourseCode = "C101",
                  TrainingMonth = "March",
                  UserName = "Ayushmati Deshpande",
                  UserGender = "male",
                  UserEmail = "ayushmati_deshpande@schoen.org"
              },
              new UserSubscriptionDTO
              {
                  TrainingName = "Angular Session",
                  TrainingCode = "T102",
                  CourseName = "Angular 10",
                  CourseCode = "C103",
                  TrainingMonth = "February",
                  UserName = "Aashritha Prajapat",
                  UserGender = "male",
                  UserEmail = "prajapat_aashritha@jones.biz"
              }
        };

        public const int TOTAL_COUNT = 1;
        public const int PAGE_NUMBER = 1;
        public const int PAGE_SIZE = 10;
                
        public const string TRAINING_ANGULAR = "Angular Session";                
        public const string COURSE_WEB_API = ".Net Web API";
        #endregion
    }
}
