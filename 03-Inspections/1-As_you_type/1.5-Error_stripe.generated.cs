using System;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace JetBrains.ReSharper.Koans.Inspections
{
    // 1. 生成的代码不会进行警告和建议的分析
    //    这个文件的文件名是*.generated.cs, 所以被认为是生成的代码
    //    (比如在Windows Forms designer用到)
    //    自定义的文件名可以在 ReSharper → Options → Code Inspection → Generated Code 中进行配置

    public class ErrorStripeGenerated
    {
        public string ErrorHighlight()
        {
            // 2. 将"null"替换成3000, 让这里出现一个错误高亮
            //    错误仍然会高亮
            return null;
        }

        public void WarningHighlight()
        {
            // 3. 但是警告不会
            const int condition = 42;
            if (condition == 42)
                Console.WriteLine("True");
        }

        public void SuggestionHighlight()
        {
            // 4. 建议不会
            var files = Directory.GetFiles(@"C:\temp", "*.txt");
            if (files.Count() > 0)
                Console.WriteLine("Got some!");
        }

        public void HintHighlight()
        {
            PrivateMethodCanBeMadeStatic();
        }

        // 5. 提示不会
        private void PrivateMethodCanBeMadeStatic()
        {
        }

        public void DeadCode()
        {
            // 6. 冗余代码不会
            ConditionalMethod();

            return;

            // 7. 执行不到的代码依旧高亮
            Console.WriteLine("Hello");
        }

        [Conditional("UndefinedSymbol")]
        private void ConditionalMethod()
        {
        }
    }
}
