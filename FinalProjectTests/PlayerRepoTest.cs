using FinalProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectTests
{
    [TestClass]
    public class PlayerRepoTest
    {
        [TestMethod]
        public void GetAllPlayer()
        {
            //Given
            string firstName = "Jay";
            string lastName = "Kay";
            DateTime dateOfBirth = new DateTime(2008, 5, 1, 8, 30, 52);
            int points = 0;

            Player p = new Player(firstName, lastName, dateOfBirth, points);
            PlayerRepo pRep = new PlayerRepo();
        
            //When
            pRep.AddPlayer(p);
            pRep.GetAllPlayerBy(p);
            //Then
            List<Player> players = pRep.GetAllPlayers();
            Assert.AreEqual(string.Format("[Firstname={0}][Lastname={0}]", players[0].ToString());
        }
    }
}
