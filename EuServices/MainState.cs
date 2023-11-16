using System;

namespace EuServices
{
    internal class MainState
    {
        static void Main(string[] args)
        {
         //   Console.WriteLine(UEPublicAdministration.UEPA(UEID));
        }

        public class State
        {
            protected string _flagColour;
            protected string _currency;
            protected string _army;
            protected string _constitution;
            protected string _borders;

            public State (string FlagColour, string Currency, string Army, string Constitution, string Borders)
            {
                _flagColour = FlagColour;
                _currency = Currency;
                _army = Army;
                _constitution = Constitution;
                _borders = Borders;
            }
            public string FlagColour { get { return _flagColour; } }
            public string Currency { get { return _currency; } }
            public string Army { get { return _army; } }
            public string Constitution { get { return _constitution;} }
            public string Borders { get { return _borders;} }   
        }

         

    }
}
