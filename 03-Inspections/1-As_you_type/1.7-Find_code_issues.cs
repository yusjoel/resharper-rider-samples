using System.Collections.Generic;

namespace JetBrains.ReSharper.Koans.Inspections
{
    // 查找代码问题
    //
    // ReSharper → Inspect → Code Issues in Solution/Current Project

    public class FindMatchingIssues
    {
        public void MultipleIssues()
        {
            // 1. 将光标放在下面第一行代码的'List<string>'上, 按Alt+Enter
            //    展开 "Inspection 'Use preferred var style'" 的子菜单
            //    选择 "Find similar issues in file"
            //    也可以展开它的子菜单, 选择具体的范围, 如当前工程、解决方案或者自定义范围
            //    所有匹配的问题会显示在一个新的结果窗口
            List<string> names = new List<string>();
            List<string> address = new List<string>();
            List<int> ages = new List<int>();
        }
    }
}
