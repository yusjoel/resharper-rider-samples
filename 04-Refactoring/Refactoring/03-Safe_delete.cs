using System;

namespace JetBrains.ReSharper.Koans.Refactoring
{
    // 安全删除
    //
    // 仅在该代码元素没有使用时进行删除
    //
    // Ctrl+R, D (VS)
    // Alt+Delete (IntelliJ)

    public class ClassWithUsedAndUnusedField
    {
        // 1. 安全删除没有使用的字段
        //    将光标放在"UnusedField"上, 执行Safe Delete
        //    点击"Next >", 这个字段就会被删除
        public string UnusedField = "hello world";

        // 2. 安全删除使用的字段
        //    将光标放在"UsedField"上, 执行Safe Delete
        //    点击"Next >", ReSharper会警告这个字段被使用
        //    点击文字"Usage"跳转到使用的地方, 可以修改或者删除使用的代码
        //    点击"Next >"可以强行删除该字段, 也可以点"Cancel"离开
        public string UsedField = "hello world";

        // 3. 安全删除没有使用的参数
        //    将光标放在"unusedParameter"上, 执行Safe Delete
        //    这个参数在方法内没有被使用到, 所以被删除了
        //    调用该方法时传入的值也被删除了
        // 3a.  安全删除使用的参数
        //     将光标放在"usedParameter"上, 执行Safe Delete
        //     ReSharper会警告这个参数被使用, 同样可以跳转到使用的地方
        //     点击"Next >"可以强行删除该参数, 也可以点"Cancel"离开
        public void Method(string usedParameter, string unusedParameter)
        {
            Console.WriteLine(usedParameter);
        }

        public void Method2()
        {
            Method("hi", null);
        }
    }

    // 4. 安全删除没有使用的类
    //    将光标放在"UnusedClass"上, 执行Safe Delete
    //    ReSharper会询问是否要删除空文件
    //    点"Next >"会分析该类的使用, 如果没有找到使用会直接删除
    //    如果文件内没有其他定义, 那么文件也会被删除
    public class UnusedClass
    {
    }

#region Implementation details

    public class User
    {
        public static void Method()
        {
            // 按Ctrl+-返回
            Console.WriteLine(new ClassWithUsedAndUnusedField().UsedField);
        }
    }

#endregion
}
