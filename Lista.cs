#nullable enable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_2
{
    internal class Lista : IEnumerable<Element>
    {
        Element? poczatek;

        int dlugosc = 0;

        public int Dlugosc { 
            get { return this.dlugosc; } 
        }
        
        public void Dodaj(int wartosc)
        {
            this.dlugosc++;
            if (this.poczatek == null)
            {
                this.poczatek = new Element(wartosc);
                return;
            }

            Element? biezacy = this.poczatek;
            do
            {
                Element? tmp = biezacy.nastepny;
                if (biezacy.nastepny == null)
                {
                    biezacy.nastepny = new Element(wartosc);
                    biezacy.nastepny.poprzedni = biezacy;
                }
                biezacy = tmp;
            } while (biezacy != null);
        }

        public void Usun(int wartosc, bool wszystkie = false)
        {
            Element? biezacy = this.poczatek;
            do
            {
                if (biezacy?.wartosc == wartosc)
                {
                    this.dlugosc--;
                    if (biezacy.poprzedni == null) {
                        this.poczatek = biezacy.nastepny;
                    } else {
                        if (biezacy.nastepny != null) {
                            biezacy.nastepny.poprzedni = biezacy.poprzedni;
                        }
                        biezacy.poprzedni.nastepny = biezacy.nastepny;
                    }
                    if (!wszystkie) {
                        break;
                    }
                }
                biezacy = biezacy?.nastepny;
            } while (biezacy != null);
        }

        public IEnumerator<Element> GetEnumerator()
        {
            Element? biezacy = this.poczatek;

            while (biezacy != null) {
                Element tmp = biezacy;
                biezacy = biezacy.nastepny;

                yield return tmp;
            }

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
