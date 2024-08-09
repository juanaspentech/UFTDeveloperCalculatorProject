using HP.LFT.SDK;
using HP.LFT.SDK.StdWin;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static UftDeveloperCalculatorProject.CalculatorObjects;
using System.Collections.Generic;
using System;

namespace UftDeveloperCalculatorProject
{
    public static partial class CalculatorTests
    {

        public static void OneThousandTwoHundredThirtyFourTimesFiveThousandSixHundredSeventyEigthShouldGive7006652()
        {
            
            calculatorWindow.Activate();

            #region Action

            List<int> ids = new List<int>() { 131,132, 133,134,92,135,136,137,138,121};


            foreach (int id in ids) {

                IButton button = GetButton(id);
                button.Click();
            }

            var visibleText = textBox.GetVisibleText();
            #endregion


            #region Assert
            // Ensure that number "7006652" appears on the calculator's output screen. 
            Assert.AreEqual("7006652", visibleText);
            #endregion
        }

        public static void _98745DividedBy54321ShouldEquals1Point8181()
        {

            calculatorWindow.Activate();

            #region Action


            List<int> ids = new List<int>()
            { 139, 138, 137, 134, 135, 91, 135, 134, 133, 132, 131, 121};

            foreach (int id in ids)
            {

                IButton button = GetButton(id);
                button.Click();
            }

            double visibleNumber = double.Parse(textBox.GetVisibleText());
            #endregion
            string visibleText = Math.Round(visibleNumber, 2).ToString();
            

            #region Assert
            Assert.AreEqual("1.82", visibleText);
            #endregion
        }
    }
}
