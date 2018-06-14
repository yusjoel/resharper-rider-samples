using System;
using System.Collections.Generic;

namespace JetBrains.ReSharper.Koans.Refactoring
{
    // 将方法转换成索引器
    //
    // 没有快捷键, 执行Refactor This后在弹出菜单中选择

    // 将索引器转换成方法
    //
    // 将一个索引器转成getter和setter
    //
    // 没有快捷键, 执行Refactor This后在弹出菜单中选择

    public class ConvertMethodToIndexer
    {
        private readonly IDictionary<string, string> lookup = new Dictionary<string, string>();

        // 1. 将方法转换成索引器
        //    方法必须有且仅有一个参数
        //    将光标放在方法的定义上, 执行Convert Method To Indexer
        //    ReSharper 会建议属性名, 确认后执行转换
        private string GetValueByKey(string key)
        {
            return lookup.ContainsKey(key) ? lookup[key] : string.Empty;
        }

        // 2. 将方法转换成多维的索引器
        //    方法必须有多个参数
        //    将光标放在方法的定义上, 执行Convert Method To Indexer
        //    ReSharper 会建议属性名, 确认后执行转换
        private string GetValueByKey(string key, string @default)
        {
            return lookup.ContainsKey(key) ? lookup[key] : @default;
        }

        public void OutputName()
        {
            Console.WriteLine(GetValueByKey("foo"));
            Console.WriteLine(GetValueByKey("foo", "default value"));
        }
    }

    public class ConvertIndexerToMethod
    {
        private readonly IDictionary<string, string> lookup = new Dictionary<string, string>();

        // 3. 将只读的索引器转换成方法
        //    将光标放在"this"上, 执行Convert Indexer to Method(s)
        //    创建getter
        public string this[int index]
        {
            get { return lookup.ContainsKey(index.ToString()) ? lookup[index.ToString()] : string.Empty; }
        }

        // 3. 将可读写的索引器转换成方法
        //    将光标放在"this"上, 执行Convert Indexer to Method(s)
        //    创建getter和setter
        public string this[string index]
        {
            get { return lookup.ContainsKey(index) ? lookup[index] : string.Empty; }
            set { lookup[index] = value; }
        }
    }
}
