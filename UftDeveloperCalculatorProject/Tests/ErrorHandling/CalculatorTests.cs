using HP.LFT.SDK;
using HP.LFT.SDK.StdWin;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static UftDeveloperCalculatorProject.CalculatorObjects;
using System.Collections.Generic;
using HP.LFT.Verifications;

namespace UftDeveloperCalculatorProject
{
    public static partial class CalculatorTests
    {

        public static void DivisionByZeroShouldReturnErrorMessage()

        {

            #region Arrange
            calculatorWindow.Activate();
            #endregion

            #region Action
            List<int> ids = new List<int>() { 135, 91, 130, 121 };

            foreach (int id in ids) {
            
                IButton button =GetButton(id);
                button.Click(); 
            }

            var visibleText = textBox.GetVisibleText();
            #endregion


            #region Assert
            Assert.AreEqual("Cannot divide bv zero", visibleText, "DivisionByZeroShouldReturnErrorMessage", "Verify that the correct error message appears when dividing by zero.");
            #endregion

        }
    }
}
