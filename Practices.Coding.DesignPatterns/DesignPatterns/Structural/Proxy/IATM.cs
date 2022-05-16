namespace Practices.Coding.DesignPatterns.DesignPatterns.Structural.Proxy
{
    internal interface IATM
    {
        public double ShowBalanceMoney(IAccount account);
        public double DepositMoney(IAccount account,double money);
        public double WithdrawMoney(IAccount account,double money);
    }
}
