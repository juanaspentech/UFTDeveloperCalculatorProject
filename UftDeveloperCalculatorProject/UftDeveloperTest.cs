using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HP.LFT.SDK;
using HP.LFT.SDK.StdWin;
using HP.LFT.Verifications;
using static UftDeveloperCalculatorProject.CalculatorTests;
using static UftDeveloperCalculatorProject.Environment;
using static UftDeveloperCalculatorProject.CalculatorObjects;
using System.Diagnostics;
using System.Threading;

namespace UftDeveloperCalculatorProject
{
    [TestClass]
    public class UftDeveloperTest : UnitTestClassBase<UftDeveloperTest>
    {

        //private IAut calcApp;

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            GlobalSetup(context);

            IAut calcApp = Desktop.LaunchAut(calcPath);
        }

        [TestInitialize]
        public void TestInitialize()
        {


        }

        #region Basic Arithmetic
        [TestMethod]
        public void _002() => TwoPlusThreeShouldGiveFive();


        [TestMethod]
        public void _003() => FiveMinusThreeShouldGiveTwo();

        [TestMethod]
        public void _004() => SixTimesSevenShouldGiveFourtyTwo();


        [TestMethod]
        public void _005() => NineDividedByThreeShouldGiveThree();

        #endregion

        #region Decimal Numbers 

        [TestMethod]
        public void _006() => FivePointThreePlusTwoPointFourShouldGiveSevenPointSeven();

        [TestMethod]
        public void _007() => SevenPointFiveMinusTwoPointThreeShouldGiveFivePointTwo();

        #endregion

        #region Large Numbers 

        [TestMethod]
        public void _008() => OneThousandTwoHundredThirtyFourTimesFiveThousandSixHundredSeventyEigthShouldGive7006652();

        [TestMethod]
        public void _009() => _98745DividedBy54321ShouldEquals1Point8181();

        #endregion

        #region Error Handling 

        [TestMethod]
        public void _010() => DivisionByZeroShouldReturnErrorMessage();

        #endregion

        #region Clear Functionality 

        [TestMethod]
        public void _011() => EightPlusFiveBeforeClearShouldGiveZero();

        [TestMethod]
        public void _012() => EightPlusFiveBeforeClearEntryShouldGiveZero();

        #endregion

        #region Memory Functions 

        [TestMethod]
        public void _013() => AfterStoringFiveShouldRecallFive();

        #endregion

        [TestCleanup]
        public void TestCleanup()
        {
            IButton clearButton = GetButton(81);
            clearButton.Click();
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            GlobalTearDown();
        }
    }
}
