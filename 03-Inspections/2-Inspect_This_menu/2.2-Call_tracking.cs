using System;

namespace JetBrains.ReSharper.Koans.Inspections
{
    // "检查这里"菜单 - 调用跟踪
    //
    // 查看调用和被调用的方法
    //
    // Ctrl+Shift+Alt+A (VS/IntelliJ)

    public class CallTracking
    {
        // 1. 显示MethodOne调用的方法
        //    将光标放在"MethodOne"上, 执行Inspect This
        //    选择 Outgoing Calls
        //    结果会显示在一个新的检查窗口
        //    展开树状结构, 可以深入到调用堆栈中, 最后可以看到调用了方法MethodFive
        public void MethodOne()
        {
            MethodTwo();
        }

        public void MethodTwo()
        {
            MethodThree();
            MethodThree();
        }

        public void MethodThree()
        {
            MethodFive();
            MethodSix();
        }

        public void MethodFour()
        {
            MethodFive();
            MethodSix();
        }

        // 2. 显示所有调用MethodFive的方法
        //    将光标放在"MethodFive"上, 执行Inspect This
        //    选择 Incoming Calls
        //    结果会显示在一个新的检查窗口
        //    展开树状结构, 可以在调用堆栈中向上回溯, 最后看到最终的调用者是MethodOne
        //
        // 3. 点击Show Preview按钮, 打开结果窗口中的预览面板
        public void MethodFive()
        {
            Console.WriteLine();
            Console.Out.WriteLine();
        }

        public void MethodSix()
        {
            Console.WriteLine();
            Console.Out.WriteLine();
        }
    }
}
