namespace JetBrains.ReSharper.Koans.Navigation
{
    // 转到断点
    //
    // 转到当前解决方案的断点
    //
    // Ctrl+Alt+F9 (VS/IntelliJ)

    public class NavigateToBreakpoint
    {
        public void Foo()
        {
			// 1. 在这个方法的开始处下一个断点
        }

        public void Bar()
        {
            // 2. 在这个方法的开始处也下一个断点
        }

        // 3. 转到断点
        //    按下快捷键Ctrl+Alt+F9
        //    各个设置的两个断点都列了出来, 点击即可跳转
        //
        // 4. 显示到R# Breakpoints窗口
        //    按下 Shift+Enter(或者Num+, 或者点放大镜按钮)打开R# Breakpoints窗口
        //    使用右键菜单可以关闭/开启或者删除断点
    }
}
