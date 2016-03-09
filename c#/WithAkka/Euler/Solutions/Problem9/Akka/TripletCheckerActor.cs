using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Akka.Actor;

namespace Solutions.Problem9.Akka
{
    class TripletCheckerActor : TypedActor, IHandle<int>
    {
        //protected override void OnReceive(object message)
        //{
        //    Sender.Tell("42");
        //}
        public void Handle(int message)
        {
            Sender.Tell("42");
        }
    }
}
