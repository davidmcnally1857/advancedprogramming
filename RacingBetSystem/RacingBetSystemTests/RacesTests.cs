using Microsoft.VisualStudio.TestTools.UnitTesting;
using RacingBetSystem;
using System;
using System.Collections.Generic;
using System.IO;
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
        [ExpectedException(typeof(ArgumentException))]
        public void EmptyNameThrowsArgumentException()
        {
            string name = "";
            Races race = new Races(name, new DateTime(2018, 04, 20), 40.00m, false);
        }

        [TestMethod()]
        public void RaceShouldBeAdded()
        {
            Races race = new Races("Punchestown", new DateTime(2017, 02, 1), 14.00m, true);
        }


        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void ShouldnotAcceptZero()
        {
            Races race1 = new Races("Punchestown", new DateTime(2017, 02, 1), 0, true);
          
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void ShouldnotAcceptNegativeNumber()
        {
            Races race1 = new Races("Punchestown", new DateTime(2017, 02, 1), -1, true);

        }


        [TestMethod()]
        public void CreateFileIfDoesNotExist()
        {
            string path = "RaceTest.bin";
            if (File.Exists(path))
            {
                File.Delete(path);
            }

            Assert.IsFalse(File.Exists(path));
            File.Create(path);
            Assert.IsTrue(File.Exists(path));
          
        }

    }

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
        public void RacesShouldBeAddedUsingAdd()
        {
            RaceList races = new RaceList();


            races.Add(new Races { Name = "Cheltenham", Date = new DateTime(2018, 5, 20), Amount = 450m, Outcome = false });

        }

        [TestMethod()]
        public void ListCountShouldGiveCorrectValue()
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

        [TestMethod()]
        public void ListShouldHaveACOuntOfZeroAfterClear()
        {
            int count = 0;

            RaceList races = new RaceList()
            {
                new Races{Name = "Ascot", Date = new DateTime(2017, 2, 12), Amount = 1400m, Outcome = true },
                new Races{Name = "Towcester", Date = new DateTime(2017, 1, 10), Amount = 2300m, Outcome = false },
                new Races{Name = "Ascot", Date = new DateTime(2017, 2, 12), Amount = 1400m, Outcome = true }
            };

            races.Clear();

            Assert.AreEqual(races.Count, count);
        }

    }
}