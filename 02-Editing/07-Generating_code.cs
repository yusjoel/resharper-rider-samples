using System;

namespace JetBrains.ReSharper.Koans.Editing
{
    // 生成代码
    //
    // 显示当前位置上可以生成代码的可选项菜单
    //
    // Alt+Insert (文本编辑器)
    //
    // (在解决方案浏览器中 Alt+Insert 会触发文件模板的生成菜单, 参考 Live Templates 部分)

    public class InsertConstructor
    {
        // 1. 插入构造函数
        //    将光标放在类体内
        //    执行 Generate Code, 选择 Constructor 
        //    光标会在输入参数的位置
    }

    public class InsertConstructorWithParameters
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        // 1. 插入构造函数
        //    将光标放在类体内
        //    执行 Generate Code, 选择 Constructor 
        //    选择属性作为构造函数的参数
    }

    public class GenerateOverridingMembers : BaseClass
    {
        // 2. 生成重载成员
        //    将光标放在类体内
        //    执行 Generate Code, 选择 Overriding Members
        //    选择要重载的成员


    }

    public class GenerateEquality
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        // 3. 生成 等同性成员
        //    将光标放在类体内
        //    执行 Generate Code, 选择 等同性成员
        //    选择要作为等同性比较的成员, 之后会生成 Equals 和 GetHashCode
        //    也可以勾上 overload equals operators 选项, 会重载==和!=

    }


    public class GenerateDelegatingMembers
    {
        private readonly IService service;

        public GenerateDelegatingMembers(IService service)
        {
            this.service = service;
        }

        // 4. 生成委托成员
        //    对一个指定类型的字段, 对这个内部实例创建委托的成员
        //    将光标放在类体内
        //    执行 Generate Code, 选择 Delegating members
        //    选择要委托的成员
        //    如果所有的成员都要实现, 那么这里类应该直接实现IService

    }

    public class GenerateFromUsage
    {
        // 5. Generate from usage
        //    Alt+Enter on missing symbols to generate them


        // 5.1 生成变量
        //     取消 Console.WriteLine 语句的注释, 参数 message 会显示为未定义
        //     选中"message", 按 Alt+Enter, 选择Create local variable 'message'
        //     然后选择类型, 按Tab键光标移动到变量后, 可以给它赋初值
        public void GenerateVariable()
        {
            //Console.WriteLine(message);
        }

        // 5.2 生成方法
        //     取消下面两行语句的注释, 方法GetMessage会显示为未定义
        //     选中"GetMessage", 按Alt+Enter, 选择Create method 'GetMessage'
        //     ReSharper 会自动推断出该方法的参数和返回类型
        public void GenerateMethod()
        {
            //string message = GetMessage(42);
            //Console.WriteLine(message);
        }

        // 5.3 生成类 (这个功能对测试驱动开发TDD很有用!)
        //     取消下面几行语句的注释. 类型Processor会显示为未定义
        //     选中"Processor", 按Alt+Enter, 选择Create type 'Processor'
        //     ReSharper 会生成类和构造函数
        //     按Tab键调整各个可选项
        public void GenerateClass()
        {
            //var message = new Message();
            //var processor = new Processor(message);
            //Console.WriteLine(processor);
        }
    }

    public class GenerateSwitchLabels
    {
        public void Method(DayOfWeek day)
        {
            // 6. 生成 switch 标签
            //    将光标放在switch语句内
            //    按 Alt+Enter, 然后选择 Generate switch labels
            switch (day)
            {

            }
        }
    }

    #region Implementation details

    public class BaseClass
    {
        public virtual void VirtualMethod()
        {
        }

        public virtual string VirtualProperty { get { return "hello"; } }
    }

    public interface IService
    {
        void SayHello();
        void Shout();
        int Choose(string options);
    }

    public class Message
    {
        public string Id { get; set; }
        public string Body { get; set; }
    }

    #endregion
}
