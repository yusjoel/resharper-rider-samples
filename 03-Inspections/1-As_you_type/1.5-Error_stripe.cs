using System;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace JetBrains.ReSharper.Koans.Inspections
{
    // 高亮会反应在文本编辑器右侧的错误条上
    //
    // 1. 将鼠标停留在错误条的每个标记上
    //    可以看到提示文字
    //    点击标记可以导航到代码
    // 2. 注意右上方的图标. 显示当前代码是否有警告、建议或者错误存在
    //    目标是让这个图标变绿

    public class ErrorStripe
    {
        public string ErrorHighlight()
        {
            // 1. 将"null"替换成3000, 让这里出现一个错误高亮
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

        // 2.  提示高亮不会出现在错误条上
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
