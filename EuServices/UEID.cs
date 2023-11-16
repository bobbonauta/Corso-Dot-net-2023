using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuServices
{
    internal class UEID
    {
        protected string _ueid;
        public UEID(string ueid)
        {
            _ueid = ueid;
        }
        public string ueid { get { return _ueid; } set { _ueid = value; } }

        public void UEIdenfity()
        {
            Console.WriteLine("Sto scrivendo il EU ID della classe EU ID");
        }
    }
}
