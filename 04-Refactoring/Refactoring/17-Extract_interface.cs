using System;

namespace JetBrains.ReSharper.Koans.Refactoring
{
    namespace ExtractInterface
    {
        // 提取接口
        //
        // 从当前类中提取接口
        //
        // 没有快捷键, 执行Refactor This后在弹出菜单中选择

        // 1. 提取接口
        //    将光标放在类型定义上, 执行Extract Interface
        //    确认接口名, 位置和选择成员
        //    如果选择了私有或者保护的成员, ReSharper 会警告这些成员会自动变成公共
        public class Person
        {
            public Person(string forename, string surname, int age)
            {
                Forename = forename;
                Surname = surname;
                Age = age;

                Dump();
            }

            public string Forename { get; private set; }
            public string Surname { get; private set; }

            public string Fullname
            {
                get { return Forename + " " + Surname; }
            }

            public int Age { get; private set; }

            private void Dump()
            {
                Console.WriteLine("{0} is {1} years old", Fullname, Age);
            }
        }

        // 2. 从继承层次中提取接口
        //    将光标放在类型定义上, 执行Extract Interface
        //    确认接口名, 位置和选择成员, 这次成员中包含继承的成员
        //    如果选择了私有或者保护的成员, ReSharper 会警告这些成员会自动变成公共
        public class DerivedPerson : BasePerson
        {
            public DerivedPerson(string forename, string surname, int age, string title)
                : base(forename, surname, age)
            {
                Title = title;
            }

            public string Title { get; private set; }
        }

        public class BasePerson
        {
            public BasePerson(string forename, string surname, int age)
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
