using System;

namespace JetBrains.ReSharper.Koans.Editing
{
    public class UndefinedSymbols
    {
        public void CreateFromUsage(int a, int b)
        {
            // 1. 根据使用创建代码
            //    取消下面几行代码的注释
            //    选中"Calculator", 按下Alt+Enter, 选择Create type 'Calculator'
            //    选中"Add", 按下Alt+Enter, 选择Create method 'Calculator.Add'

            //var calculator = new Calculator();
            //if (calculator.Add(a, b) > 100)
            //    Console.WriteLine("Winner!");
        }

        public void ChangeAllLocal()
        {
            const int result = 23;

            // 2. 修改所有局部变量
            //    修改当前方法内未定义的符号所有的使用
            //    取消下面几行代码的注释
            //    选中未定义的符号"value", 按Alt+Enter
            //    选择 Change all local 'value'
            //    ReSharper会建议几个合适的选项: 当前方法内的"result", 和字段"NewValue"
            //    选择其中一个修改所有value的使用

            //Console.WriteLine(value);
            //Console.WriteLine(value);
            //Console.WriteLine(value);
        }

        public const int NewValue = 42;

        public void ChangeAll()
        {
            const int localValue = 100;

            // 2. 修改所有变量
            //    修改各个方法内未定义的符号所有的使用
            //    取消下面几行代码的注释, 还有ChangeAll2内的代码的注释
            //    选中未定义的符号"value", 按Alt+Enter
            //    选择 Change all 'value'
            //    ReSharper会建议字段"NewValue", 但是不会包括局部变量localValue
            //    接受这唯一的建议, 修改所有value的使用

            //Console.WriteLine(value);
            //Console.WriteLine(value);
            //Console.WriteLine(value);
        }

        public void ChangeAll2()
        {
            //Console.WriteLine(value);
            //Console.WriteLine(value);
            //Console.WriteLine(value);
        }
    }

}
