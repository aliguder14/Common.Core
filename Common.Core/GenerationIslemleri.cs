using SecurityDriven.Inferno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Core
{
    public class GenerationIslemleri
    {

        private static CryptoRandom _rnd = new(); 
        
        public static long GenerateTCKN()
        {
            long minimumTCKN = 10000000078L;
            long maksimumTCKN = 99999999990L;

            long generatedTCKN = _rnd.NextLong(minimumTCKN, maksimumTCKN + 1);

            if (!ValidationIslemleri.ValidTCKN(generatedTCKN))
            {
                return GenerateTCKN();
            }

            return generatedTCKN;
        }

        public static long GetMinimumValidTCKN()
        {

            long tckn = 10_000_000_000L;
            while (!ValidationIslemleri.ValidTCKN(tckn))
            {
                tckn++;
            }
            
             return tckn;
        }

        public static long GetMaximumValidTCKN()
        {

            long tckn = 99_999_999_999L;
            while (!ValidationIslemleri.ValidTCKN(tckn))
            {
                tckn--;
            }

            return tckn;
        }


    }
}
