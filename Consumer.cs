using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProducerConsumer
{
    public class Consumer
    {
        public BoundedBuffer Buffer;
        public int Howmany;

        public Consumer(BoundedBuffer a, int b)
        {
            Buffer = a;
            Howmany = b;
        }

        public void Run(int LElement)
        {
            int i = 0;
            while (Buffer.Take() != LElement)
            {
               
            }
            Buffer.Take();
        }
    }
}
