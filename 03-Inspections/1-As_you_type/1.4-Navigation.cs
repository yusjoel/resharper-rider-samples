using System;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace JetBrains.ReSharper.Koans.Inspections
{
    // 在高亮之间导航
    //
    // Alt+PageUp / Alt+PageDn (VS)
    // F12 / Shift+F12 (IntelliJ)
    //
    // 在错误之间导航
    //
    // Shift+Alt+PageUp / ShiftAlt+PageDown (VS)
    // Alt+F12 / Shift+Alt+F12 (IntelliJ)

    public class Navigation
    {
        public string ErrorHighlight()
        {
            // 1.将"null"替换成3000, 让这里出现一个错误高亮
            return null;
        }

        public void WarningHighlight()
        {
            const int condition = 42;
            if (condition == 42)
                Console.WriteLine("True");
        }

        public void SuggestionHighlight()
        {
            var files = Directory.GetFiles(@"C:\temp", "*.txt");
            if (files.Count() > 0)
                Console.WriteLine("Got some!");
        }

        public void HintHighlight()
        {
            PrivateMethodCanBeMadeStatic();
        }

        // 2. 提示高亮不会被导航
        private void PrivateMethodCanBeMadeStatic()
        {
        }

        public void DeadCode()
        {
            ConditionalMethod();

            return;

            Console.WriteLine("Hello");
        }

        [Conditional("UndefinedSymbol")]
        private void ConditionalMethod()
        {
        }
    }
}
