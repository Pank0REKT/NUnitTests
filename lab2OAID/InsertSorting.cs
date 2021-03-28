using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2OAID
{
    public class InsertSorting
    {
        public static int[] InsertionSort(int[] a)
        {
            if (a == null)
                throw new
                    ArgumentException("Ошибка. В метод передан пустой массив.");
            int[] res = a; 
            for (int i = 1; i < a.Length; i++)
            {
                int cur = a[i];
                int j = i;
                while (j > 0 && cur < a[j - 1])
                {
                    a[j] = a[j - 1];
                    j--;
                }
                a[j] = cur;
                res[j] = cur;
            }
            return res;
        }
    }
}
