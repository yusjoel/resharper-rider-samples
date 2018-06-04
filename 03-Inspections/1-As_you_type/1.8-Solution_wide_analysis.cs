using System;

namespace JetBrains.ReSharper.Koans.Inspections
{
    // 分析解决方案
    //
    // 分析整个解决方案。 能够找到更多的代码问题， 高亮未使用的代码。Can find multiple code issues, and highlights code that isn't used.
    // 会消耗更多的系统资源， 所以默认是关闭的。
    //
    // 右键点击状态栏的圆圈， 可以启用或关闭该功能
    //
    // 在高亮中进行跳转
    //
    // Shift+Alt+PageUp and Shift+Alt+PageDown (VS)
    // Alt+F12 and Shift+Alt+F12 (IntelliJ)

    public class SolutionWideAnalysis
    {
        // 1. 启用分析解决方案


        // 2. 分析结束后， 这个类和函数会标记为未使用
        public void UnusedMethod()
        {
        }

        // 3. 在警告之间跳转

        // 4. 取消下面代码的注释
        //    打开解决方案错误窗口 (ReSharper → Inspect → Solution Errors)
        //    双击错误可以跳转到错误代码
        //    可以在右键菜单中或者工具栏中使用隐藏/显示错误功能
        //    再把下面的代码注释掉
        //public void FailingCode()
        //{
        //    int i = "hello";

        //    UnusedMethod(undefinedVariable);

        //    return new Exception();
        //}
    }
}
