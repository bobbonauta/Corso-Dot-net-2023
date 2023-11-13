using System;

namespace BCEInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //istanzio l'oggetto italia come nuovo oggetto
            State italiaState = new EuroCentralBank("Italia", true, true, false, 3);
             
            // faccio fare la verifica dei diritti umani a un oggetto che prende quindi i dati di metodo
            EuropeanHumanRights rightsChecker = new EuropeanHumanRights();
            //stampo a video se l'italia rispetta i diritti umani
            Console.WriteLine(rightsChecker.CheckEuropeanHumanRights(italiaState));
            //verifico che l'italia come nuovo oggetto abbia uno spread di un certo valore
            EuroCentralBank italiaEuroCentralBank = (EuroCentralBank)italiaState;
            //usando l'override ricalcolo il valore dello spread
            double spreadValue = italiaEuroCentralBank.SpreadCalculate();
            //stampo a video il valore ottenuto
            Console.WriteLine($"Lo spread per l'Italia è: {spreadValue}");


            State TurchiaState = new EuroCentralBank("Turchia", false, true, true, 10);
            Console.WriteLine(rightsChecker.CheckEuropeanHumanRights(TurchiaState));
            EuroCentralBank TurchiaEuroCentralBank = (EuroCentralBank)TurchiaState;
            spreadValue = TurchiaEuroCentralBank.SpreadCalculate();
            Console.WriteLine($"Lo spread per la Turchia è: {spreadValue}");

            State CinaState = new EuroCentralBank("Cina", false, false, true, 10);
            Console.WriteLine(rightsChecker.CheckEuropeanHumanRights(CinaState));
            EuroCentralBank CinaEuroCentralBank = (EuroCentralBank)CinaState;
            spreadValue = CinaEuroCentralBank.SpreadCalculate();
            Console.WriteLine($"Lo spread per la Cina è: {spreadValue}");

        }

        public abstract class State
        {
            protected string _name;
            protected bool _euMember;
            protected bool _DeathPenalty;
            protected bool _onuMember;

            public State(string Name, bool EuMember, bool OnuMember, bool Death, decimal CountrySpread)
            {
                _name = Name;
                _euMember = EuMember;
                _DeathPenalty = Death;
                _onuMember = OnuMember;
            }

            public string Name { get { return _name; } }
            public bool EuMember { get { return _euMember; } }
            public bool Death { get { return _DeathPenalty; } }
            public bool Onu { get { return _onuMember; } }

            public abstract double SpreadCalculate();

        }

        public class EuropeanHumanRights
        {
            public string CheckEuropeanHumanRights(State _state)
            {
                //bisogna fare i check dei paesi membri se sono ue,nato e se rispettano la pena di morte

                if (!_state.Death && _state.Onu && (_state.EuMember))
                {
                    return (_state.Name + " Il paese è un membro sia Onu che Eu e non prevede la pena di morte");
                }
                if (!_state.Death && !_state.Onu && !_state.EuMember)
                {
                    return (_state.Name + " Il paese non è un membro sia Onu che Eu e non prevede la pena di morte");
                }
                if ((_state.Death) && _state.Onu && (_state.EuMember))
                {
                    return (_state.Name + " Il paese è un membro sia Onu che Eu e prevede la pena di morte");
                }
                if (_state.Death && _state.Onu)
                {
                    return (_state.Name + " Il paese è un membro Onu e prevede la pena di morte");
                }
                if (_state.Death && (_state.EuMember))
                {
                    return (_state.Name + " Il paese è un membro Onu e prevede la pena di morte");
                }
                else
                {
                    return (_state.Name + " Il paese non appartiene ne all'Onu ne all'UE");
                }
            }
        }

        class EuroCentralBank : State

        {
            protected decimal _countrySpread;

            public EuroCentralBank(string Name, bool EuMember, bool OnuMember, bool Death, decimal CountrySpread) :
                              base(Name, EuMember, OnuMember, Death, CountrySpread)
            {
                _countrySpread = CountrySpread;
            }

            public decimal CountrySpread { get { return _countrySpread; } }

            public override double SpreadCalculate()
            {
                double _spreadvalue = 0;
                if (_countrySpread > 3)
                {
                    _spreadvalue = Convert.ToDouble(_countrySpread);

                }
                else if (_countrySpread <= 3)
                {
                    _spreadvalue = Convert.ToDouble(_countrySpread);
                }
                return _spreadvalue;

            }
        }
    }
}
