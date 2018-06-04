using System;
using System.Collections.Generic;
using System.Linq;

namespace JetBrains.ReSharper.Koans.Inspections._1_As_you_type
{
    public class ConfiguringHighlights
    {
        public void WhyIsReSharperSuggestingThis(IEnumerable<string> values)
        {
            // 1. 获取ReSharper继续高亮的原因Get advice on why ReSharper is providing a highlight
            //    将光标放在下方高亮的'values'上, 按Alt+Enter
            //    展开"Inspection 'Possible multiple enumeration of IEnumerable'"的子菜单
            //    选择 "Why is ReSharper suggesting this?"
            //    会在浏览器中打开JetBrains网站中对该问题的解释的页面

            var count = values.Count();
            foreach (var value in values)
                Console.WriteLine(value);
        }

        public void IgnoreHighlightsWithComments()
        {
            // 2. 通过注释的方式关闭高亮
            //    将光标放在下方高亮的'List<string>'上, 按Alt+Enter
            //    展开 "Inspection 'Use preferred var style'" 的子菜单
            //    选择 Disable once with comment, 也可以展开子菜单, 找到更多选项
            //    ReSharper会增加注释, 警告就不再显示了

            List<string> names = new List<string>();

            // 2a. 通过#pragma关闭高亮
            //     将光标放在下方高亮的'Foo'上, 按Alt+Enter
            //     展开 "Compiler warning 'CS0612: Use of obsoleet symbol'" 的子菜单
            //     选择 Disable with #pragma 也可以展开子菜单, 找到更多选项
            //     ReSharper会增加#pragma语句, 警告就不再显示了
            Console.WriteLine(Foo);
        }

        public void ConfigureHighlights()
        {
            // 3. 将光标放在下方高亮的'List<string>'上, 按Alt+Enter
            //    展开 "Inspection 'Use preferred var style'" 的子菜单
            //    选择 Configure inspection severity
            //    在弹出的对话框中, 可以将严重性改为错误、警告、建议或者提示
            //    如果选择 "Do not show"则完全关闭了高亮
            List<string> names = new List<string>();

            // 4. 通过Options对话框复原高亮
            //    打开菜单 ReSharper → Options
            //    搜索 'use preferred var style'
            //    点击重置图标, 将严重性重置为默认值


            // 5. 在Options对话框中浏览有效的检查
            //    打开菜单 ReSharper → Options → Inspection Severity
            //    可以按照语言分类和组别进行浏览
        }

        public void FixMultipleHighlights()
        {
            // 6. 将光标放在下面第一行代码的'List<string>'上, 按Alt+Enter
            //    点击 "Use 'var'" 可以修正当前行的问题
            //    展开子菜单, 选择 "Use 'var' everywhere in file", 可以修正所有同类问题
            List<string> names = new List<string>();
            List<string> addresses = new List<string>();
            List<string> friends = new List<string>();
        }

        #region implementation details

        [Obsolete("Do not use")]
        public string Foo { get; set; }

        #endregion
    }
}
