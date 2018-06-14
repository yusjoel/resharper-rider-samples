using System;

namespace JetBrains.ReSharper.Koans.Refactoring
{
    // 将抽象类转换成接口
    //
    // 没有快捷键, 执行Refactor This后在弹出菜单中选择

    // 将接口转换成抽象类
    //
    // 没有快捷键, 执行Refactor This后在弹出菜单中选择


    // 1. 将抽象类转换成接口
    //    将光标放在类定义上, 执行Convert Abstract Class to Interface
    public abstract class AbstractClass
    {
        public abstract string Name { get; protected set; }
    }

    public class DerivedClass : AbstractClass
    {
        private string name;

        public DerivedClass()
        {
            name = "Phil";
        }

        public override string Name
        {
            get { return name; }
            protected set { name = value; }
        }
    }

    // 2. 抽象类中有实现代码的情况, 将抽象类转换成接口
    //    将光标放在类定义上, 执行Convert Abstract Class to Interface
    //    ReSharper 会警告抽象类中有已实现方法
    //    可以取消, 也可以继续转换, 所有实现会被移除, 衍生类会无法编译通过
    public abstract class AbstractClassWithImplementation
    {
        public abstract string Name { get; protected set; }

        public void SayHello()
        {
            Console.WriteLine("Hello " + Name);
        }
    }

    public class DerivedClass2 : AbstractClassWithImplementation
    {
        private string name;

        public DerivedClass2()
        {
            name = "Phil";
        }

        public override string Name
        {
            get { return name; }
            protected set { name = value; }
        }
    }

    // 3. 将接口转换成抽象类
    //    将光标放在接口定义上, 执行Convert Interface to Abstract Class
    //    ReSharper会创建抽象类, 其中没有任何实现, 然后在衍生类中所有实现方法前加上"override"关键字
    public interface IPerson
    {
        string Name { get; }
        void SayHello();
    }

    public class Person : IPerson
    {
        private readonly string name;

        public Person(string name)
        {
            this.name = name;
        }

        public string Name { get { return name; } }

        public void SayHello()
        {
            Console.WriteLine("Hello " + Name);
        }
    }
}
