using System;

namespace JetBrains.ReSharper.Koans.Editing
{
    // 复制代码
    //
    // Ctrl+D (文本编辑器中)

    // 1. 复制单行代码
    //    将光标放在下面这行代码内, 按Ctrl+D
    using System.Collections;

    // 2. 复制多行代码
    //    选择整个类, 按Ctrl+D
    public class SimpleClass
    {
        void SelectingCode()
        {
            // 还记得怎么选择整个类么, 按F12再去回忆一下, 按Ctrl+-回来
            var selectingCode = new SelectingCode();
            selectingCode.ExtendAndShrinkSelection();
            selectingCode.SelectBlock();
        }
    }
}
