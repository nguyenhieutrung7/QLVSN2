using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Bus
{
    public class KetQuaXoSoBus
    {
        public bool do2So(int soCanDo,int soTrung)
        {
            if (soCanDo == soTrung)
            {
                return true;
            }
            int count = 0;
            int temp = soTrung;
            while (temp != 0)
            {
                // n = n/10
                temp /= 10;
                ++count;
            }
            int n = soCanDo;
            for(int i = 1; i <= 6 - count; i++)
            {
                n = n % (int)Math.Pow(10, (int)Math.Log10(n));
            }
            if (n == soTrung)
            {
                return true;
            }
            
            return false;
        }

        public bool doSoKhuyenKhich(int soCanDo, int soTrung)
        {
            if (soCanDo == soTrung)
            {
                return false;
            }
            int count = 0;
            while (soTrung != 0)
            {
                int x1 = soTrung % 10;
                int x2 = soCanDo % 10;
                if (x1 == x2)
                {
                    count++;
                }
                soCanDo = soCanDo / 10;
                soTrung = soTrung / 10;
            }
            if (count == 5)
                return true;
            else return false;
        }
    }
}
