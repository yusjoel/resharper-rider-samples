using System;

namespace JetBrains.ReSharper.Koans.Refactoring
{
    // 引入参数
    //
    // 在当前方法中根据选中内容创建参数
    //
    // Ctrl+R, P (VS)
    // Ctrl+Alt+V (IntelliJ)

    // 内联参数
    //
    // 将参数的使用替换成调用处的值
    //
    // Ctrl+R, I (VS)
    // Ctrl+Alt+N (IntelliJ)

    public class IntroduceAndInlineParameter
    {
        public void OutputSum(int a, int b)
        {
            // 1. 引入参数
            //    选中 "a+b" (使用扩展选中 Ctrl+Alt+Right (VS) Ctrl+W (IntelliJ))
            //    执行 Introduce Parameter
            //    将名字改为"sum",
            //    参数添加后, 原始的值会在调用处计算, 参数a和b可以用Safe Delete删除
            Console.WriteLine(a + b);
        }

        public void CallOutputSum()
        {
            OutputSum(2, 3);
        }

        public void OutputSum2(int a, int b)
        {
            // 2. 从多处使用中引入参数
            //    选中 "a+b" (使用扩展选中 Ctrl+Alt+Right (VS) Ctrl+W (IntelliJ))
            //    执行 Introduce Parameter
            //    ReSharper会高亮所有使用, 并提示替换4处发现还是仅一处发现
            //    选择替换4处, 所有使用都会被替换
            Console.WriteLine(a + b);
            Console.WriteLine(a + b);
            Console.WriteLine(a + b);
            Console.WriteLine(a + b);
        }

        public void CallOutputSum2()
        {
            OutputSum2(2, 3);
        }

        // 3. 内联参数
        //    选择参数"a", 执行Inline Parameter
        //    执行完毕后, 参数a会被移除, 在方法中所有使用到该参数的地方会被替换成具体的值, 所有调用的地方会更新
        public void OutputSum3(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public void CallOutputSum3()
        {
            OutputSum3(2, 3);
        }

        // 4. 有多处使用情况下的内联参数
        //    选择参数"a", 执行Inline Parameter
        //    选择该方法的一个使用, 这决定了替换该参数的值
        //    执行完毕后, 参数a会被移除, 在方法中所有使用到该参数的地方会被替换成之前选择的值, 所有调用的地方会更新
        public void OutputSum4(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public void CallOutputSum4()
        {
            OutputSum4(2, 3);
            OutputSum4(12, 13);
            OutputSum4(200, 300);
        }
    }
}
