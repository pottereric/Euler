using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Akka.Actor;


namespace Solutions.Problem9.Akka
{
    public class Director
    {

        public static ActorSystem MyActorSystem;

        public int Solve(int sum)
        {
            int result = 0;

            MyActorSystem = ActorSystem.Create("MyActorSystem");

            var tripChecker = MyActorSystem.ActorOf(Props.Create(() => new TripletCheckerActor()));

            //tripChecker.Tell(sum.ToString());

            var foo = await tripChecker.Ask(sum.ToString());

            return result;
        } 
    }
}
