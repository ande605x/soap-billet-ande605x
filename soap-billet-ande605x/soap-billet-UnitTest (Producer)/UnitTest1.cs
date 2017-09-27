using System;
using soap_billet_ande605x;
using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace soap_billet_UnitTest__Producer_
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod()]
        public void PrisBilMedCampingvognUdenBrobizzTest()
        {

            //Arrange
            BilletService bs = new BilletService();
            //Act
            int testtal = bs.PrisBilMedCampingvognUdenBrobizz();
            //Assert
            Assert.AreEqual(365, testtal);
        }

        [TestMethod]
        public void TestPrisBilMedBrobizz()
        {
            //Arrange
            BilletService bs = new BilletService();
            //Act
            int testtal = bs.PrisBilMedBrobizz();
            //Assert
            Assert.AreEqual(228,testtal);
        }

        [TestMethod]
        public void PrisMCMedBrobizz()
        {
            //Arrange
            BilletService bs = new BilletService();
            //Act
            int testtal = bs.PrisMCMedBrobizz();
            //Assert
            Assert.AreEqual(114, testtal);
        }

        [TestMethod]
        public void PrisBilUdenBrobizz()
        {
            //Arrange
            BilletService bs = new BilletService();
            //Act
            int testtal = bs.PrisBilUdenBrobizz();
            //Assert
            Assert.AreEqual(240, testtal);
        }

        [TestMethod]
        public void PrisMCUdenBrobizz()
        {
            //Arrange
            BilletService bs = new BilletService();
            //Act
            int testtal = bs.PrisMCUdenBrobizz();
            //Assert
            Assert.AreEqual(120, testtal);
        }
    }
}
