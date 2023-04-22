using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenia4
{
    class QueueBad : ArrayList
    {

        public void Enqueue(Object value) {
            this.Add(value);
        }
        public Object Dequeue() {
            Object element = this[0];
            this.RemoveAt(0);
            return element;
        }
    }


    class QueueGood
    {
        ArrayList _queue;

        public QueueGood()
        {
            _queue = new ArrayList();
        }

        public void Enqueue(Object value)
        {
            _queue.Add(value);
        }
        public Object Dequeue()
        {
            Object element = _queue[0];
            _queue.RemoveAt(0);
            return element;
        }


    }


}
