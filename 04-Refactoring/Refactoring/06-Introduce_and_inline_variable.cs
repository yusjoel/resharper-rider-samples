using System;

namespace JetBrains.ReSharper.Koans.Refactoring
{
    // 引入变量
    //
    // 根据选中内容创建变量
    //
    // Ctrl+R, V (VS)
    // Ctrl+Alt+V (IntelliJ)

    // 内联变量
    //
    // 将对变量的使用替换重变量的内容
    //
    // Ctrl+R, I (VS)
    // Ctrl+Alt+N (IntelliJ)

    public class IntroduceAndInlineVariable
    {
        public void Calculate(int a, int b)
        {
            // 1. 引入变量
            //    选中 "a+b" (使用扩展选中 Ctrl+Alt+Right (VS) Ctrl+W (IntelliJ))
            //    执行 Introduce Variable
            //    确定类型或者'var', 已经变量名
            Console.WriteLine(a + b);
        }

        public void Calculate2(int a, int b)
        {
            // 2. 从多处使用中引入变量
            //    选中 "a+b" (使用扩展选中 Ctrl+Alt+Right (VS) Ctrl+W (IntelliJ))
            //    执行 Introduce Variable
            //    ReSharper会高亮所有使用, 并提示替换4处发现还是仅一处发现
            //    选择4处, 所有使用都会被替换
            Console.WriteLine(a + b);
            Console.WriteLine(a + b);
            Console.WriteLine(a + b);
            Console.WriteLine(a + b);
        }

        public void Calculate3(int a, int b)
        {
            // 3. 内联变量
            //    选择 "value", 执行Inline Variable
            //    变量会被移除, 并被替换成"a+b"
            var value = a + b;
            Console.WriteLine(value);
        }
    }
}
