using System.Text.RegularExpressions;

namespace JetBrains.ReSharper.Koans.RegularExpressions
{
    // 支持正则表达式
    //
    // 语法高亮, 代码补全以及测试

    public class RegularExpressions
    {
        public static void Editing()
        {
            // 1. 开始输入一个空的正则表达式
            //     添加开口的圆括号, 方括号以及转义符, 查看Code Completion功能
            // 2. 在表达式的各个位置试试直接指向Code Completion
            var match = Regex.Match("abc", @"(?<Word>[A-Za-z]+)(\s|\t)+(?# Comment)", RegexOptions.ExplicitCapture);
        }

        public static void ValidateExpression()
        {
            // 3. 将光标放在表达式上, 按下Alt+Enter, 选择"Validate regular expression" (验证正则表达式)
            //    输入测试文本, 查看匹配的内容
            //    观察到这个正则表达式需要最后添加一个空格才能匹配到最后一个单词
            //    将"Comment"前的"+"改成"*"
            //    测试后, 点"Insert"按钮. 可以看到表达式已经更新了.
            var match = Regex.Match("abc", @"(?<Word>[A-Za-z]+)(\s|\t)+(?# Comment)", RegexOptions.ExplicitCapture);
        }

        public static void StringLiteralAsRegularExpression()
        {
            // 4. 将任意字符串变成能语法高亮的正则表达式
            //    注意"pattern"现在没有语法高亮
            //    将光标放在字符串上, 按下Alt+Enter,
            //    选择"Mark as injected language or reference" - ".NET Regular Expression"
            //    现在字符串语法高亮了
            const string pattern = @"(?<Word>[A-Za-z]+)(\s|\t)+(?# Comment)";
            var match = Regex.Match("abc", pattern, RegexOptions.ExplicitCapture);
        }

        public static void CodeCompletionOfMatches()
        {
            var match = Regex.Match("abc", @"(?<Word>[A-Za-z]+)(\s|\t)+(?# Comment)", RegexOptions.ExplicitCapture);

            // 5. 输入 match. (包括最后的点号)
            //    Code completion会显示match.Groups["Word"], 从表达式中提取到的捕获数据
        }
    }
}
