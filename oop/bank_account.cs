using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    internal class bank_account
    {
        private string bank_name;
        private int account_num;
        private string acccount_owner;
        private string password;
        private int current;


        public bank_account(string password, string acccount_owner, int account_num)
        {
            this.password = password;
            this.acccount_owner = acccount_owner;
            this.account_num = account_num;
            this.current = 0;
        }

        public void pull(int how)
        {
            this.current -= how;
            Console.WriteLine($"your current is {this.current}");
        }

        public void push(int how)
        {
            this.current += how;
            Console.WriteLine($"your current is {this.current}");
        }

        public void print()
        {
            Console.WriteLine($"bank name: {this.bank_name}, account number: {this.account_num}, acccount owner: {this.acccount_owner}, current: {this.current}");
        }
    }
}
