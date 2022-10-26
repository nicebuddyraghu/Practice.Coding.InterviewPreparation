namespace Practices.Coding.CSharp.CSharpVersion1
{
    internal class PassRefTypeValue
    {
        public class PassingClass
        {
            public string str = "Empty";
        }

        public class TestPassingClassByValue
        {
            public void TestPassingClassByVal(PassingClass passingclass)
            {
                passingclass = new PassingClass();
                passingclass.str = "assigned";
            }

            public void TestPassingClassByReference(ref PassingClass passingclass)
            {
                passingclass = new PassingClass();
                passingclass.str = "assigned";
            }

            public void TestPassingClassExample()
            {
                PassingClass passingClass = new PassingClass();
                Console.Write(passingClass.str);
                TestPassingClassByVal(passingClass);
                Console.WriteLine(passingClass.str);


                PassingClass passingClass1 = new PassingClass();
                Console.Write(passingClass1.str);
                TestPassingClassByReference(ref passingClass1);
                Console.WriteLine(passingClass1.str);

            }

            
        }
    }
}
