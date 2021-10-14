using System;
using System.Collections.Generic;
using System.Text;

namespace TestStudente
{
    class LIbro
    {
        private int nPagine;
        private string autore, titolo;

        public LIbro(int n, string a,string t)
        {
            nPagine = n;
            autore = a;
            titolo = t;
        }
        public Studente Proprietario { get; set; }

    }
}
