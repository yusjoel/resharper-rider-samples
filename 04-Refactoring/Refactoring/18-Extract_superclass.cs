using System;

namespace JetBrains.ReSharper.Koans.Refactoring
{
    namespace ExtractSuperclass
    {
        // 提取超类
        //
        // 将当前类的成员提取为新的基类
        //
        // 没有快捷键, 执行Refactor This后在弹出菜单中选择

        // 1. 提取超类
        //    将光标放在类型定义上, 执行Extract Superclass
        //    确认基类的名字, 位置和成员, 这里选中Forename、Surname和Age
        //    ReSharper会创建一个包含这些成员的基类, 并且继承它
        public class Person
        {
            public Person(string forename, string surname, int age)
            {
                Forename = forename;
                Surname = surname;
                Age = age;
            }

            public string Forename { get; private set; }
            public string Surname { get; private set; }

            public string Fullname
            {
                get { return Forename + " " + Surname; }
            }

            public int Age { get; private set; }
        }

        // 2. 从继承层次中提取超类
        //    将光标放在类型定义上, 执行Extract Superclass
        //    确认基类的名字, 位置和成员, 这次成员中包含继承的成员
        //    这里选中SayHello
        public class TitledPerson : SimplePerson
        {
            public TitledPerson(string forename, string surname, int age, string title)
                : base(forename, surname, age)
            {
                Title = title;
            }

            public string Title { get; private set; }

            public void SayHello()
            {
                Console.WriteLine("Hello {0}", Forename);
            }
        }

        public class SimplePerson
        {
            public SimplePerson(string forename, string surname, int age)
            {
                Forename = forename;
                Surname = surname;
                Age = age;
            }

            public string Forename { get; private set; }
            public string Surname { get; private set; }
            public int Age { get; private set; }
        }
    }
}
