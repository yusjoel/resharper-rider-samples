using System;

namespace JetBrains.ReSharper.Koans.Refactoring
{
    // 将方法转成属性
    //
    // 没有快捷键, 执行Refactor This后在弹出菜单中选择

    // 将属性转成方法
    //
    // 将属性转成getter和setter
    //
    // 没有快捷键, 执行Refactor This后在弹出菜单中选择

    public class ConvertMethodToProperty
    {
        // 1. 将方法转成属性
        //    方法不能有参数
        //    将光标放在方法的定义上, 执行Convert Method To Property
        //    ReSharper 会建议属性名, 确认后执行转换
        private string GetName()
        {
            return "Matt";
        }

        public void OutputName()
        {
            Console.WriteLine(GetName());
        }
    }

    public class ConvertPropertyToMethod
    {
        private string backingField;

        // 2. 将自动属性转换成方法
        //    将光标放在属性的定义上, 执行Convert Property To Method(s)
        //    你可以选择生成getter和setter, 确认后ReSharper会自动生成一个对应的字段
        public string AutoProperty { get; set; }

        // 3. 将属性转换成方法
        //    将光标放在属性的定义上, 执行Convert Property To Method(s)
        //    你可以选择生成getter和setter
        public string PropertyWithBackingField
        {
            get { return backingField; }
            set { backingField = value; }
        }

        // 4. 将只读的属性转换成方法
        //    将光标放在属性的定义上, 执行Convert Property To Method(s)
        //    只会生成getter
        public string GetterOnlyProperty { get { return backingField; } }

        public void Output()
        {
            // 5. 这里用来检查使用是否还正确
            Console.WriteLine(AutoProperty);
            Console.WriteLine(PropertyWithBackingField);
            Console.WriteLine(GetterOnlyProperty);
        }
    }
}
