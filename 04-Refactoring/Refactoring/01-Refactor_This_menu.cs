using System;

namespace JetBrains.ReSharper.Koans.Refactoring
{
    // "重构这里"菜单
    //
    // 显示当前位置可用的重构的上下文菜单
    //
    // Ctrl+Shift+R

    // 1. 对类型定义、方法、属性、参数、变量等等执行Refactor This
    //    可以看到对不同的元素显示的选项也是不同的
    //    更多不同的重构操作会在后面的部分说明细节内容
    public class Class1 // <- 对类执行Refactor This
    {
        // 对字段执行Refactor This
        public readonly int field;

        // 对属性执行Refactor This
        public string Property { get; set; }

        // 对方法、参数执行Refactor This
        public void Method(string parameter1, int parameter2)
        {
            // 对变量执行Refactor This
            var variable = parameter1;
            Console.WriteLine(variable);
        }
    }
}
