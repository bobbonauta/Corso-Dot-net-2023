using static EuServices.EUCitizen;

namespace EuServices
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Crea un'istanza della classe UEID
            UEID ueid = new UEID("1234567890");

            // Chiama il metodo UEIdenfity
            ueid.UEIdenfity();

            // Crea un'istanza della classe Citizen
            Citizen citizen = new Citizen("9876543210");

            // Chiama il metodo UEIdenfity dalla classe Citizen
            citizen.UEIdenfity();
        }
    }
    internal class EUCitizen
    {
        public class Citizen : UEID
        {

            public Citizen(string UEID) : base(UEID)
            {

            }


        }
    }
}
