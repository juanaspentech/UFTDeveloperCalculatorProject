using HP.LFT.SDK.StdWin;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using static UftDeveloperCalculatorProject.CalculatorObjects;

namespace UftDeveloperCalculatorProject
{
    public  static partial class CalculatorTests
    {

       

        public static void TwoPlusThreeShouldGiveFive()
        {
            #region Arrange
            calculatorWindow.Activate();
            #endregion

            #region Action
            List<int> ids = new List<int>() { 132, 93, 133, 121};
            foreach (int id in ids)
            {
                IButton button = GetButton(id);
                button.Click();

            }

            var visibleText = textBox.GetVisibleText();
            #endregion

            #region Assert
            Assert.AreEqual("5", visibleText, "TwoPlusThreeShouldGiveFive", "Verify that the number '5' appears on the calculator's output screen.");
            #endregion
        }



        public static void FiveMinusThreeShouldGiveTwo()
        {

            #region Arrange
            calculatorWindow.Activate();
            #endregion

            #region Action

            List<int> ids = new List<int>() { 135, 94, 133, 121};
            foreach (int id in ids)
            {
                IButton button = GetButton(id);
                button.Click();

            }

            var visibleText = textBox.GetVisibleText();
            #endregion

            #region Assert 
            Assert.AreEqual("2", visibleText);
            #endregion

        }


        public static void SixTimesSevenShouldGiveFourtyTwo()
        {
            calculatorWindow.Activate();

            List<int> ids = new List<int>() { 136, 92, 137, 121 };
            foreach (int id in ids)
            {
                IButton button = GetButton(id);
                button.Click();

            } 

            var visibleText = textBox.GetVisibleText();

            #region Assert 
            Assert.AreEqual("42", visibleText);
            #endregion

        }

        public static void NineDividedByThreeShouldGiveThree()
        {
            
            calculatorWindow.Activate();

            List<int> ids = new List<int>() { 139, 91, 133, 121 };
            foreach (int id in ids)
            {
                IButton button = GetButton(id);
                button.Click();

            }


            var visibleText = textBox.GetVisibleText();

            #region Assert 
            Assert.AreEqual("3", visibleText);
            #endregion
        }
    }
}
