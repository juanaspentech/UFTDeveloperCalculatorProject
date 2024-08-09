using HP.LFT.SDK;
using HP.LFT.SDK.StdWin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UftDeveloperCalculatorProject
{
    public static class CalculatorObjects
    {
        #region General objects
        // Main Window calculator
        public static IWindow calculatorWindow = Desktop.Describe<IWindow>(new WindowDescription
        {
            IsChildWindow = false,
            IsOwnedWindow = false,
            WindowClassRegExp = @"CalcFrame",
            WindowTitleRegExp = @"Calculator"
        });


        // Locate the calculator's output screen. 
        public static IStatic textBox = calculatorWindow.Describe<IStatic>(
        new StaticDescription { WindowId = 150, NativeClass = "Static" });

        #endregion

        #region Getters for create more specific objects
        public static IButton GetButton(int WindowId)
        {

            return  calculatorWindow.Describe<IButton>(new ButtonDescription
            {
                NativeClass = @"Button",
                Text = string.Empty,
                WindowId = WindowId
            });
        }

        #endregion
    }
}
