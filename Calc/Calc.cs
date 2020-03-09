using System;
using System.Collections.Generic;
using System.Text;

namespace Calc
{
    public class CalcCore
    {
        public CalcCore()
        {

        }
        public object Feldolgoz(string v)
        {

            if (v == "")
            {
                throw new FormatException();
            }
            else {
                if ( v.IndexOf('-') > 0 ) {
                    return kivonas(v);
                }
                if( v.IndexOf('+') > 0)
                {
                    return osszeadas(v);
                }
            }
            throw new NotImplementedException();
        }

        /// <summary>
        /// Ez egy kivonást megvalósító függvény
        /// </summary>
        /// <param name="v">A kivonás két tényezője műveleti jellel, string-ként</param>
        /// <returns>A kivonás eredményét adja vissza INT ként</returns>
        private  int kivonas(String v) {

            int eredmeny = 0;

            char minus = '-';

            int minusPos = v.IndexOf(minus);
            int elsoSzam = Int32.Parse( v.Substring( 0, minusPos ) );
            int masodikSzam = Int32.Parse( v.Substring(minusPos+1, v.Length) );

            eredmeny = elsoSzam - masodikSzam;
            return eredmeny;
        }

        /// <summary>
        /// Egy összeadást végez
        /// </summary>
        /// <param name="v">A két operandust várja műveleti jelle, string-ként</param>
        /// <returns>Az összeadás eredményét adja vissza INTként</returns>
        private int osszeadas(String v) {
            int eredmeny = 0;

            char plus = '+';

            int plusPos = v.IndexOf(plus);
            int elsoSzam = Int32.Parse( v.Substring(0, plusPos));
            int masodikSzam = Int32.Parse( v.Substring( plusPos ) );

            eredmeny = elsoSzam + masodikSzam;
            return eredmeny;
        }
    }
}
