using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2018_09_28_BejegyzesProjekt
{
    class Program
    {
        class Bejegyzes
        {
            // - szerzo : string
            // - tartalom : string
            // - likeok : int
            // - letrejott : DateTime
            // - szerkesztve : DateTime
            public string Szerzo;
            public string Tartalom;
            public int Likeok;
            public DateTime Letrejott = DateTime.Now;
            public DateTime Szerkesztve = DateTime.Now;

            public int Like()
            {
                Likeok++;
                return 0;
            }
            public Bejegyzes(string szerzo, string tartalom)
            {
                this.Szerzo = szerzo;
                this.Tartalom = tartalom;
                this.Likeok = 0;
                this.Letrejott = DateTime.Now;
                this.Szerkesztve = this.letrejott;
            }
            public string szerzo
            {
                get
                {
                    return Szerzo; // string Szerzo;
                }
            }
            public string tartalom
            {
                get
                {
                    return Tartalom; // string Tartalom;
                }
                set
                {
                    this.tartalom = Tartalom;
                    this.Szerkesztve = DateTime.Now;
                }
            }
            public int likeok
            {
                get
                {
                    return Likeok; // int Likeok = 0;
                }
            }
            public DateTime letrejott
            {
                get
                {
                    return Letrejott;
                }
            }
            public DateTime szerkesztve
            {
                get
                {
                    return Szerkesztve = DateTime.Now;
                }
            }
            public string Kiir()
            {
                string szoveg = this.Szerzo + " - "  + this.Likeok + " - " + this.Letrejott + "\n";
                szoveg += "Szerkesztve: " + this.Szerkesztve + "\n";
                szoveg += this.Tartalom;
                return szoveg;
            }
        }

        static void Main(string[] args)
        {
            Bejegyzes pelda = new Bejegyzes("MARIKA","kutya");
            Console.WriteLine(pelda.Kiir());
            Console.ReadKey();
        }
    }
}