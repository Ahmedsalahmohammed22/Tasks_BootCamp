using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    internal class Queue<T>
    {
        int front, rear;
        T[] arr;
        public Queue(int size = 10)
        {
            front = size-1;
            rear = size;
            arr = new T[size];
        }
        public void Inqueue(T value)
        {
            if(rear >= 0)
            {
                arr[--rear] = value;
            }
        }
        public T Dequeue()
        {
            if(front >= 0) 
            {
                return arr[front--];  
            }else 
                return default(T);
        }
    }
}
