using System;

namespace Practices.Coding.DesignPatterns.Creational.SingleTon
{
    class Player : IPlayer
    {
        public string Name => throw new NotImplementedException();

        public int TotalRuns { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
