using Microsoft.VisualStudio.TestTools.UnitTesting;
using RacingBetSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingBetSystem.Tests
{
    [TestClass()]
    public class RacesTests
    {
        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CreateRaceDateArgumentOutOfRangeException()
        {
            DateTime dt = DateTime.Now.Date.AddDays(1);  // Add a day 1 ahead of the current date
            Races race = new Races("Ascot", dt, 12.00m, true);
           

        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NoNameArgumentNullException()
        {
            string name = null;
            Races race = new Races(name, new DateTime(2017, 12, 1), 12.00m, true);


        }

        [TestMethod()]
        public void RaceShouldBeAdded()
        {
            Races race = new Races("Punchestown", new DateTime(2017, 02, 1), 14.00m, true);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void ShouldnotAcceptZeroOrLess()
        {
            Races race = new Races("Punchestown", new DateTime(2017, 02, 1), 0, true);
        }

    }
}