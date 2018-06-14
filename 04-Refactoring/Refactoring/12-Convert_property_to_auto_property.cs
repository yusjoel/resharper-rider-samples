namespace JetBrains.ReSharper.Koans.Refactoring
{
    // 将属性转换成自动属性
    //
    // 没有快捷键, 执行Refactor This后在弹出菜单中选择
    //
    // 也可以按Alt+Enter, 通过Quick Fix来执行

    public class ConvertPropertyToAutoProperty
    {
        private string backingStore;
        private string backingStore2;
        private string backingStore3;

        // 1. 通过重构命令转换成自动属性
        //    将光标放在属性定义上, 执行Convert Property to Auto-Property
        public string PropertyWithBackingStore
        {
            get { return backingStore; }
            set { backingStore = value; }
        }

        // 2. 通过Alt+Enter转换成自动属性
        //    这里标记为建议
        //    将光标放在属性定义上, 按 Alt+Enter, 然后选择 Convert to auto-property
        public string PropertyWithBackingStore2
        {
            get { return backingStore2; }
            set { backingStore2 = value; }
        }

        // 3. 通过Alt+Enter转换成只读的自动属性
        //    这里标记为提示 (并没有)
        //    将光标放在属性定义上, 按 Alt+Enter, 然后选择 Convert to auto-property
        public string PropertyWithBackingStore3
        {
            get { return backingStore3; }
        }
    }
}
