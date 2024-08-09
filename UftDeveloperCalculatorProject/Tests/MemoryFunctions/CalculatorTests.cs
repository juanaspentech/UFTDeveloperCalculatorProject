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
        public static void AfterStoringFiveShouldRecallFive()
        {

            #region Arrange
            calculatorWindow.Activate();
            #endregion

            #region Action
            List<int> ids = new List<int>() { 135, 124, 136, 123,  };

            foreach (int id in ids)
            {
                IButton button = GetButton(id);
                button.Click(); 
            }

            var visibleText = textBox.GetVisibleText();
            #endregion


            #region Assert 
            Assert.AreEqual("5", visibleText);
            #endregion
        }
    }
}
