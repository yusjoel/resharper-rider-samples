
namespace JetBrains.ReSharper.Koans.Editing
{
    // 引入补全
    //
    // 补全的符号在当前域中并不可见, 需要添加using命令
    // 自动补全中包含引入补全, 但是单独的使用引入补全可以减少列表中的候选项
    //
    // Shift+Alt+Space (VS)
    // Ctrl+Alt+Space (IntelliJ)

    namespace Services
    {
        public class Provider
        {
        }
    }

    public class ImportCompletion
    {
        public void UsesTypeFromNamespaceNotImported()
        {
            // 1. 输入: var provider = new Provider
            //    自动补全会建议: Provider (in JetBrains.ReSharper.Koans.Editing.Services)
            //    选择后会自动加入using命令
            // 2. 将using命令删除
            //    此时代码显示为: "var provider = new Provider", Provider没有定义
            //    将光标放在最后, 执行基本补全(Ctrl + Space)
            //    基本补全会建议: Provider (in JetBrains.ReSharper.Koans.Editing.Services)
            //    选择后会自动加入using命令
            // 3. 再次将using命令删除
            //    此时代码显示为: "var provider = new Provider", Provider没有定义
            //    将光标放在最后, 执行引入补全
            //    引入补全会建议: Provider (in JetBrains.ReSharper.Koans.Editing.Services)
            //    候选列表会比之前少很多
            //var provider = new Provid
        }
    }
}
