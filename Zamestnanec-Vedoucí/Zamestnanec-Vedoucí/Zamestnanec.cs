using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Zamestnanec_Vedoucí
{
    class Zamestnanec
    {
        protected string jmeno;
        protected string prijmeni;
        protected DateTime datumNastupu;
        protected int hodinovaMzda;
        protected int odpracHodiny = 0;

        public Zamestnanec(string jmeno, string prijmeni, DateTime datumNastupu, int hodinovaMzda)
        {
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
            this.datumNastupu = datumNastupu;
            this.hodinovaMzda = hodinovaMzda;
        }

        public int HodinaMzda
        {
            get
            {
                return hodinovaMzda;
            }
            
        }
        public virtual string PocetDni()
        {
            TimeSpan dny = DateTime.Now - datumNastupu;
            return dny.TotalDays.ToString();
        }
        public virtual void OdpracujHodiny(int hodiny)
        {
            odpracHodiny = odpracHodiny + hodiny;

        }
        public virtual string VypoctiMzdu()
        {
            int mzda = hodinovaMzda * odpracHodiny;
            odpracHodiny = 0;
            return "" + mzda;
        }

        public override string? ToString()
        {
            return "Zaměstnanec: " + jmeno+" " + prijmeni + "\nkterý nastoupil: " + datumNastupu + "\ns mzdou na hodinu: " + hodinovaMzda + " kč" + "\nodpracovanými hodinami: " + odpracHodiny;
                }
    }
}
