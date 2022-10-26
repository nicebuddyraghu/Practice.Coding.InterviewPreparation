namespace Practices.Coding.CSharp.CSharpVersion8
{
    internal class UsingDeclarations
    {
        public void WriteLinesToFile(IEnumerable<string> lines)
        {
            using var file = new System.IO.StreamWriter("WriteLines2.txt");
            int skippedLines = 0;

            foreach(var line in lines)
            {
                if(line.Contains("first"))
                {
                    file.WriteLine(line);
                }
                else
                {
                    skippedLines++;
                }
            }

        }
    }
}
