using NUnit.Framework;

namespace JetBrains.ReSharper.Koans.Editing
{
    // 显示参数信息
    //
    // 显示方法及其重载中的参数类型和名称
    //
    // Ctrl+K, P (VS)
    // Ctrl+P (IntelliJ)
    // 按ESC取消
    //
    // 行为配置 ReSharper → Options → Environment → IntelliSense → Parameter Info
    public class ParameterInfo
    {
        public void Foo()
        {
            // 1. 显示参数信息
            //    将光标放到下面方法的参数中
            //    执行 Show Parameter Info
            SayHello("Steve");

            // 2. 高亮当前参数
            //    将光标放到下面方法的参数中
            //    执行 Show Parameter Info
            //    移动光标, 当前参数显示为粗体
            Add(1, 2, 3, 4);

            // 3. 显示重载
            //    将光标放到下面方法的参数中
            //    执行 Show Parameter Info
            //    按上下键, 切换不同的重载函数
            Assert.AreEqual(12, 12);

            // 4. 重载成员的紧凑视图
            //    ReSharper → Options → Environment → IntelliSense → Parameter Info
            //    取消 "Display all signatures at once" (一次性显示所有签名)
            //    将光标放到下面方法的参数中
            //    执行 Show Parameter Info
            //    按上下键, 切换不同的重载函数
            Assert.AreEqual(12, 12);
        }

        #region Implementation details

        public string SayHello(string name)
        {
            return "Hello " + name;
        }

        public int Add(int a, int b, int c, int d)
        {
            return a + b + c + d;
        }

        #endregion
    }
}
