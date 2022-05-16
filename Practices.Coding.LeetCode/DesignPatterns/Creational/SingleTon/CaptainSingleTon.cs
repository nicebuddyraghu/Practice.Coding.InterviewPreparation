namespace Practices.Coding.LeetCode.DesignPatterns.Creational.SingleTon
{
    /// <summary>
    /// 1. Class should be sealed.
    /// 2. constructor should be private.
    /// 3. member should be public static.
    /// 4. member should be readonly.
    /// </summary>
    internal sealed class Captain : Player
    {
        private static readonly Captain instance = new Captain();

        static Captain()
        {

        }

        private Captain()
        {
        }

        public static Captain Instance
        {
            get
            {
                return instance;
            }
        }
    }
}
