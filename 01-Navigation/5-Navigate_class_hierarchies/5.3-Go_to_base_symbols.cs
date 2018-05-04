using System;
using JetBrains.ReSharper.Koans.Navigation.ExampleCode;

namespace JetBrains.ReSharper.Koans.Navigation
{
    // 转到基符号
    // ReSharper - Navigate - Base Symbols
    // Alt+Home (VS)
    // Ctrl+U (IntelliJ)

    public class GoToBaseSymbols
    {
        public void Method()
        {
            // 1. 选中 Customer 执行 Go To Base Symbols
            //    导航到 ICustomer
            Customer customer = GetCustomer();

            // 2. 选中 SilverCustomer 执行 Go To Base Symbols
            //    显示 Customer 和 ICustomer
            //    Customer被加粗是因为他是SilverCustomer的父类.
            var customer2 = new SilverCustomer("id", "Tim");

            // 3. 选中 PercentageDiscount 执行 Go To Base Symbols
            //    显示 Customer.PercentageDiscount 和 ICustomer.PercentageDiscount
            Console.WriteLine(customer2.PercentageDiscount);
        }

        private Customer GetCustomer()
        {
            return new Customer("id", "Matt");
        }
    }
}
