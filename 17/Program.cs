using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17
{
    class Program
    {
        static void Main(string[] args)
        {

            Bank<int> account1 = new Bank<int>(123456, "Сидоров", 10000);
            account1.Print();
            Bank<string> account2 = new Bank<string>("AAAA123", "Иванов", 500000);
            Console.WriteLine();
            account2.Print();
            Console.ReadKey();
        }
    }
    class Bank<T>
    {

        private T Accounts { get; set; }
        public string Name_client { get; set; }
        public double Balance_account { get; set; }
        public Bank(T accounts, string name, float balance)
        {
            Accounts = accounts;
            Name_client = name;
            Balance_account = balance;
        }
        public T Account
        {
            get { return Accounts; }
            set { Accounts = value; }
        }
        public string Name
        {
            get { return Name_client; }
            set { Name_client = value; }
        }
        public double Balance
        {
            get { return Balance_account; }
            set { Balance_account = value; }
        }
        public void Print()
        {

            Console.WriteLine(Accounts);
            Console.WriteLine(Name_client);
            Console.WriteLine(Balance_account);
        }       

    }

}



