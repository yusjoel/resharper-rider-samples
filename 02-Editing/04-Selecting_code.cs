using System;

namespace JetBrains.ReSharper.Koans.Editing
{
    public class SelectingCode
    {
        // 扩大/缩小选中范围
        //
        // Ctrl+Alt+Right and Ctrl+Alt+Left (VS)
        // Ctrl+W and Shift+Ctrl+W
        //
        // 选择块
        //
        // Ctrl+Shift+[

        public void ExtendAndShrinkSelection()
        {
            // 1. 将光标放在 "importanValue" 内, 然后执行 Expand selection, 选中了整个单词
            //    再执行 Expand selection 选中了整行
            //    再执行 Expand selection 选中了整个方法体
            //    再执行 Expand selection 选中了整个方法
            //    再执行 Expand selection 选中了整个类体
            //    再执行 Expand selection 选中了整个类
            //    再执行 Expand selection 选中了整个命名空间
            //    再执行 Expand selection 选中了整个文件
            // 2. 将光标放在 "importanValue" 内, 然后执行 Expand selection 几次, 再执行 Shrink selection 几次
            var importantValue = 32;
            if (importantValue > 42)
            {
                try
                {
                    // 3. 将光标放在 WriteLine 内, 重复步骤2
                    Console.WriteLine("Hello");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }

        // 4. ReSharper → Options → Environment → Editor → Editor Behavior
        //    选中 Use CamelHumps
        //    将光标放在下面的方法名内, 试试扩大/缩小选中范围
        //    还可以试一下用 Ctrl+Left 和 Ctrl+Right 在方法名内左右移动
        public void ExtendAndShrinkSelectionWithCamelHumps()
        {
            var importantValue = 32;
            if (importantValue > 42)
            {
                try
                {
                    Console.WriteLine("Hello");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }

        // 5. 将光标放在方法内任意位置, 重复执行Select Block
        public void SelectBlock()
        {
            var importantValue = 32;
            if (importantValue > 42)
            {
                try
                {
                    Console.WriteLine("Hello");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }
    }
}
