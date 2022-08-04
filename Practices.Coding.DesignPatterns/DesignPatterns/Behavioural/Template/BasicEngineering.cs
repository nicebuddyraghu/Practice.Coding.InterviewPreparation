using System;

namespace Practices.Coding.DesignPatterns.DesignPatterns.Behavioural.Template
{
    public abstract class BasicEngineering
    {
        public void Papers()
        {
            //Common Papers:
            Math();
            SoftSkills();
            //Specialized Paper:
            SpecialPaper();
        }

        private void Math()
        {
            Console.WriteLine("Mathemetics");
        }

        private void SoftSkills()
        {
            Console.WriteLine("SoftSkills");
        }

        public abstract void SpecialPaper();
    }
}
