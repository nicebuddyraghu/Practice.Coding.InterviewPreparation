namespace Practices.Coding.DesignPatterns.DesignPatterns.Structural.Proxy
{
    internal class ATM : IATM
    {
        IBank bank;
        public ATM(IBank bank)
        {
            this.bank = bank;
        }

        public double DepositMoney(IAccount account, double money)
        {
            return bank.DepositMoney(account,money);
        }

        public double ShowBalanceMoney(IAccount account)
        {
            return bank.ShowBalanceMoney(account);
        }

        public double WithdrawMoney(IAccount account, double money)
        {
            return bank.WithdrawMoney(account, money);
        }
    }
}
