using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankacilik2
{
    internal class KisiselBilgiler
    {
        private string ad = "sıla";
        private string soyad = "hatun";
        private int id = 123;
        private bool bilgiler = false;

        public string Ad { get { return ad; } }
        public string Soyad { get { return soyad; } }
        public int Id { get { return id; } }

        public bool Bilgiler { get { return bilgiler; }  set { bilgiler = value; } }
    }
}
