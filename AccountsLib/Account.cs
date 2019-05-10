using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsLib    
{
    //private enum AccountType
    //{
    //    SAVING, CURRENT, LOAN
    //} 

    public class Account
    {

        private string name;
        private double balance;
        private static int seq;
        private int accountNumber;
        private bool isActive;
        private string accountType = "";

        public int AccountNumber
        {
            get
            {
                return this.accountNumber;
            }
        }

        static Account()
        {
            seq = 1;
        }

        public Account(string name, AccountType type)
        {
            this.accountNumber = seq;
            this.name = name;
            this.balance = 0;
            this.accountType = type.ToString();
            this.isActive = true;
            seq++;
        }

        public Account(string name)
        {
            this.accountNumber = seq;
            this.name = name;
            this.balance = 0;
            this.isActive = true;
            seq++;
        }

        public Account(string name, AccountType type, double balance)
        {
            this.accountNumber = seq;
            this.name = name;
            this.balance = balance;
            this.accountType = type.ToString();
            this.isActive = true;
            seq++;
        }

        public double depositeAmount(double amount)
        {
            if (isActive && this.accountType != "")
            {
                this.balance += amount;
                }
            else
            {
                throw new AccountNotActiveException("Can't perform operation on inactive account");
            }
            return this.balance;
        }

        public double withDrawAmount(double amount)
        {

            if (isActive && this.accountType != "")
            {
                this.balance -= amount;
            }
            else
            {
                throw new AccountNotActiveException("Can't perform operation on inactive account");
            }
            return this.balance;
        }

        public void setAccountType(AccountType type){
            this.accountType = type.ToString();
        }

        public double balanceEnquiry()
        {
            return this.balance;
        }

        public bool closeAccount()
        {
            this.balance = 0;
            this.isActive = false;
            return true;
        }

        public override string ToString()
        {
            return String.Format("Name: {0}\n ACNO: {1}\n Balance: {2}\n Active: {3}\nAccountType: {4}", this.name, AccountNumber, this.balance, this.isActive, this.accountType);
        }

    }
}
