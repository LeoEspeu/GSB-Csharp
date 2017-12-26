using Microsoft.VisualStudio.TestTools.UnitTesting;
using GSB_Csharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSB_Csharp.Tests
{
    [TestClass()]
    public class GestionDatesTests
    {
        [TestMethod()]
        public void getMoisPrecedentTest()
        {
            Assert.AreEqual("11", GestionDates.getMoisPrecedent(), "La date doit être égale à 11");
        }

        [TestMethod()]
        public void getMoisPrecedentSurchargeTest_janvier()
        {
            Assert.AreEqual("12", GestionDates.getMoisPrecedent(new DateTime(2017, 1, 11)),"La date doit être égale à 12");
        }

        [TestMethod()]
        public void getMoisPrecedentSurchargeTest_supérieur_à_10()
        {
            Assert.AreEqual("10", GestionDates.getMoisPrecedent(new DateTime(2017, 11, 11)), "La date doit être égale à 12");
        }

        [TestMethod()]
        public void getMoisPrecedentSurchargeTest_entre_1_et_10()
        {
            Assert.AreEqual("03", GestionDates.getMoisPrecedent(new DateTime(2017, 4, 11)), "La date doit être égale à 12");
        }

        [TestMethod()]
        public void getMoisSuivantTest()
        {
            Assert.AreEqual("01", GestionDates.getMoisSuivant(), "La date doit être égale à 01");
        }

        [TestMethod()]
        public void getMoisSuivantTestSurcharge_décembre()
        {
            Assert.AreEqual("01", GestionDates.getMoisSuivant(new DateTime(2017,12,12)), "La date doit être égale à 01");
        }

        [TestMethod()]
        public void getMoisSuivantTestSurcharge_septembre()
        {
            Assert.AreEqual("10", GestionDates.getMoisSuivant(new DateTime(2017, 9, 12)), "La date doit être égale à 01");
        }

        [TestMethod()]
        public void getMoisSuivantTestSurcharge_entre_10_et_12()
        {
            Assert.AreEqual("12", GestionDates.getMoisSuivant(new DateTime(2017,11, 12)), "La date doit être égale à 01");
        }

        [TestMethod()]
        public void getMoisSuivantTestSurcharge_entre_1_et_9()
        {
            Assert.AreEqual("08", GestionDates.getMoisSuivant(new DateTime(2017, 7, 12)), "La date doit être égale à 01");
        }

        [TestMethod()]
        public void getEntreTest_dehors()
        {
            Assert.AreEqual(false, GestionDates.entre(10, 20), "La date n'est pas dans l'interval");
        }

        [TestMethod()]
        public void getEntreTest_entre()
        {
            Assert.AreEqual(true, GestionDates.entre(20, 30), "La date est dans l'interval");
        }

        [TestMethod()]
        public void getEntreTestSurcharge_dehors()
        {
            Assert.AreEqual(false, GestionDates.entre(10, 20, 22), "La date n'est pas dans l'interval");
        }

        [TestMethod()]
        public void getEntreTestSurcharge_entre()
        {
            Assert.AreEqual(true, GestionDates.entre(20, 30, 25), "La date est dans l'interval");
        }
    }
}