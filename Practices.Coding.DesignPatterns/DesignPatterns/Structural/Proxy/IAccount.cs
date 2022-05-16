namespace Practices.Coding.DesignPatterns.DesignPatterns.Structural.Proxy
{
    internal interface IAccount
    {
        public double BalanceMoney { get; set; }
        public double DepositMoney { get; set; }
        public double WithdrawMoney { get; set; }
    }
}
