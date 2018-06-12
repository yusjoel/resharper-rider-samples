namespace JetBrains.ReSharper.Koans.Refactoring
{
    // 修改方法签名
    //
    // 更新一个方法的签名, 增加、移除或者重排参数
    //
    // Ctrl+R, S (VS)
    // Ctrl+F6 (IntelliJ)

    public class ChangeSignature
    {
        // 1. 修改方法签名
        //    将光标放在"Method"上, 执行Change Signature
        //    在对话框中, 可以修改方法名、返回类型和参数
        //    可以增加、移除或者重排参数, 修改参数类型和修饰符 (ref, out)
        //    添加一个int类型的参数， 名字为"iq"， 点"Next >"继续
        //    ReSharper会提示怎么在调用该方法的地方处理这个新增的参数
        //    可以保持代码编译不过, 使用默认值0, 在调用树中处理以及使用指定值
        // 1a. 选择在调用树中处理
        //     重构工具窗口会自动打开, 显示在"CallMethod"中对"Method"有使用, 并且给出了3个选项
        //     用户修改, 在类型"ChangeSignature"中创建字段"iq", 在方法"CallMethod"中创建参数"iq"
        //     选择其中一项来更新代码, 修改后可以关闭窗口
        public void Method(string name, int age)
        {
        }

        public void CallMethod()
        {
            Method("Deborah", 32);
        }
    }

    public class ApplyChangeSignatureRefactoring
    {
        // 2. 修改后应用修改方法签名
        //    手动添加一个参数, ReSharper会使用虚线高亮方法签名
        //    按Alt+Enter, 选择"Apply change signature refactoring..."
        //    ReSharper会弹出对话框, 可视化地显示变动
        public void AddParameterMethod(string name, int age)
        {
        }

        // 3. 修改后应用修改方法签名
        //    手动的重排参数 (Ctrl+Shift+Alt+Left/Right)
        //    ReSharper会使用虚线高亮方法签名
        //    按Alt+Enter, 选择"Apply change signature refactoring..."
        //    ReSharper会弹出对话框, 可视化地显示变动
        public void ReorderMethod(string name, int age)
        {
        }

        public void CallMethods()
        {
            AddParameterMethod("Deborah", 32);
            ReorderMethod("Deborah", 32);
        }
    }
}
