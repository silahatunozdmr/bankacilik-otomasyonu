using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankacilik2
{
    internal class HesapBilgileri
    {
        private double hesapToplami = 150000;
        public double HesapToplami
        {
            get { return hesapToplami; }
            set
            {
                if (value <= hesapToplami && value >= 0)
                    hesapToplami = value;
            }
        }


    }
}
