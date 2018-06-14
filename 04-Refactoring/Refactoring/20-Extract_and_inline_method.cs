using System;
using System.Collections.Generic;
using System.Linq;

namespace JetBrains.ReSharper.Koans.Refactoring
{
    // 提取方法
    //
    // 根据选择的代码片段创建一个新的方法
    //
    // Ctrl+R, M (VS)
    // Ctrl+Alt+M (IntelliJ)

    // 内联方法
    //
    // 将调用方法替换成方法的内容，可以选择是否将原方法删除
    //
    // Ctrl+R, I (VS)
    // Ctrl+Alt+N (IntelliJ)

    public class ExtractMethod
    {
        public List<string> LongMethod(IEnumerable<string> items)
        {
            var results = new List<string>();
            foreach (var item in items)
            {
                // 1. 提取方法, 包含参数和返回值
                //    选择下面两行代码， 注意使用到了变量"item"并且创建了变量"result"
                //    执行 Extract Method, 确认方法名, 选择返回类型, 参数, 设置修饰符等等
                var result = item.ToUpperInvariant();
                result = new string(result.Reverse().ToArray());

                // 不要选中这行
                results.Add(result);
            }
            return results;
        }
    }

    public class InlineMethod
    {
        private const string Name = "Fred";

        public void SayHello()
        {
            // 2. 内联方法
            //    将光标放在方法名上, 执行Inline Method
            //    选中"Inline all usages"内联所有的使用, 和"Remove inlined method declaration"移除该方法的申明
            Console.WriteLine("Hello " + GetName());
            Console.WriteLine("Hi " + GetName());
        }

        public string GetName()
        {
            return Name;
        }
    }
}
