using System;

namespace Bank
{
    class Customer_Account
    {
        string bank_name;
        private long customer_accountNo;
        private string customer_name;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="customer_accountNo"></param>
        /// <param name="customer_name"></param>
        public Customer_Account(long customer_accountNo, string customer_name)
        {
            this.customer_accountNo = customer_accountNo;
            this.customer_name = customer_name;
        }
        /// <summary>
        /// return nothing beacause return type is void
        /// </summary>
        void Printinfo()
        {
            Console.WriteLine("..........Customer details............");
            Console.WriteLine(".                                    .");
            Console.WriteLine($".  Cutomer Bank Name is {bank_name}  .");
            Console.WriteLine(".                                    .");
            Console.WriteLine($".  Cutomer Account Number is {customer_accountNo}  .");
            Console.WriteLine(".                                    .");
            Console.WriteLine($".  Cutomer Name is {customer_name}     .");
            Console.WriteLine(".                                    .");
            Console.WriteLine("......................................");

        }
        static void Main(string[] args)
        {
            Customer_Account ca = new(420420, "Saurav Belani");
            ca.bank_name = "abc pvt ltd";
            ca.Printinfo();
        }
    }
}
