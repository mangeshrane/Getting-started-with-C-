using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsLib
{
    public abstract class AccountBase: IAccount
    {
        private string name;
        private double balance;
        private AccountType accountType;
        private int accountNumber;
        private static int sequenceNo;
        protected bool isActive;

        public int AccountNumber
        {
            get
            {
                return this.accountNumber;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        protected double Balance
        {
            get
            {
                return this.balance;
            }
            set
            {
                this.balance = value;
            }
        }

        protected AccountType AccountType
        {
            get
            {
                return this.accountType;
            }
        }

        static AccountBase()
        {
            sequenceNo = 1;
        }

        public AccountBase(string name, double balance, AccountType type)
        {
            this.name = name;
            this.balance = balance;
            this.accountType = type;
            this.accountNumber = sequenceNo;
            this.isActive = true;
            sequenceNo++;
        }

        public AccountBase(string name, AccountType type)
        {
            this.name = name;
            this.balance = 0;
            this.accountType = type;
            this.accountNumber = sequenceNo;
            this.isActive = true;
            sequenceNo++;
        }

        public AccountBase(string name, int balance)
        {
            this.name = name;
            this.balance = balance;
            this.accountNumber = sequenceNo;
            this.isActive = true;
            sequenceNo++;
        }

        public abstract double depositeAmount(double amount);

        public abstract double withDrawAmount(double amount);

        public void setAccountType(AccountType type)
        {
            this.accountType = type;
        }

        public double balanceEnquiry()
        {
            return this.balance;
        }

        public bool closeAccount()
        {
            this.isActive = false;
            this.balance = 0;
            return true;
        }
    }
}
