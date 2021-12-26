using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp13
{
    class fiyat

    {
        public double carpma(double litre)
        
        {
            double sonuc = 0;
            
            
            {
                if ((litre > 0) && (litre <= 2))
                {
                    sonuc = litre * 5.5;
                }

                else if ((litre > 2) && (litre <= 5))

                {
                    sonuc = litre * 5;
                }
                else if ((litre > 5) && (litre <= 7))
                {
                    sonuc = litre * 4.5;
                }
                else if ((litre > 7) && (litre <= 10))
                {
                    sonuc = litre * 4;
                }
                else if (litre > 10)
                {
                    sonuc = litre * 3.5;
                }
                else
                {

                }
                return sonuc;



            }


        }
    }
}
