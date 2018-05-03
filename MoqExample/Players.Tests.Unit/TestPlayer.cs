using System;
using Players;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Players.Tests.Unit
{
    [TestClass]
    public class TestPlayer
    { 
        // Should receive an exception, because the name is an empty string.
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_CreateNewPlayer_EmptyName()
        { 
            Player player = Player.CreateNewPlayer("");
        }

        // Should still receive an exception, because the name is an empty string.
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_CreateNewPlayer_EmptyName_MockedDataMapper()
        {
             
            // THIS is how Moq creates an object that implements the IPlayerDataMapper interface
            var mock = new Mock<IPlayerDataMapper>();

            Player player = Player.CreateNewPlayer("", mock.Object);
        }

        // Should receive an exception, because we set the mock PlayerDataMapper 
        // to say the player name already exists in the database.
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_CreateNewPlayer_AlreadyExistsInDatabase()
        {
            var mock = new Mock<IPlayerDataMapper>();
             
            // Intercept the call to PlayerNameExistsInDatabase() and return our own value
            mock.Setup(x => x.PlayerNameExistsInDatabase(It.IsAny<string>())).Returns(true);

            Player player = Player.CreateNewPlayer("Test", mock.Object);
        }

        // Should succeed, because we set the mock PlayerDataMapper 
        // to say the player name does not already exist in the database.
        // Also, when it calls the mock InsertNewPlayerIntoDatabase,
        // the mock mapper will not need a database running.
        [TestMethod]
        public void Test_CreateNewPlayer_DoesNotAlreadyExistInDatabase()
        { 
            var mock = new Mock<IPlayerDataMapper>();

            // Intercept the call to PlayerNameExistsInDatabase() and return our own value
            mock.Setup(x => x.PlayerNameExistsInDatabase(It.IsAny<string>())).Returns(false);

            Player player = Player.CreateNewPlayer("Test", mock.Object);

            Assert.AreEqual("Test", player.Name);
            Assert.AreEqual(0, player.ExperiencePoints);
            Assert.AreEqual(10, player.Gold);
        }

    }
}
