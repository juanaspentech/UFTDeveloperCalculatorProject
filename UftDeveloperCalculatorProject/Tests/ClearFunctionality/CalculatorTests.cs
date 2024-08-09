using HP.LFT.SDK;
using HP.LFT.SDK.StdWin;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using static UftDeveloperCalculatorProject.CalculatorObjects;

namespace UftDeveloperCalculatorProject
{
    public static partial class CalculatorTests
    {

        public static void EightPlusFiveBeforeClearShouldGiveZero()
        {

            #region Arrange
            calculatorWindow.Activate();
            #endregion

            #region Action

            List<int> ids = new List<int>() { 138, 93, 135, 81 };

            foreach (int id in ids)
            {
                IButton button = GetButton(id);
                button.Click();
            }

            var visibleText = textBox.GetVisibleText();
            #endregion

            #region Assert
            Assert.AreEqual("0", visibleText);
            #endregion
        }


        public static void EightPlusFiveBeforeClearEntryShouldGiveZero()
        {
            #region Arrange
            calculatorWindow.Activate();
            #endregion

            #region Action
            List<int> ids = new List<int>() { 138, 93, 135, 82 };


            foreach (int id in ids)
            {

                IButton button = GetButton(id);
                button.Click();

            }

            var visibleText = textBox.GetVisibleText();
            #endregion

            #region Assert
            Assert.AreEqual("0", visibleText);
            #endregion
        }
    }
}
