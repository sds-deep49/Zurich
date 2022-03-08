namespace Zurich.Common.Constants
{
    public class CommonConstants
    {
        #region "CRUD Operations"
        public const string SAVED_SUCCESSFULLY = "Saved Successfully!";
        public const string UPDATED_SUCCESSFULLY = "Updated Successfully!";
        public const string DELETED_SUCCESSFULLY = "Deleted Successfully!";

        public const string ERROR_WHILE_SAVING = "Error While Saving The Records!";
        #endregion

        #region "Connection string"
        public const string CONNECTION_STRING = "Server=DESKTOP-PRVL2R6\\SQLEXPRESS;Database=Zurich;Trusted_Connection=True;MultipleActiveResultSets=true";
        #endregion

        #region "Status"
        public const string TRAINING_STATUS_OPEN = "Open";
        public const string TRAINING_STATUS_CLOSE = "Close";
        #endregion
                
        #region "Request Header"
        public const string REQUEST_HEADER_PAGINATION = "X-Pagination";
        #endregion

        #region "Third Party URL(s)"
        public const string GO_REST_BASE_URL = "https://gorest.co.in/";
        #endregion
    }
}