using System;

namespace StateAssociation
{
    internal class MainState
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        // Interfaccia per le entità amministrative
        public interface PublicEntity
        {
            public void Interfaccia();
        }

        // Classe di base per le entità amministrative
        public abstract class State : PublicEntity
        {
            protected string _flag;
            protected string _money;
            protected string _army;
            protected decimal _cost;
            protected string _borderLimits;

            public State(string flag, string money, string army, decimal cost, string borderLimits)
            {
                _flag = flag;
                _money = money;
                _army = army;
                _cost = cost;
                _borderLimits = borderLimits;
            }


            public string Flag { get { return _flag; } }
            public string Money { get { return _money; } }
            public decimal Cost { get { return _cost; } }
            public string BorderLimits { get { return _borderLimits; } }

            public void Interfaccia()
            {
                Console.WriteLine($"Sto controllando lo stato {this._flag}");
            }
        }

        // Classe per la Regione
        public class Region : State
        {

            public Region(string flag, string money, string army, decimal cost, string borderLimits)
                : base(flag, money, army, cost, borderLimits)
            {

            }
        }

        // Classe per la Provincia
        public class Province : State
        {

            public Province(string flag, string money, string army, decimal cost, string borderLimits)
                : base(flag, money, army, cost, borderLimits)
            {

            }
        }

        // Classe per il Comune
        public class Municipality : State
        {

            public Municipality(string flag, string money, string army, decimal cost, string borderLimits)
                : base(flag, money, army, cost, borderLimits)
            {

            }
        }

        // Classe per il Cittadino
        public class Cittadino
        {

            private Municipality _comune;

            public Cittadino(Municipality comune)
            {
                _comune = comune;
            }


        }
    }
}
