using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    internal class Merge
    {
        //diziyi bölme işlemi
        public void divide(int[] array, int basIndex, int sonIndex)
        {
            if (basIndex < sonIndex)
            {
                int ortaIndex = (basIndex + sonIndex) / 2;
                divide(array, basIndex, ortaIndex);
                divide(array, ortaIndex + 1, sonIndex);
                conquer(array, basIndex, ortaIndex, sonIndex);
            }
        }


        //diziyi sıralama işlemi
        public void conquer(int[] array, int basIndex, int ortaIndex, int sonIndex)
        {

            //L[basIndex...ortaIndex]
            int sizeOfListL = ortaIndex - basIndex + 1;

            //M[ortaIndex+1...sonIndex]
            int sizeOfListM = sonIndex - ortaIndex;

            int[] L = new int[sizeOfListL];
            int[] M = new int[sizeOfListM];

            for (int i = 0; i < sizeOfListL; i++)
            {
                L[i] = array[basIndex + i];
            }
            for (int j = 0; j < sizeOfListM; j++)
            {
                M[j] = array[ortaIndex + 1 + j];
            }

            int l = 0, m = 0, k = basIndex;


            while (l < sizeOfListL && m < sizeOfListM)
            {
                if (L[l] <= M[m])
                {
                    array[k] = L[l];
                    l++;
                }
                else
                {
                    array[k] = M[m];
                    m++;
                }
                k++;
            }

            while (l < sizeOfListL)
            {
                array[k] = L[l];
                l++;
                k++;
            }

            while (m < sizeOfListM)
            {
                array[k] = M[m];
                m++;
                k++;
            }

        }
    }
}
