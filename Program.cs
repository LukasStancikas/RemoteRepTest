using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProducerConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            BoundedBuffer buffer = new BoundedBuffer(10);
            Producer prod = new Producer(buffer,15);
            Consumer cons = new Consumer(buffer,15);
            Task[] Tasks = new Task[2];
            Tasks[0] = Task.Factory.StartNew(() => prod.Run()); 
            Tasks[1] = Task.Factory.StartNew(() => cons.Run(prod.LastElement));
            Task.WaitAll(Tasks);
        }
    }
}
