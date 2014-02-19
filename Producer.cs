using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProducerConsumer
{
    public class Producer
    {
        public BoundedBuffer Buffer;
        public int Howmany;
        public int LastElement=50;

        public Producer(BoundedBuffer a, int b)
        {
            Buffer = a;
            Howmany = b;
        }

        public void Run()
        {
            for (int i = 0; i < Buffer.Capacity - 1; i++)
            {
                Buffer.put(i);
            }
            Buffer.put(LastElement);
           
        }
      
    }
}
