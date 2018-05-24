namespace JetBrains.ReSharper.Koans.Editing
{
    // 智能补全
    //
    // 将候选项缩减到最合适当前上下文
    //
    // Ctrl+Alt+Space (VS)
    // Ctrl+Shift+Space (IntelliJ)

    public class SmartCompletion
    {
        // 1. 输入: string s = 
        //    自动补全会先显示智能补全(都是字符串类型), 然后当前作用域内、更大作用域以及需要引入的候选项
        // 2. 取消注释: string s2 = 
        //    在行尾执行智能补全
        //    智能补全只会显示字符串类型的候选项, 包括返回字符串类型的方法, 如String.Concat
        // 3. 取消注释: string s3 = this.
        //    在行尾执行智能补全
        //    智能补全只会显示字符串类型的候选项, 可以看到Age没有被列出
        public void SmartUseString(string stringParameter)
        {
            //string s2 = 
            //string s3 = this.
        }

        public int Age { get; set; }

        #region Implementation details

        public string Name { get; set; }
        public string GetGreeting()
        {
            return "hello";
        }

        #endregion
    }
}
