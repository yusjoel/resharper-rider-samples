namespace JetBrains.ReSharper.Koans.Refactoring
{
    // 封装字段
    //
    // 将字段转成属性
    //
    // Ctrl+R, E

    public class EncapsulateField
    {
        // 1. 封装字段
        //    将光标放在字段定义上, 执行Encapsulate Field
        //    ReSharper提示下列选项 - 自动属性, 读/写, 可见性等等
        public string Name;
    }
}
