#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_2
{
    internal class Element
    {
        public Element? nastepny;

        public Element? poprzedni;

        public int wartosc;

        public Element(int wartosc) {
            this.wartosc = wartosc;
        }
    }
}
