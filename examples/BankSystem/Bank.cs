using System;
using System.Collections.Generic;
namespace BankSystem{
    /**
    * 银行类
    */
    class Bank {
        private Dictionary<string, BankAccount> bankAccounts { get; }
        public Bank() {
            this.bankAccounts = new Dictionary<string, BankAccount>();
        }
        public void start() {
            Logger.Log("程序启动");
            byte command = 0;
            while ( true ) {
                Logger.ReadByte(
                @"请输入你想要执行的命令代码
                1. 银行开户
                2. 取款
                3. 查询余额
                4. 查询交易记录", out command ); // 读取命令
                switch( command ) {
                    case 1: 
                        Logger.Log( "创建新的账户" );
                        this.open();
                    break;
                    case 2:
                        Logger.Log( "取款" );
                        this.withDraw();
                    break;
                    case 3: 
                        Logger.Log( "查询账户" );
                        this.queryBalance();
                    break;
                    case 4:
                        Logger.Log( "查询交易" );
                        this.queryTransaction();
                    break;
                }
                if ( command == -1f ) {
                    break;
                }
            }
            Logger.Log("程序结束");
        }
         /**
        * 银行账户开户
         */
        public void open() {
            string  name;
            Logger.ReadString( "请输入您的姓名", out name);
            byte age;
            Logger.ReadByte( "请输入您的年龄", out age);
            double balance;
            Logger.ReadDouble( "请输入初始存款额度", out balance);
            BankAccount bankAccount = new BankAccount( name, age, balance );
            this.bankAccounts.Add( name, bankAccount );
            Logger.Log( "开户成功" );
            Logger.Log( bankAccount.ToString() );
        }
        /**
        * 银行取款
         */
        public void withDraw() {
            string  name;
            Logger.ReadString( "请输入您的姓名", out name);
            BankAccount bankAccount;
            if ( this.bankAccounts.TryGetValue( name, out bankAccount ) ) { // 含有该值
                double balance;
                if ( Logger.ReadDouble( "请输入想要取出的额度", out balance ) ) {
                    if ( bankAccount.Balance < balance ) {
                        bankAccount.Transactions.Add( new Transaction( name, balance, false ) );
                        Logger.Log( "余额不足" );
                    } else {
                        bankAccount.Balance = bankAccount.Balance - balance;
                        bankAccount.Transactions.Add( new Transaction( name, balance, true ) );
                        Logger.Log( $"余额为：{bankAccount.Balance}" );
                    }
                } else {
                   Logger.Log( "输入错误" );
                }
            } else {
                Logger.Log( $"没有用户名为{name}的用户" );
            }
        }
        /**
        * 账户查询
         */
        public void queryBalance() {
            string  name;
            Logger.ReadString( "请输入您的姓名", out name);
            BankAccount bankAccount;
            if ( this.bankAccounts.TryGetValue( name, out bankAccount ) ) { // 含有该值
               Logger.Log( $"你的账户余额为：{bankAccount.Balance}" );
            } else {
                Logger.Log( $"没有用户名为{name}的用户" );
            }
        }
        /**
        * 查询交易
         */
        public void queryTransaction() {
            string  name;
            Logger.ReadString( "请输入您的姓名", out name);
            BankAccount bankAccount;
            if ( this.bankAccounts.TryGetValue( name, out bankAccount ) ) { // 含有该值
                Logger.Log( " 姓名 余额 交易结果 交易时间" );
                foreach( Transaction t in bankAccount.Transactions ) {
                    Logger.Log( $"{t.name} {t.balance} {t.consequence} {t.TransactionTime: d}" );
                }
            } else {
                Logger.Log( $"没有用户名为{name}的用户" );
            }
        }
    }
}