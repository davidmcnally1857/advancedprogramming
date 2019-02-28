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
    public class RaceListTests
    {
        [TestMethod()]
        public void RacesShouldBeAdded()
        {
            RaceList races = new RaceList()
            {
                new Races{Name = "Ascot", Date = new DateTime(2017, 2, 12), Amount = 1400m, Outcome = true }
            };
        }

        [TestMethod()]
        public void ListCountSHouldGiveCorrectValue()
        {
            int count = 3;

            RaceList races = new RaceList()
            {
                new Races{Name = "Ascot", Date = new DateTime(2017, 2, 12), Amount = 1400m, Outcome = true },
                new Races{Name = "Towcester", Date = new DateTime(2017, 1, 10), Amount = 2300m, Outcome = false },
                new Races{Name = "Ascot", Date = new DateTime(2017, 2, 12), Amount = 1400m, Outcome = true }
            };

            Assert.AreEqual(races.Count, count);
                        
        }


    }
}