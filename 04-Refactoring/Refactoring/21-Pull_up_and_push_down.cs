using System;

namespace JetBrains.ReSharper.Koans.Refactoring
{
    // 提升成员层次
    //
    // 从当前类将成员提升到基类
    //
    // 没有快捷键, 执行Refactor This后在弹出菜单中选择

    // 降低成员层次
    //
    // 从当前类将成员降低到继承类
    //
    // 没有快捷键, 执行Refactor This后在弹出菜单中选择

    namespace PullUp
    {
        public class Base
        {
        }

        public class Derived : Base
        {
        }

        // 1. 将成员提升到基类
        //    将光标放在"MostDerived"上, 执行Pull Members Up
        //    选择要提升到的类型, Derived 还是 Base
        //    选择要提升的成员
        public class MostDerived : Derived
        {
            public string PropertyOnDerived { get; set; }
        }
    }

    namespace PushDown
    {
        // 2. 将成员降低到继承类中
        //    将光标放在"Base"上, 执行Push Members Down
        //    选择要降低到的类型, Derived 还是 Derived2
        //    选择要降低的成员
        public class Base
        {
            public string PropertyOnBase { get; set; }

            // a. 降低被使用的成员的层次
            //    将光标放在"UsedPropertyOnBase"上, 执行Push Members Down
            //    选择要降低到的类型, Derived 还是 Derived2
            //    UsedPropertyOnBase已经被默认选中了
            //    ReSharper 会警告UsedPropertyOnBase不能降低层次
            public string UsedPropertyOnBase { get; set; }
        }

        public class Derived : Base
        {
        }

        public class Derived2 : Base
        {
        }

        public class Consumer
        {
            public void Method()
            {
                var @base = new Base();
                Console.WriteLine(@base.UsedPropertyOnBase);
            }
        }
    }
}
