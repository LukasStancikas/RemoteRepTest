using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProducerConsumer
{
    public class BoundedBuffer
    {
        public int Capacity { get; set; }
        public Queue<int> Buffer;
        public BoundedBuffer(int a)
        {
            this.Capacity = a;
           
            Buffer = new Queue<int>(a);
        }

        



        public bool IsFull()
        {
            if (Buffer.Count() == Capacity)
            {
                return true;
            }
            return false;
        }

        public void put(int element)
        {
           
            try
            {
                Monitor.Enter(Buffer);
                while (IsFull())
                {
                    Monitor.Wait(Buffer);
                }
                Buffer.Enqueue(element);
                Console.WriteLine("Producer put: " + element);
                Monitor.Pulse(Buffer);
            }
            finally
            {
               Monitor.Exit(Buffer);
            }
        }
        public int Take()
        {
            int temp;
            try
            {
               
                Monitor.Enter(Buffer);
                while (Buffer.Count() == 0)
                {
                    Monitor.Wait(Buffer);
                   
                }
                temp = Buffer.Dequeue();
                Console.WriteLine("Consumer take: " + temp);
                Monitor.Pulse(Buffer);
                return temp;
            }
            finally
            {
                Monitor.Exit(Buffer);
            }
           
        }
    }
}
