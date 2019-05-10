using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsLib
{
    public interface IAccount
    {
         double depositeAmount(double amount);

         double withDrawAmount(double amount);

         void setAccountType(AccountType type);

         double balanceEnquiry();

         bool closeAccount();
    }
}
