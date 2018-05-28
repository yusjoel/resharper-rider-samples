using System;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace JetBrains.ReSharper.Koans.Inspections
{
    public class Highlights
    {
        public string ErrorHighlight()
        {
            // 1. 高亮不正确的、很可能会编译不过的代码
            //    将下面的"null"替换成3000
            //    ReSharper 用红色的波浪线高亮错误的地方
            //    将鼠标放在代码上, 会提示: "Cannot convert expression type 'int' to return type 'string'"
            return null;
        }

        public void WarningHighlight()
        {
            const int condition = 42;

            // 2. 高亮潜在的不正确的、应该修正的代码
            //    ReSharper 用蓝色的波浪线标记出来
            //    将鼠标放在代码上, 会提示: "Expression is always true"
            if (condition == 42)
                Console.WriteLine("True");
        }

        public void SuggestionHighlight()
        {
            // 3. 高亮建议修改的代码
            //    ReSharper 用绿色的波浪线标记出来
            //    将鼠标放在代码上, 会提示: "Use method Any()"
            var files = Directory.GetFiles(@"C:\temp", "*.txt");
            if (files.Count() > 0)
                Console.WriteLine("Got some!");
        }

        public void HintHighlight()
        {
            PrivateMethodCanBeMadeStatic();
        }

        // 4. 高亮建议修改的代码， 但这个建议接受与否是可选的
        //    ReSharper会在高亮区域的开始处显示3个绿色小点
        //    将鼠标放在代码上, 会提示: "Method 'PrivateMethodCanBeMadeStatic' can be made static"
        private void PrivateMethodCanBeMadeStatic()
        {
        }

        public void DeadCode()
        {
            // 5. 高亮冗余的或者无法执行到的代码
            //    这些代码会显示为灰色
            //    将鼠标放在下面这行代码, 会提示: "Method invocation is skipped..."
            ConditionalMethod();

            return;

            // 将鼠标放在下面这行代码, 会提示: "Code is unreachable"
            Console.WriteLine("Hello");
        }

        [Conditional("UndefinedSymbol")]
        private void ConditionalMethod()
        {
        }
    }
}
