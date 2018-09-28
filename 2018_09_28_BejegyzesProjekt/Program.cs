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
            // -szerzo : string
            // -tartalom : string
            // -likeok : int
            // -letrejott : DateTime
            // - szerkesztve : DateTime
            string Szerzo;
            string Tartalom;
            public int Likeok = 0;
            DateTime Letrejott = DateTime.Now;
            DateTime Szerkesztve = DateTime.Now;

            public int Like()
            {
                Likeok++;
                return 0;
            }
            public Bejegyzes(string szerzo, string tartalom, int likeok, DateTime letrejott, DateTime szerkesztve)
            {
                this.Szerzo = szerzo;
                this.Tartalom = tartalom;
                this.Likeok = likeok;
                this.Letrejott = letrejott;
                this.Szerkesztve = szerkesztve;
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
                    return Letrejott = DateTime.Now;
                }
            }

        }

        static void Main(string[] args)
        {
        }
    }
}