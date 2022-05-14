using BrainstormSessions.Infrastructure;
using System;
using Xunit;

namespace BrainstormSessions.Test.UnitTests
{
    public class SendFileToEmailTests
    {
        [Fact]
        public void SendLogFileToEmail()
        {
            // Arrange
            var sendEmailService = new SendEmailService();

            // Please input your data for test
            //    ||
            //    \/
            var emailFrom = "";
            var passwordFrom = "";
            var emailTo = "";
            var pathToFile = @"";

            bool isSuccess;

            // Act
            try
            {
                sendEmailService.SendLogFileToEmail(emailFrom, passwordFrom, emailTo, pathToFile);
                isSuccess = true;
            }
            catch (Exception ex)
            {
                isSuccess = false;
            }

            // Assert
            Assert.True(isSuccess, "Email sending failed");
        }
    }
}
