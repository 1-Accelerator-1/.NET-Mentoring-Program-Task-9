namespace BrainstormSessions.Core.Interfaces
{
    public interface ISendEmailService
    {
        void SendLogFileToEmail(string emailFrom, string passwordFrom, string emailTo, string fileName);
    }
}
