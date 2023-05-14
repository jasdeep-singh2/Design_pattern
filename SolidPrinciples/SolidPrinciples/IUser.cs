namespace SingleResponsibilityPrinciple
{
    public interface IUser
    {
        bool Login(string username, string password);
        bool Register(string username, string password, string email);

        /// <summary>
        /// This LogError method should not be the part of IUser interface only Login and Register method should be part of the IUser interface
        /// </summary>
        /// <param name="error"></param>
        //void LogError(string error);

        /// <summary>
        /// same for the below SendEmail interface method so I created a separate inteface for the Logger and Email
        /// </summary>
        /// <param name="emailContent"></param>
        /// <returns></returns>
        //bool SendEmail(string emailContent);
    }

    public interface ILogger
    {
        void LogError(string error);
    }

    public interface IEmail
    {
        bool SendEmail(string emailContent);
    }
}
