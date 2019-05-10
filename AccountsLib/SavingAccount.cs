using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsLib
{
    public class SavingAccount: AccountBase
    {
        public SavingAccount(string name, double balance): 
            base(name, balance, AccountType.SAVING)
        {
            Console.WriteLine("Account created ");
        }

        public override string ToString()
        {
            return string.Format("SAVING ACCOUNT:\nName: {0}\nBalance: {1}\n", Name, Balance);
        }

        public override double depositeAmount(double amount)
        {
            if (this.isActive)
            {
                this.Balance += amount;
            }
            else
            {
                throw new AccountNotActiveException("Can't perform operation on inactive account");
            }
            return this.Balance;
        }

        public override double withDrawAmount(double amount)
        {
            if (isActive)
            {
                this.Balance -= amount;
            }
            else
            {
                throw new AccountNotActiveException("Can't perform operation on inactive account");
            }
            return this.Balance;
        }
    }
}
