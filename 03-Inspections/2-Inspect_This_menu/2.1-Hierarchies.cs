
namespace JetBrains.ReSharper.Koans.Inspections
{
    // "检查这里"菜单 - 结构
    //
    // 检查类的结构
    //
    // Ctrl+Shift+Alt+A (VS/IntelliJ)


    // 1. 显示IComponent的结构
    //    将光标放在"IComponent"上, 执行Inspect This, 然后选择Hierarchies
    //    结果会显示在检查窗口
    //    在工具栏上选择显示的类型如: Class(类), Subtypes(子类?), Supertypes(父类?), Implementation(实现) and Interface leaves(继承该接口的接口??)
    public interface IComponent
    {
    }


    // 2. 显示BaseClass的结构
    //    注意和IComponent不一样的是, 会显示类Object
    //    Implementation(实现)里面会显示BaseClass
    // TODO: 这段不确定
    public class BaseClass : IComponent
    {
    }

    public class DerivedClass1 : BaseClass
    {
    }

    public class DerivedClass2 : BaseClass
    {
    }

    public class DeepestDerivedClass : DerivedClass2
    {
    }

    public class UnrelatedClass : IComponent
    {
    }



    // 3. 显示UserControl的结构
    //    看到显示的内容不多, 取消选中"Show Elements from this Solution", 可以看到更多信息 (但实际没有)
    public class UserControl : BaseClass
    {
    }
}
