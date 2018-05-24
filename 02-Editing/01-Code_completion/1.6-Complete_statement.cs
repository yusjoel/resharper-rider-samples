using System;

namespace JetBrains.ReSharper.Koans.Editing
{
    // 语句补全
    //
    // 补全当前的语句,并且将光标移动下一个可编辑的位置.
    //
    // Ctrl+Shift+Enter (VS + IntelliJ)

    public class CompleteStatement
    {
        public void CompleteSimpleStatement()
        {
            // 1. 补全简单的语句
            //   取消下面语句的注释, 将光标放到语句内随意的位置
            //   执行 Complete Statement

            // Console.WriteLine("Hello
        }

        public void CompleteIfStatement()
        {
            // 2. 补全 if 语句
            //    取消下面语句的注释, 将光标放到语句内随意的位置
            //    执行 Complete Statement

            //if (true
        }

        public void CompleteComplexStatment()
        {
            // 3. 补全复杂语句
            //    取消下面语句的注释, 将光标放到语句内随意的位置
            //    执行 Complete Statement

            //Console.WriteLine(Blah("Hello"
        }

        #region Implementation details

        private string Blah(string value)
        {
            return value.ToUpperInvariant();
        }

        #endregion
    }
}
