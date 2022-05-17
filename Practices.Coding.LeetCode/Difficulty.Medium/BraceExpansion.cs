using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode.Difficulty.Medium
{
    public class BraceExpansion
    {
        public List<string> Solution(string braceExpansionString)
        {
            Queue<Stack<String>> stackOfStack = new Queue<Stack<string>>();
            var tempStringList = braceExpansionString.Split('}').ToList();
            foreach(var tempString in tempStringList)
            {
                var tempnewStringList = tempString.Split('{');
                foreach(var tempnewString in tempnewStringList)
                {
                    Stack<string> stackStr = new Stack<string>();
                    var charList = tempnewString.Split(',');
                    foreach(var element in charList)
                    {
                        if(!String.IsNullOrEmpty(element))
                            stackStr.Push(element.ToString());
                    }

                    if(stackStr.Count>0)
                    {
                        stackOfStack.Enqueue(stackStr);
                    }
                }
            }

            foreach(var elements in AppendStr(stackOfStack, string.Empty))
            {
                Console.WriteLine(elements);
            }

            return AppendStr(stackOfStack, string.Empty);
        }

        public List<string> AppendStr(Queue<Stack<string>> stackofStack, string appendStr)
        {
            List<string> listString = new List<string>();
            
            if(stackofStack.Count==0)
                    return listString;
            else
            {
                if (stackofStack.Count > 1)
                {
                    var stack = stackofStack.Dequeue();
                    while (stack.Count > 0)
                    {
                        var str = stack.Pop();
                        if (stackofStack.Count > 0)
                        {
                            listString.AddRange(AppendStr(stackofStack, appendStr + str));
                        }
                        else
                            listString.Add(appendStr + str);
                    }
                }
                else
                {
                    var stack = stackofStack.Peek();
                    Stack<string> newstack = new Stack<string>();
                    while (stack.Count > 0)
                    {
                        var str = stack.Pop();
                        newstack.Push(str);
                        listString.Add(appendStr + str);
                    }

                    while (newstack.Count > 0)
                    {
                        var str = newstack.Pop();
                        stack.Push(str);
                    }
                }
                return listString;
            }
        }
    }
}
