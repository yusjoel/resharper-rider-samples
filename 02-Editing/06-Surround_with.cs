using System;

namespace JetBrains.ReSharper.Koans.Editing
{
    // 包围
    //
    // 将选中的内容替换成指定内容, 并将选中内容包含在内
    //
    // Ctrl+E, U (VS)
    // Ctrl+Alt+J (IntelliJ)
    // Alt+Enter
    //
    // 参见 Live Templates

    public class SurroundWith
    {
        public void SurroundSingleLineWithTryCatch()
        {
            // 1. 将光标放到下面的代码中
            //    执行 Surround With
            //    选择 8. try
            Console.WriteLine("This might throw");
        }

        public void SurroundMultipleLinesWithTryCatch()
        {
            // 2. 选中下面的两行代码
            //    执行 Surround with
            //    选择 8. try
            Console.WriteLine("Hello");
            Console.WriteLine("World");
        }

        public void SurroundWithContextAction()
        {
            // 实验无效果
            // 3. Select the Console.WriteLine statement
            //    Invoke Surround With by using Alt+Enter
            //    Select { }
            if (true)
                Console.WriteLine("Hello world");
        }
    }
}
