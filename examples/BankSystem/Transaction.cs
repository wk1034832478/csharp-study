using System;

namespace BankSystem {
    class Transaction { // 银行账户交易信息
        public DateTime TransactionTime { get; } // 交易时间
        public double balance { get;} // 交易金额
        public bool consequence { get; } // 交易结果
        public string name; // 交易用户
        public Transaction(string name, double balance, bool consequence ) { 
            this.TransactionTime = DateTime.Now;
            this.balance = balance;
            this.consequence = consequence;
            this.name = name;
        }
    }
}