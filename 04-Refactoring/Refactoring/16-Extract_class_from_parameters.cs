namespace JetBrains.ReSharper.Koans.Refactoring
{
    // 从参数中提取类
    //
    // 基于一个方法的参数创建一个类, 并且在所有调用处创建该类
    //
    // 没有快捷键, 执行Refactor This后在弹出菜单中选择

    public class ExtractClassFromParameters
    {
        // 1. 从参数中提取类
        //    将光标放在方法的定义上, 执行Extract Class From Parameters (???)
        //    ReSharper prompts for options - name, class/struct, nested/top level
        //      and which parameters should be extracted
        public ExtractClassFromParameters(string forename, string surname, int age)
        {
        }

        public static ExtractClassFromParameters Create(string forename, string surname, int age)
        {
            // 2. Confirm call site has been updated to create parameter class
            return new ExtractClassFromParameters(forename, surname, age);
        }
    }
}
