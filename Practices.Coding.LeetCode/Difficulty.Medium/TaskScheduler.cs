using System;
using System.Collections.Generic;

namespace Practices.Coding.LeetCode.Difficulty.Medium
{
    public class TaskScheduler
    {
        public class TaskNode
        {
            public char Task { get; set; }
            public int Count { get; set; }
            public TaskNode(char task, int count)
            {
                Task = task;
                Count = count;
            }
        }
        public class MaxHeap
        {

            public List<TaskNode> heapList = new List<TaskNode>();
            public int size = 0;


            public void Print()
            {
                foreach (var item in heapList)
                {
                    Console.Write($"{item.Task}:{item.Count}");
                }
                Console.WriteLine();
            }

            public int GetParentIndex(int index)
            {
                return (index - 1) / 2;
            }

            public int GetLeftChildIndex(int index)
            {
                return (index * 2) + 1;
            }

            public int GetRightChildIndex(int index)
            {
                return (index * 2) + 2;
            }

            public void Insert(char task, int count)
            {
                TaskNode taskNode = new TaskNode(task, count);
                heapList.Add(taskNode);
                size++;
                if (size > 1)
                {
                    ShiftUp(size - 1);
                }
            }

            public void Swap(int index1, int index2)
            {
                var temp = heapList[index1];
                heapList[index1] = heapList[index2];
                heapList[index2] = temp;
            }

            public void ShiftUp(int index)
            {
                while ((GetParentIndex(index) >= 0 && GetParentIndex(index) <= size - 1) && heapList[index].Count > heapList[GetParentIndex(index)].Count)
                {
                    Swap(index, GetParentIndex(index));
                    index = (GetParentIndex(index));
                }
            }

            public void ShiftDown(int index)
            {
                //Console.WriteLine(size);
                //  Console.WriteLine(heapList.Count);
                int maxIndex = index;
                int leftChildIndex = GetLeftChildIndex(index);
                int rightChildIndex = GetRightChildIndex(index);

                if ((leftChildIndex <= size - 1 && leftChildIndex >= 0) && heapList[leftChildIndex].Count > heapList[maxIndex].Count)
                {
                    maxIndex = leftChildIndex;
                }

                if ((rightChildIndex <= size - 1 && rightChildIndex >= 0) && heapList[rightChildIndex].Count > heapList[maxIndex].Count)
                {
                    maxIndex = rightChildIndex;
                }

                if (maxIndex != index)
                {
                    Swap(index, maxIndex);
                    ShiftDown(maxIndex);
                }
            }

            public TaskNode RemoveMax()
            {
                if (size == 1)
                {
                    var max = heapList[0];
                    heapList.RemoveAt(0);
                    size = size - 1;
                    return max;
                }
                else
                {
                    if (heapList.Count == 0)
                        return null;
                    var max = heapList[0];
                    heapList[0] = heapList[size - 1];
                    heapList.RemoveAt(size - 1);
                    size = size - 1;
                    ShiftDown(0);
                    return max;
                }
            }
        }

        public class Solution
        {
            public int LeastInterval(char[] tasks, int n)
            {

                if (n == 0)
                {
                    return tasks.Length;
                }
                Queue<TaskNode> taskQueue = new Queue<TaskNode>();

                MaxHeap maxHeap = new MaxHeap();

                Dictionary<char, int> taskCount = new Dictionary<char, int>();

                //O(n)
                for (int index = 0; index <= tasks.Length - 1; index++)
                {
                    if (taskCount.ContainsKey(tasks[index]))
                    {
                        taskCount[tasks[index]] = taskCount[tasks[index]] + 1;
                    }
                    else
                    {
                        taskCount.Add(tasks[index], 1);
                    }
                }

                //O(k)
                foreach (var task in taskCount)
                {
                    maxHeap.Insert(task.Key, task.Value);
                }

                int totalCount = tasks.Length;
                List<string> executableTaskList = new List<string>();
                while (totalCount > 0)
                {
                    List<string> tempTasks = new List<string>();
                    var node = maxHeap.RemoveMax();
                    if (node.Count > 0)
                    {
                        tempTasks.Add(node.Task.ToString());
                        node.Count = node.Count - 1;
                        taskQueue.Enqueue(node);
                        totalCount--;
                    }

                    for (int index = 0; index <= n - 1; index++)
                    {
                        node = maxHeap.RemoveMax();
                        if (node != null && node.Count > 0)
                        {
                            tempTasks.Add(node.Task.ToString());
                            node.Count = node.Count - 1;
                            taskQueue.Enqueue(node);
                            totalCount--;
                        }
                        else
                        {
                            if (totalCount > 0)
                                tempTasks.Add("Idle");
                        }
                    }

                    if (tempTasks.Count <= n + 1 && totalCount >= 0)
                    {
                        while (taskQueue.Count > 0)
                        {
                            var taskNode = taskQueue.Dequeue();
                            if (taskNode.Count > 0)
                                maxHeap.Insert(taskNode.Task, taskNode.Count);
                        }
                        executableTaskList.AddRange(tempTasks);
                    }
                }

                return executableTaskList.Count;
            }
        }
    }
}
