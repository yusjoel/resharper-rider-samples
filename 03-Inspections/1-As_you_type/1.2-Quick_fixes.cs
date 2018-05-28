using System;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace JetBrains.ReSharper.Koans.Inspections
{
    // 快速修正
    //
    // 对高亮代码提供自动的修正
    //
    // Alt+Enter

    public class QuickFixes
    {
        public string ErrorHighlight()
        {
            // 1. 修正错误高亮, 自动提示将返回类型改成int, 或者调用ToString()
            //    将下面的"null"替换成3000
            //    ReSharper会显示错误的高亮
            //    将光标放在高亮区域, 按Alt+Enter
            //    选择 "Change type of method 'ErrorHighlight' to 'int'"
            //    或 "Call ToString()"
            return null;    // 这里换成3000
        }

        public void WarningHighlight()
        {
            const int condition = 42;

            // 2. 修正警告高亮
            //    将光标放在高亮区域, 按Alt+Enter
            //    选择 "Replace 'if' statement with respective branch"
            //    或 "Replace expression with 'true'"
            if (condition == 42)
                Console.WriteLine("True");
        }

        public void SuggestionHighlight()
        {
            // 3. 修正建议高亮
            //    将光标放在高亮区域, 按Alt+Enter
            //    选择 "Use method Any()"
            var files = Directory.GetFiles(@"C:\temp", "*.txt");
            if (files.Count() > 0)
                Console.WriteLine("Got some!");
        }

        public void HintHighlight()
        {
            PrivateMethodCanBeMadeStatic();
        }

        // 4. 修正提示高亮
        //    将光标放在高亮区域, 按Alt+Enter
        //    选择 "Make 'PrivateMethodCanBeMadeStatic' static"
        private void PrivateMethodCanBeMadeStatic()
        {
        }

        public void DeadCode()
        {
            return;


            // 5. 删除无法执行到的代码
            //    将光标放在高亮区域, 按Alt+Enter
            //    选择 "Remove unreachable code" 或 "Uncomment unreachable code"
            Console.WriteLine("Hello");
        }
    }
}
