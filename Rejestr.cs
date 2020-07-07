using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Rejestr
    {
        private int wartość;
        private int wartośćL;
        private string Nazwa;

        public Rejestr(string nazwa)
        {
            Nazwa = nazwa;
            wartość = 0;
        }

        public int ZwrocWartosc()
        {
            return wartość;
        }

        public string ZwrocNazwe()
        {
            return Nazwa;
        }

        public void Odejmij(int Wartosc, string KtoraCzesc)
        {
            int liczba;
            if (KtoraCzesc == "H")
                liczba = ZmianaNaH(Wartosc);
            else
            {
                wartośćL = Wartosc;
                liczba = Wartosc;
            }
            wartość -= liczba;
            if (wartość < 0)
                wartość = Math.Abs(wartość);
        }

        public void Przesun(int Wartosc, string KtoraCzesc)
        {
            wartość -= wartośćL;
            if (KtoraCzesc == "L")
            {
                wartośćL = Wartosc;
                wartość += wartośćL;
            }
            else
                wartość = Wartosc;
        }

        public void Dodaj(int Wartosc, string KtoraCzesc)
        {
            if (KtoraCzesc == "L")
            {
                wartośćL += Wartosc;
                if (wartośćL > 255)
                    wartośćL = wartośćL % 255;
                wartość = wartość + Wartosc;
            }
            else if (KtoraCzesc == "H")
            {
                int liczba = ZmianaNaH(Wartosc);
                wartość += liczba;
            }
            if (wartość > 65535)
                wartość = Math.Abs(65535 - wartość);
        }

        int ZmianaNaH(int wartosc)
        {
            string binary = Convert.ToString(wartosc, 2) + "00000000";
            int liczba = Convert.ToInt32(binary, 2);

            return liczba;
        }
    }

  
}
