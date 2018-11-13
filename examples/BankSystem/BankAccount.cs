using System;
using System.Collections.Generic;
namespace BankSystem {
    class BankAccount { // 银行账户信息
        public List<Transaction> Transactions { get; } // 交易列表
        public BankAccount( string name, byte age, double balance ) {
            this.Transactions = new List<Transaction>();
            this.Name = name;
            this.Age = age;
            this.Balance = balance;
        }
        public string Name{ get;} // 注册人姓名
        public byte Age{ get;} // 注册人年龄
        public double Balance { get; set; } // 初始存款
        public override string ToString()  {
            return $"账户信息\n 开户人 年龄 存款\n {Name} {Age} {Balance}";
        }
    }
}