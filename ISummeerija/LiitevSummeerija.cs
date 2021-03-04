using System;
using System.Collections.Generic;
using System.Text;

namespace ISummeerija
{
    class LiitevSummeerija : ISummeerija
    {
        private int _summa;

        public void Alusta()
        {
            _summa = 0;
        }

        public int KysiSumma()
        {
         return _summa;
        }

        public void Lisa(int arv)
        {
            _summa += arv;
        }
    }
}
