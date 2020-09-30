using Microsoft.VisualStudio.TestTools.UnitTesting;
using CykelUnitTest;
using System;
using System.Collections.Generic;
using System.Text;

namespace CykelUnitTest.Tests
{
    [TestClass()]
    public class CykelTests
    {
        private Cykel _cykel;

        //Køre før alle testmetoder.
        //Opretter et cykelobject, så der er noget at arbejde med.
        [TestInitialize]
        public void Init()
        {
            _cykel = new Cykel(1, "gul",1500,5);
        }

        //Vi tester lige konstruktøren, om værdierne er det samme.
        [TestMethod()]
        public void CykelTestConstructor()
        {
            Assert.AreEqual(1, _cykel.Id);
            Assert.AreEqual("gul", _cykel.Farve);
            Assert.AreEqual(1500, _cykel.Pris);
            Assert.AreEqual(5, _cykel.Gear);
        }

        //Hvad hvis farven er tom, hvis ja, smid exception.
        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CykelTestFarveLength()
        {
            //Der skal angives tegn, er stringen tom, smid exception.
            //Vi forvendter at string er tom, så den skal fejle (grøn)
            _cykel.Farve = "";
        }

        //Hvis cyklens pris er 0kr (gratis), smid exception.
        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CykelTestPris()
        {
            //
            _cykel.Pris = 0;
        }

        //Cyklen skal havde mellem 3 og 32 gear.
        [TestMethod()]
        public void CykelTestGear()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _cykel.Gear = 2);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _cykel.Gear = 34);
        }
    }
}