namespace JetBrains.ReSharper.Koans.Refactoring
{
    // 移动
    //
    // 将类型移动到另一个文件、文件夹或者命名空间
    //
    // Ctrl+R, O (VS)
    // F6 (IntelliJ)

    // 1. 移动到另一个文件
    //    将光标放在类的定义上, 执行Move
    //    选择 "Move To Another File"
    //    ReSharper会建议一个文件名
    //    接受后该类会移动到另一个文件, 现存的代码仍旧可以运行
    public class MoveToAnotherFile
    {
        public void Method()
        {
        }
    }

    // 2. 移动到当前工程中的另一个文件夹
    //    将光标放在类的定义上, 执行Move
    //    选择 "Move To Folder"
    //    ReSharper会建议要移动的类和要移动到的文件夹
    //    也可以输入新地址, ReSharper会提供已有的工程或文件夹作为建议
    //    在最后加入"\MoveTarget",  ReSharper 显示一个错误图标, 提示文件夹不存在
    //    点击 "Create this folder", 创建这个文件夹
    //    移动完成后, 可以看到该类移动到新的位置
    public class MoveToAnotherFolderInProject
    {
        public void Method()
        {
        }
    }

    // 3. 移动另一个工程的文件夹
    //    将光标放在类的定义上, 执行Move
    //    选择 "Move To Folder"
    //    ReSharper会建议要移动的类和要移动到的文件夹
    //    也可以输入新地址, ReSharper会提供已有的工程或文件夹作为建议
    //    在最后加入"-MoveTarget", 最后位置会变成: "04 Refactoring\Refactoring-MoveTarget"
    //    移动完成后, 可以看到该类移动到新的工程
    //    ReSharper 检查到当前工程没有引用工程Refactoring-MoveTarget
    //    可以先取消这次重构, 去手动加上引用
    //    也可以点击继续, 在报错的代码出按Alt+Enter, 将引用添加上去
    public class MoveToAnotherFolderInOtherProject
    {
        public void Method()
        {
        }
    }

    // 4. 移动另一个命名空间
    //    将光标放在类的定义上, 执行Move
    //    选择 "Move Type To Another Namespace"
    //    ReSharper 会建议当前的命名空间, 在后面加上".MoveTarget", 最终的命名空间是"JetBrains.ReSharper.Koans.Refactoring.Target"
    //    ReSharper会将该类移动到文件末尾处的命名空间中
    public class MoveToAnotherNamespace
    {
        public void Method()
        {
        }
    }

    public class UsesOtherClasses
    {
        public void CallsMethods()
        {
            // 5. 这里用来检查应用是否还正确
            new MoveToAnotherFile().Method();
            new MoveToAnotherFolderInProject().Method();
            new MoveToAnotherFolderInOtherProject().Method();
            new MoveToAnotherNamespace().Method();
        }
    }
}

namespace JetBrains.ReSharper.Koans.Refactoring.MoveTarget
{
}
