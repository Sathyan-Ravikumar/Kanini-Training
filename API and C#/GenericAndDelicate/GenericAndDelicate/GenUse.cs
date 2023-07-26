using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericAndDelicate
{
    internal class GenUse<T> where T : Exception
    {
        private T excepobj;
        public GenUse(T excepobj)
        {
            this.excepobj = excepobj;
        }
        public T disp()
        {
            return excepobj;
        }


       /* private T[] arr;

        public GenUse(int size)
        {
            arr = new T[size];
        }
        public T getarr(int index)
        {
            return arr[index];
        }
        public void setarr(int index, T value)
        {
            arr[index] = value;
        }*/


        /* private T num;
         public GenUse(T num)
         {
             this.Num = num;
         }

         public T Num { get => num; set => num = value; }*/
    }
}