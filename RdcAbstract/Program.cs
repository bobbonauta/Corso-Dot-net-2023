using System;
using System.Runtime.CompilerServices;

namespace RdcAbstract
{

    internal class Program
    {
        static void Main(string[] args)
        {
            // istanziamo la variabile patrizio come classe Cittadino che assume i riferimento di studente passandogli i dati di Studente
            Cittadino Patrizio = new Studente("Patrizio", "Cecio", 24, 2, 102, true, false,96);
            // istanziato il comune di milano
            Comune Milano = new Comune("Milano",102,"Comune");
            //all'oggetto milano passiamo i dati di patrizio per ottenere il risultato idoneo al RDC.
            Milano.Calculate(Patrizio);
            //
            Cittadino Elena = new StudenteUniversitario("Elena", "Sussurri", 24, 2, 98, true, 96, 28,false);
            Milano.Calculate(Elena);

        }

    }
    // la creazione di una clase astratta è necessaria per creare classi "non reali"
    abstract class Person
    {
        //usare protected serve a creare variabili protette ereditabili da classi collegate
        protected string _name;
        protected string _surName;
        protected int _age;

        public string GetName()
        {
            return _name + " " + _surName;
        }

        //creiamo il costruttore di persona con i dati in input
        public Person(string Name, string surName, int age)
        {
            _name = Name;
            _surName = surName;
            _age = age;
        }
        //creiamo gli attributi leggibili all'esterno
        public string Name { get { return _name; } }
        public string SurName { get { return _surName; } }
        public int Age { get { return _age; } }
        //creazione di un metodo astratto 
        public abstract void GetInfo();
        
    }

    class Cittadino : Person
    {
        protected int _figli;
        protected decimal _PilComune;
        protected bool _debt;
        protected bool _salary;

        //base ci permette di richiamare i dati della classe padre Cittadino senza doverli reinserire e dichiarare nuovamente
        public Cittadino(string Name, string surName, int age, int Figli, decimal PilComune, bool Debt, bool Salary) 
               :base(Name, surName, age)

        {
            _debt = Debt;
            _figli = Figli;
            _PilComune = PilComune;
            _salary = Salary;
        }

        public int Figli { get { return _figli; } } 
        public decimal PilComune { get { return _PilComune; } }
        public bool Debt{get { return _debt; }}    
        public bool Salary { get { return _salary; }}

        //la classe padre non necessità di richiamare i dati
        public override void GetInfo()
        {
            
            Console.Write(_name +" "+ _surName + " " + _age);
        }
    }

    class Studente : Cittadino
    {
        protected decimal _votoDiploma;

        public Studente(string Name, string surName, int age, int Figli, decimal PilComune, bool Debt, bool Salary, decimal votoDiploma )
               :base(Name, surName, age, Figli, PilComune, Debt, Salary)

        {
            _votoDiploma = votoDiploma;
            
        }

        public decimal VotoDiploma{get { return _votoDiploma; }}

        //la classe figlio richiede la chiamata dei dati dalla classe padre 
        public override void GetInfo()
        {
            base.GetInfo();
            Console.Write(" "+_votoDiploma);
        }
    }

    class StudenteUniversitario : Studente
    {
        protected decimal _votoUni;

        public StudenteUniversitario(string Name, string surName, int age, int Figli, decimal PilComune, bool Debt, decimal votoDiploma, decimal VotoUni, bool Salary)
               :base(Name, surName, age, Figli, PilComune, Debt, Salary, votoDiploma)
        {
            _votoUni = VotoUni;
        }

        public decimal VotoUniversitario{get { return _votoUni; }}
        
        public override void GetInfo()
        {
            base.GetInfo();
            Console.Write(" " + _votoUni);
        }
    }

    class Militare : Cittadino
    {
        protected int _servizioAnni;

        public Militare(string Name, string surName, int age, int Figli, decimal PilComune, bool Debt, int ServizioAnni,bool Salary)
                    :base(Name, surName, age, Figli, PilComune, Debt, Salary)
        {
            _servizioAnni = ServizioAnni;
        }
        public int Servizio {get { return _servizioAnni; }}

        public override void GetInfo()
        {
            base.GetInfo(); 
            Console.Write(" " + _servizioAnni);
        }
    }


}






