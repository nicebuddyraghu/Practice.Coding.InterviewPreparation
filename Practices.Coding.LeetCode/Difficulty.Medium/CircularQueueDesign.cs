namespace Practices.Coding.LeetCode.Difficulty.Medium
{
    public class CircularQueueDesign
    {
        public class MyCircularQueue
        {

            int front;
            int rear;
            int capacity;
            int size;
            int[] queue;

            public MyCircularQueue(int k)
            {
                capacity = k;
                front = -1;
                rear = front;
                size = 0;
                queue = new int[capacity];
            }

            public bool EnQueue(int value)
            {
                if (IsFull())
                {
                    return false;
                }
                rear = (rear + 1) % capacity;
                if (rear > capacity - 1)
                    return false;
                queue[rear] = value;
                if (front == -1)
                {
                    front = rear;
                }
                size = size + 1;

                return true;
            }

            private void ResizeQueue()
            {
                int size = capacity;
                capacity = capacity * 2;
                var newqueue = new int[capacity];
                if (front > rear)
                {
                    for (int i = 0; i < front; i++)
                    {
                        newqueue[i + size] = queue[i];
                    }
                    rear = rear + size;
                }
                queue = newqueue;
            }

            public bool DeQueue()
            {
                if (IsEmpty())
                    return false;
                if (front > capacity - 1)
                    return false;
                int data = queue[front];
                if (front == rear)
                {
                    front = -1;
                    rear = front;
                    size = 0;
                    return true;
                }
                else
                {
                    front = (front + 1) % capacity;
                    size = size - 1;
                    return true;
                }
                return false;
            }

            public int Front()
            {
                if (IsEmpty())
                    return -1;
                return queue[front];
            }

            public int Rear()
            {
                if (IsEmpty())
                    return -1;
                return queue[rear];
            }

            public bool IsEmpty()
            {
                return size == 0 ? true : false;
            }

            public bool IsFull()
            {
                return (size == capacity);
            }
        }

        /**
         * Your MyCircularQueue object will be instantiated and called as such:
         * MyCircularQueue obj = new MyCircularQueue(k);
         * bool param_1 = obj.EnQueue(value);
         * bool param_2 = obj.DeQueue();
         * int param_3 = obj.Front();
         * int param_4 = obj.Rear();
         * bool param_5 = obj.IsEmpty();
         * bool param_6 = obj.IsFull();
         */
    }
}
