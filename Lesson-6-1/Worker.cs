using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6_1
{
    public abstract class Worker
    {
        protected int obligation;
        protected Worker nextWorker;
        public void SetNextWorker(Worker worker) => nextWorker = worker;
        public bool Approve(int summ)
        {
            if (summ <= obligation)
            {
                Write(summ);
                return true;
            }
            else
            {
                if (nextWorker != null)
                {
                    return nextWorker.Approve(summ);
                }
                else
                {
                    return false;
                }
            }
        }
        public Worker(int sum)
        {
            obligation = sum;
        }
        protected abstract void Write(int summ);
    }
}
