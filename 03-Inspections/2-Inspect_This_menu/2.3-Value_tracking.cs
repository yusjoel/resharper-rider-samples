using System;

namespace JetBrains.ReSharper.Koans.Inspections
{
    // "检查这里"菜单 - 值跟踪
    //
    // 跟踪调用中的值
    //
    // Ctrl+Shift+Alt+A (VS/IntelliJ)
    public class ValueTracking
    {
        // 1. 寻找参数"value"最终用到了哪里
        //    将光标放在"value"上, 执行Inspect This
        //    选择 Value Destination (值的去向)
        //    结果会显示在一个新的检查窗口
        //    第一个结果显示该值在MethodOne中被使用
        //    展开树状结构, 显示该值在调用的方法中的使用
        //    即便是通过Lambda表达式和属性, 也可以在调用堆栈中向下深入, 找到该值最终的使用
        public void MethodOne(int value)
        {
            if (value%2 == 0)
            {
                MethodTwo(() => value);
            }
            else
            {
                MethodThree(new HelpfulClass(value));
            }
        }

        public class HelpfulClass
        {
            public int Value { get; private set; }

            public HelpfulClass(int value)
            {
                Value = value;
            }
        }

        public void MethodTwo(Func<int> newValue)
        {
            MethodThree(new HelpfulClass(newValue()));
        }

        private void MethodThree(HelpfulClass changedValue)
        {
            MethodFour(changedValue.Value);
        }

        private void MethodFour(int anotherValue)
        {
            MethodFive(anotherValue);
        }

        private void MethodFive(int finalValue)
        {
            // 2. 寻找参数"finalValue"从哪里来
            //    将光标放在"finalValue"上, 执行Inspect This
            //    选择 Value Origin (值来源)
            //    结果会显示在一个新的检查窗口
            //    展开树状结构, 在调用堆栈中寻找该值的来源
            //
            // 3. 点击Show Preview按钮, 打开结果窗口中的预览面板
            Console.WriteLine(finalValue);
        }
    }
}
