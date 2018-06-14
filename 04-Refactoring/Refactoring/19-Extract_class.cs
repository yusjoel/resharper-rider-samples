using System;

namespace JetBrains.ReSharper.Koans.Refactoring
{
    namespace ExtractClass
    {
        // 提取类
        //
        // 根据当前类的成员创建一个新的类
        // 对提取的成员的引用会更新成对新生成的类的实例的引用
        //
        // 没有快捷键, 执行Refactor This后在弹出菜单中选择

        public class Person
        {
            public string Forename { get; set; }
            public string Surname { get; set; }
            public int Age { get; set; }

            // 1. 将地址信息提取成一个新类
            //    选择要提取的成员，也就是下面5个属性，执行Extract Class
            //    ReSharper会弹出一个对话框， 选中的属性已经被勾选
            //    给提取的新类起一个名字，如Address
            //    在默认情况下， 原来的属性会被删除
            //      但也可以在 "Source class member" 栏中进行选择:
            //      None - 原来的属性会被删除
            //      Create delegating wrapper - 对原属性的调用会变成访问提取的类的实例
            //      Create copy - 会保留原属性
            public string HouseNumber { get; set; }
            public string Street { get; set; }
            public string County { get; set; }
            public string PostCode { get; set; }
            public string Country { get; set; }
        }

        public class PersonConsumer
        {
            public void Method()
            {
                var person = new Person();

                // 2. 这里用来检查应用是否还正确
                Console.WriteLine(person.HouseNumber);
                Console.WriteLine(person.Street);
                Console.WriteLine(person.County);
                Console.WriteLine(person.PostCode);
                Console.WriteLine(person.Country);
            }
        }
    }
}
