namespace JetBrains.ReSharper.Koans.Inspections
{
    // 上下文相关操作
    //
    // 和快速修正类似, 但是和代码块相关联, 而不是和高亮
    //
    // 当显示锤子提示符时, 按Alt+Enter
    //
    // 注: ReSharper 有上百个上下文相关操作, 这里只提供了很少几个例子.

    public class ContextActions
    {
        // 1. 将光标放在下面的"public"上
        //    可以看到左侧出现了锤子图标, 这说明这里有上下文相关操作存在
        //    按Alt+Enter 然后选择 "To Private", 可以把这个方法改成私有
        public void MakePublicMethodPrivate()
        {
        }

        // 2. 将光标放在下面return语句的"arg"上
        //    可以看到左侧出现了锤子图标, 这说明这里有上下文相关操作存在
        //    按 Alt+Enter, 选择 "Convert concatenation to interpolation"
        public string ConcatenatingString(string arg)
        {
            return "Hello" + arg + "World";
        }

        // 3. 打开菜单: ReSharper → Options... , 选择 Code Editing → Context actions,
        //    再根据语言选择, 如C#, VB.Net, JavaScript, XML, Build Scripts, 等等
    }
}
