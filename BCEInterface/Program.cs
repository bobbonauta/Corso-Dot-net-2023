using System;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography.X509Certificates;

namespace BCEInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public abstract class State
        {
            protected string _name;
            protected bool _euMember;
            protected bool _NonEuMember;
            protected bool _DeathPenalty;

            public State(string Name, bool EuMember, bool NonEuMember, bool Death)
            {
                _name = Name;
                _euMember = EuMember;
                _NonEuMember = NonEuMember;
                _DeathPenalty = Death;
                
            }

            public abstract double SpreadCalculate();

        }

        private class EuroCentralBank
        {
            private string _stateName { get; set; }
            public EuroCentralBank(string StateName)
            {
                _stateName = StateName;
            }
        
            public bool SpreadCalculate()
            {
                decimal TotalSpread = 1;
                if (TotalSpread >= 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public class EuropeanHumanRights
        {
          public string CheckEuropeanHumanRights(State _state)
            {
                if (State.
            }
        }

    }
}
