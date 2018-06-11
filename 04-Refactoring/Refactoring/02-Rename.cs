using System;
using JetBrains.ReSharper.Koans.Refactoring.ExampleCode;

namespace JetBrains.ReSharper.Koans.Refactoring
{
    // 重命名
    //
    // 重命名指定元素和所有使用到它的地方
    //
    // Ctrl+R, R (VS)
    // F2 (IntelliJ)

    public class RenameType
    {
        public static RenameType Create()
        {
            // 1. 重命名类型
            //    将光标放在"RenameType"上, 执行Rename, 在弹出的对话框中进行重命名
            return new RenameType();
        }

        // 构造函数也会自动重命名
        public RenameType()
        {
        }
    }

    // 2. 重命名方法、属性、变量、字段和参数
    //    将光标放在这些元素上, 执行Rename
    public class RenameMember
    {
        private const int Value = 42;

        public string Name { get; set; }

        public void Output(string[] args)
        {
            Console.WriteLine(Name);
            Console.WriteLine(Value);
            Console.WriteLine(args);
        }
    }

    public class RenameAcrossFiles
    {
        public void Method()
        {
            // 2. 跨文件重命名
            //    将光标放在类型名或者方法名上, 执行Rename
            //    其他文件中也更新了新名字
            RenameInAnotherFile.StaticMethod();
        }

        public void Method2()
        {
            RenameInAnotherFile.StaticMethod();
        }
    }

    // 3. 撤销本地的重命名
    //    如果重命名仅在一个文件中, 那么普通的撤销命名(Ctrl+Z)也能复原重命名
    public class UndoLocalRename
    {
        const string Message = "hello world";

        public static void Method()
        {
            Console.WriteLine(Message);
        }
    }

    // 4. 撤销跨文件的重命名
    //    ReSharper默认是不会打开修改的文件的， 所以按Ctrl+Z进行撤销是没有用的
    //    要么设置ReSharper打开这些文件, 要么重命名回去
    public class UndoRenameAcrossFiles
    {
        public void Method()
        {
            // 4a. 将光标放在类型名或者方法名上, 执行Rename
            //     勾选 "To enable undo, open all files with changes for editing"
            //     重命名后, 另一个文件被打开, 并且标记为被修改, 执行 Ctrl+Z 可以跨文件撤销重命名操作
            RenameInYetAnotherFile.StaticMethod();
        }

        public void Method2()
        {
            // 4b. 将光标放在类型名或者方法名上
            //     关闭 RenameInAnotherFile.cs 这个文件
            //     执行Rename
            //     取消勾选 "To enable undo, open all files with changes for editing"
            //     重命名后, 有另一个文件标记为已修改, 但是没有被打开
            //     执行 Ctrl+Z 可以撤销当前文件的修改, 并产生了一个编译错误, 执行重做(Ctrl+Y)
            //     再次执行重命名操作复原成原来的名字
            RenameInAnotherAnotherFile.StaticMethod();
        }
    }

    // 5. 重命名字符串文本和注释
    //    将光标放在类型名上, 执行Rename
    //    确保 "Search in comments and string literals" 被勾选
    //    在第二个页面, 勾选 "Rename usages in comments and string literals"
    //    可以将注释中和文本中的文本全部替换
    public class RenameInStringLiteral
    {
        // 注释中的类型名: RenameInStringLiteral
        public const string Message = "字符串文本中的类型名: RenameInStringLiteral";
    }

    public class InlineRename
    {
        public void Method()
        {
            // 6. 内联地重命名
            //    如果重命名的作用域是局部的, 那么重命名可以内联地进行
            //    将光标放在"message"上, 执行Rename
            //    重命名对话框没有弹出, 你可以直接输入要改的名字, ReSharper也弹出了一个包含建议名字的列表
            const string message = "Hello world";
            Console.WriteLine(message);
        }
    }

    public class RenameRelatedSymbols
    {
        private readonly RenameParameter renameParameter;

        // 7. 重命名相关的符号
        //    但重命名一个用于变量、字段或者参数的类型时， ReSharper会提示这些符号
        //    将光标放在"RenameParameter"上, 执行Rename
        //    在第二个页面， 勾选"Rename related symbols", 可以重命名参数和字段
        public RenameRelatedSymbols(RenameParameter renameParameter)
        {
            this.renameParameter = renameParameter;
        }

        public class RenameParameter
        {
        }
    }

    // 7a. 在衍生类中重命名相关的符号
    //     将光标放在"arg"上, 执行Rename
    //     ReSharper会提示重命名衍生类中的参数名
    public interface IThing
    {
        void Method(string arg);
    }

    public class Thing : IThing
    {
        public void Method(string arg)
        {
        }
    }


    // 8. 修改名字后再应用重命名
    //    手动地修改符号名后, ReSharper还可以应用重命名
    //    手动地修改类型名"ApplyRenameRefactoring"
    //    注意到虚线围绕着修改后的类名, 按Alt+Enter, 选择"Apply rename refactoring"
    public class ApplyRenameRefactoring
    {
        public static ApplyRenameRefactoring Create()
        {
            return new ApplyRenameRefactoring();
        }

        // 8a. 按Escape取消应用重命名状态
        //     将光标放在"Name"上, 手动地修改属性名
        //     意到虚线围绕着修改后的属性名
        //     按 Escape 取消虚线
        public string Name { get; set; }
    }
}
