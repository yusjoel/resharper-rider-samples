namespace JetBrains.ReSharper.Koans.Refactoring
{
    // 将扩展方法转换成静态函数
    //
    // 没有快捷键, 执行Refactor This后在弹出菜单中选择

    // 将静态函数转换成扩展方法
    //
    // 没有快捷键, 执行Refactor This后在弹出菜单中选择

    public static class ConvertStaticAndExtensionMethods
    {
        // 1. 将扩展方法转换成静态函数
        //    将光标放在方法名上, 执行Extension Method to Plain Static
        //    调用处也会更新
        public static void ExtensionMethod(this Target target, string value)
        {
        }

        // 2. 将静态函数转换成扩展方法
        //    将光标放在方法名上, 执行Convert Static Method to Extension
        //    调用处也会更新
        public static void StaticMethod(Target target, string value)
        {
        }

        public static void Consumer()
        {
            var target = new Target();
            target.ExtensionMethod("cheese");
            StaticMethod(target, "sandwich");
        }

        public class Target
        {
        }
    }
}
