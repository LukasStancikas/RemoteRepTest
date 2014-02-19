using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProducerConsumer
{
    class IBuffer
    {
        public List<int> Buffer;

 
        
        bool IsEmpty()
        {
            if (Buffer.Count() == 0)
            {
                return true;
            }
            return false;
        }

       

    }
}
