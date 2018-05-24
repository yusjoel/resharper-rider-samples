using System;
using System.Runtime.CompilerServices;

namespace JetBrains.ReSharper.Koans.Editing
{
    // 自动补全
    //
    // 自动补全功能会在你输入代码是出现, 用来补全函数名或者其他元素等等
    //
    // 补全分成基本、引入和智能三种模式
    // 基本 = 根据当前位置上下文的标准的代码补全， 比如方法、属性之类
    // 引入 = 从其他命名空间进行代码补全
    // 智能 = 根据当前位置上下文显示智能过滤后的代码补全， 如对于字符类型的参数只显示字符型
    //
    // Ctrl+Space 或 自动出现
    // 注: 这个快捷键和输入法是冲突的, 按Ctrl+Q, 输入Keyboard, 搜索CompleteCodeBasic, 在TextEditor中将快捷键修改成Shift+Space

    public class AutomaticCompletion
    {
        // 1. 输入: this.
        //    输入.之后, 一个基本的代码补全选项会显示出来
        //    当前类型的成员会粗体显示, 继承的成员则是一般显示
        // 2. 输入: string value =
        //    输入=之后再按空格, 会根据作用域的大小依次显示可选项
        // 3. 最常用的选项会被预先选中, 如this.Age
        // 4. 如果没有最常用的选项, 那么会高亮最有可能的选项, 但是不会被选中
        //    比如"string value ="会高亮显示stringParameter
        // 5. 长按Ctrl会让代码补全窗口透明
        // 6. 按Esc可以关闭窗口
        // 7. 按.、space、tab 或者 enter 都可以接受选项（可配置）
        public void ShowCurrentContext(string stringParameter)
        {
            //this.

            //string value = 
        }

        #region Implementation details

        public string Name { get; set; }
        public int Age { get; set; }

        public string SayHello(string who)
        {
            return "Hello " + who;
        }

        public string SayGoodbye(string who)
        {
            return "Goodbye " + who;
        }

        #endregion

        // 8. 按下 inserts, Tab 则是进行替换 (可配置)
        //    将光标放在Say后面, 按下Ctrl+Space
        //    选好之后按Enter - 文本是插入到Say后面
        //    选好之后按Tab - 则是替换了SayHello
        // 9. 配置在ReSharper → Options → Intellisense → Completing Characters
        public void ReplacingExistingCode()
        {
            this.SayHello("Matt");

            // 将下面 "Matt"前的注释去掉, 然后输入Say, 在自动补全中选择SayHello
            // 按下Enter, 会将"Matt"作为SayHello的参数
            // 按下Tab, 会将"Matt"移动到最后
            //"Matt";
        }

        // 10. 使用首字母缩写进行匹配
        //     输入: this.SCC 会匹配到 ShowCurrentContext
        public void UseCamelHumps()
        {
            // this.
        }
    }

    // 11. 补全重载成员
    //     输入over, 选择override, 按下空格
    //     如果弹出大量关键字, 在右下角右键点击钥匙图标, 隐藏关键字列表
    //     点击ToString()
    public class CompleteOverrideKeyword
    {
        // Type here:

        //MyFSharp.SharpPerson _sharpPerson = new MyFSharp.SharpPerson("Mary", "Smith");
        
    }

    // 12. 自动引入其他命名空间的引用
    //     在下面类名后输入 ": NPC" 
    //     会列出 "INotifyPropertyChanged (in System.ComponentModel)"
    //     选择后会自动在文件顶端加入using System.ComponentModel命令
    // 参见 1.2 Import Completion
    public class AutomaticImportCompletion /* 在这里输入 -> */
    {
        #region Implementation details

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }

    #region Implementation details

    public static class ExtensionMethods
    {
        public static void SayCheese(this AutomaticCompletion self)
        {
        }
    }

    #endregion
}
