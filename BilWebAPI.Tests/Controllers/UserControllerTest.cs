using System;
using Xunit;
using BilWebAPI;
using BilWebAPI.Models;
using BilWebAPI.Controllers;

namespace BilWebAPI.Tests.Controllers
{   
    public class UserControllerTest
    {
        [Theory]
        [InlineData("Anton", "4d241c073c19cdd3eed9553151126f88f9be12ebdbbfb057b5b23acbe74e50360db4711e411b3a3cfcaf8a15716053c84b1fafc70903fc82cfee4c1628b77251")]
        public void CheckLogin_ShouldReturnUserSessionID(string username, string password)
        {
            //Arrange
            string NotExpectedSID = "";
            UserController uc = new UserController();

            //Act
            User retrievedUser = uc.CheckLogin(username, password);
            string actualSID = retrievedUser.SessionID;

            //Assert
            Assert.NotStrictEqual(NotExpectedSID, actualSID);

        }

        [Theory]
        //Correct username, incorrect password
        [InlineData("Anton", "4d241c073chhj19cdd3eed9553151126f88f9be12ebdbbfb057b5b23acbe74e50360db4711e411b3a3cfcaf8a15716053c84b1fafc70903fc82cfee4c1628b77251")]
        //Incorrect username, correct password
        [InlineData("Antonia", "4d241c073c19cdd3eed9553151126f88f9be12ebdbbfb057b5b23acbe74e50360db4711e411b3a3cfcaf8a15716053c84b1fafc70903fc82cfee4c1628b77251")]
        //Correct username, null password
        [InlineData("Anton", null)]
        [InlineData(null, "4d241c073c19cdd3eed9553151126f88f9be12ebdbbfb057b5b23acbe74e50360db4711e411b3a3cfcaf8a15716053c84b1fafc70903fc82cfee4c1628b77251")]
        public void CheckLogin_ShouldReturnEmptyUserSessionID(string username, string password)
        {
            //Arrange
            string expectedSID = "";
            UserController uc = new UserController();

            //Act
            User retrievedUser = uc.CheckLogin(username, password);
            string actualSID = retrievedUser.SessionID;

            //Assert
            Assert.Equal(expectedSID, actualSID);

        }
    }
}
