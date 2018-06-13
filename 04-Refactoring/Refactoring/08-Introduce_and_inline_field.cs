using System;
using System.Windows.Forms;

namespace JetBrains.ReSharper.Koans.Refactoring
{
    // 引入字段
    //
    // 在当前类中根据选中内容创建字段
    //
    // Ctrl+R, F (VS)
    // Ctrl+Alt+D (IntelliJ)

    // 内联字段
    //
    // 将字段的使用替换成字段的内容
    //
    // Ctrl+R, I (VS)
    // Ctrl+Alt+N (IntelliJ)

    public class IntroduceAndInlineField
    {
        public void InitialiseForm()
        {
            // 1. 引入字段
            //    将光标放在变量"button"上, 执行Introduce Field
            //    选择字段名和初始化的位置 - 当前位置, 字段初始化器还是构造函数
            //    选择可见性(私有、公共等等)以及是否要设为静态和只读
            var form = new Form();
            var button = new Button();
            form.Controls.Add(button);
        }

        public void InitialiseForm2()
        {
            // 2. 从多个实例中引入字段
            //    选择 "new Button()" (使用扩展选择 Ctrl+Alt+Right (VS) Ctrl+W (IntelliJ))
            //    执行Introduce Field
            //    ReSharper会高亮所有方法中的所有使用, 并提示替换4处（所有方法中的所有使用）、3处（当前方法中的所有使用）还是1处（当前使用）
            //    选择字段名和初始化的位置 - 当前位置, 字段初始化器还是构造函数
            //    选择可见性(私有、公共等等)以及是否要设为静态和只读
            var form = new Form();
            form.Controls.Add(new Button());
            form.Controls.Add(new Button());
            form.Controls.Add(new Button());
        }

        public void IntroduceConstant()
        {
            // 3. 引入常量
            //    选择文本"Hello world"， 并执行Introduce Field
            //    在对话框界面按Alt+I， 选中"Introduce constant"
            Console.WriteLine("Hello world");
        }

        private const int MyField = 23;

        public void InlineField()
        {
            // 4. 内联字段
            //    选中"MyField", 执行Inline Field
            Console.WriteLine(MyField);
        }

        private const int MyOtherField = 23;

        public void InlineFieldOnMultipleInstances()
        {
            // 5. 内联字段
            //    选中"MyOtherField", 执行Inline Field
            Console.WriteLine(MyOtherField);
            Console.WriteLine(MyOtherField);
            Console.WriteLine(MyOtherField);
        }
    }
}
