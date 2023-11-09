using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RdcAbstract
{

    abstract class Ente
    {
        protected string _NomeEnte;

        public Ente(string nomeEnte)
        {
            _NomeEnte = nomeEnte;
        }

    }
    class Comune : Ente
    {
        protected string _nomeComune;
        protected int _PilComune;
        
        public Comune(string nomeComune, int pilComune, string nomeEnte) : base(nomeEnte)
        {
            _nomeComune = nomeComune;
            _PilComune = pilComune;
        }
        //il metodo RDC richiama i dati da Cittadino (classe) a cittadino variabile
        public int Rdc(Cittadino cittadino)
        {
            cittadino.GetInfo();
            int count = 0;
            int inc = 5;
            //usando l'oggetto del cittadino. possiamo richiamare gli attributi assegnati alle singole classi
            if (cittadino.PilComune < 100)
            {
                count += inc;
            }

            if (cittadino.Figli > 1)
            {
                count += inc;
            }

            if (cittadino.Debt)
            {
                count += inc;
            }

            if ((cittadino.Age >= 18 && cittadino.Age <= 25) || (cittadino.Age >= 60 && !cittadino.Salary))
            {
                count += inc;
            }

            //Creazione di un Casting di Cittadino di tipo DownCasting dall'alto verso il basso per poter controllare 
            //all'interno della classe figlio Militare se il cittadino è stato militare, in maniera analoga possiamo farlo
            //per ogni classe Figlio.
            if (cittadino is Militare)
            {
                // questa riga converte i dati di cittadino in militare rendendo accessibile 
                //i dati interni a militare con una variabile di comodo  
                Militare _militare = (Militare)cittadino;

                if (_militare.Servizio > 0)
                {
                    count += inc;
                }
            }

            if (cittadino is Studente)
            {
                Studente _studente = (Studente)cittadino;
                if (_studente.VotoDiploma >= 90)
                {
                    count += inc;
                }

            }

            if (cittadino is StudenteUniversitario)
            {
                StudenteUniversitario _uni = (StudenteUniversitario)cittadino;
                if (_uni.VotoUniversitario >= 28 && (cittadino.Age >= 18 && cittadino.Age <= 25))
                {
                    count += inc;
                }
            }

           
            return count;

        }
        //calcolo e visualizzazione di idoneità sul risultato di cittadino per il punteggio totale.
         public void Calculate(Cittadino cittadino)
         {
             int count = Rdc(cittadino);
            
                  if (count>=25)
             {
                 Console.WriteLine(" Il Cittadino ha diritto al RDC "+ count);
             }
                 else
                 {
                 Console.WriteLine(" Il Cittadino non ha diritto al RDC "+ count);
                 }

        }
    }
}  