using System;

namespace JetBrains.ReSharper.Koans.Editing
{
    // 切换行注释
    //
    // Ctrl+Alt+/ (VS)
    // Ctrl+/ (IntelliJ)

    // 切换块注释
    //
    // Ctrl+Shift+/ (VS + IntelliJ)

    // 1. 切换单行的注释
    //    将光标放在下面这行内, 执行Toggle line comment
    using System.Collections;

    // 2. 切换多行的注释
    //    选择下面两行代码, 执行Toggle line comment
    //    再执行一次取消注释
    using System.Collections;
    using System.Data;

    // 3. 切换块注释
    //    将光标放在下面这行代码的最后, 执行Toggle block comment
    //    再执行一次取消注释
    using System.Collections;

    // 4. 对选中区域添加块注释
    //    选中下面这行代码, 执行Toggle block comment
    //    然后再选中整块注释, 执行Toggle block comment进行取消
    using System.Collections;
}
