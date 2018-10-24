using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task12REborn
{
    class Timer
    {
        public int Time { get; set; }

        private bool IsInfinity;

        public event Action Tick;

        public Timer(int time = 10, bool isInfinity = true)
        {
            Time = time;
            IsInfinity = isInfinity;
        }

        public void Start()
        {
            Thread thread = new Thread(DoTick);
            thread.Start();

        }

        private void DoTick()
        {
            do
            {
                Thread.Sleep(Time);
                Tick();
            } while (IsInfinity);
            
        }

    }
}
