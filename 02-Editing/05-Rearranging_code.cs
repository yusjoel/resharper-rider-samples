using System;

namespace JetBrains.ReSharper.Koans.Editing
{
    // 重排代码
    //
    // 将代码元素上下左右向里向外移动
    //
    // Ctrl+Shift+Alt+Left/Right/Up/Down (VS + IntelliJ)

    public class RearrangingCode
    {
        public void RearrangeLines()
        {
            // 1. 将光标放到下面这行代码
            //    使用 Ctrl+Shift+Alt+Up/Down 来上下移动
            Console.WriteLine("One");
            Console.WriteLine("Two");
            Console.WriteLine("Three");
            Console.WriteLine("Four");
            Console.WriteLine("Five");
        }

        public void RearrangeExpressionOrder()
        {
            var value = 42;
            var newValue = 34;
            newValue++;

            // 2. 将光标放到 newValue 内
            //    使用 Ctrl+Shift+Alt+Left/Right 左右交换变量
            value = newValue;

            Console.WriteLine(value);
        }

        public void RearrangeParameterOrder()
        {
            const string hello = "hello";
            const string world = "world";
            const string foo = "foo";
            const string bar = "bar";

            // 3. 将光标放到 hello 内
            //    使用 Ctrl+Shift+Alt+Left/Right 左右移动参数
            MethodWithParameters(hello, world, foo, bar);
        }

        public void RearrangeInAndOut()
        {
            if (true)
            {
                // 4. 将光标放到 WriteLine 内
                //    使用 Ctrl+Shift+Alt+Up/Down 在if语句内部上下移动
                //    使用 Ctrl+Shift+Alt+Left 离开if语句
                //    使用 Ctrl+Shift+Alt+Up/Down 在if语句上下移动
                //    使用 Ctrl+Shift+Alt+Right 进入if语句
                Console.WriteLine("World");
                Console.WriteLine("Hello");
            }
        }

        // 5. 使用 Ctrl+Shift+Alt+Up/Down 移动注释的位置
        public void RearrangeComment()
        {
            // -> 我就是注释 <-
            Console.WriteLine("Hello");
            Console.WriteLine("World");
        }

        public void ExtendBlockWithGreedyBraces()
        {
            // 5. 将光标放在闭括号的外面
            //    使用 Ctrl+Shift+Alt+Down, 向下移动闭括号, 把下一行语句包含进if语句内
            //    使用 Ctrl+Shift+Alt+Up, 向上移动闭括号, 把上一回行语句排除到if语句外
            if (true)
            {
                Console.WriteLine("Hello");
            }

            Console.WriteLine("World");
        }

        private void MethodWithParameters(string p1, string p2, string p3, string p4)
        {
        }
    }
}
