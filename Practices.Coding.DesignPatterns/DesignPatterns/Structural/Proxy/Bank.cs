namespace Practices.Coding.DesignPatterns.DesignPatterns.Structural.Proxy
{
    internal class Bank : IBank
    {
        public string Name { get { return "NewBank"; } }

        public double DepositMoney(IAccount account, double money)
        {
            return account.BalanceMoney + money;
        }

        public double ShowBalanceMoney(IAccount account)
        {
            return account.BalanceMoney;
        }

        public double WithdrawMoney(IAccount account,double money)
        {
            return account.BalanceMoney - money;
        }
    }
}
