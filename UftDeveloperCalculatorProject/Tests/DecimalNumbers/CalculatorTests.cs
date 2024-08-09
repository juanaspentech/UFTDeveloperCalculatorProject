using HP.LFT.SDK;
using HP.LFT.SDK.StdWin;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static UftDeveloperCalculatorProject.CalculatorObjects;
using System.Collections.Generic;

namespace UftDeveloperCalculatorProject
{
    public static partial class CalculatorTests
    {

        public static void FivePointThreePlusTwoPointFourShouldGiveSevenPointSeven()
        {
            #region Arrange
            calculatorWindow.Activate();
            #endregion

            #region Action
            List<int> ids = new List<int>() { 135, 84, 133, 93, 132, 84, 134, 121 };
            foreach (int id in ids) 
            {
                IButton button = GetButton(id);
                button.Click();

            }
            var visibleText = textBox.GetVisibleText();
            #endregion


            #region Assert
            // Ensure that number "7.7" appears on the calculator's output screen. 
            Assert.AreEqual("7.7", visibleText);
            #endregion
        }

        public static void SevenPointFiveMinusTwoPointThreeShouldGiveFivePointTwo()
        {

            #region Arrange
            calculatorWindow.Activate();
            #endregion

            #region Action
            List<int> ids = new List<int>() { 137, 84, 135, 94, 132, 84, 133, 121 };

            foreach (int id in ids)
            {
                IButton button = GetButton(id);
                button.Click();

            }

            var visibleText = textBox.GetVisibleText();
            #endregion

            #region Assert
            // Ensure that number "5.2" appears on the calculator's output screen. 
            Assert.AreEqual("5.2", visibleText);
            #endregion

        }


    }
}
