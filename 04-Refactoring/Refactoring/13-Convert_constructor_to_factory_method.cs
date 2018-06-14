namespace JetBrains.ReSharper.Koans.Refactoring
{
    // 将构造函数转换为工厂方法
    //
    // 创建一个静态的工程方法来调用构造函数, 使构造函数私有.
    //
    // 没有快捷键, 执行Refactor This后在弹出菜单中选择

    public class ConvertConstructorToFactoryMethod
    {
        // 1. 将构造函数转换为工厂方法
        //    将光标放在构造函数的定义上, 执行Replace Constructor With Factory Method
        //    填写工厂方法的名字以及创建该方法的类型, 这个类型必须已经存在, 并且要填写完全限定的类型名称
        public ConvertConstructorToFactoryMethod(string forename, string surname, int age)
        {
        }
    }

    public class ConstructorConsumer
    {
        public void Method()
        {
            // 2. 确认构造函数已经被工厂方法替换
            var @class = new ConvertConstructorToFactoryMethod("Debbie", "Harry", 23);
        }
    }
}
