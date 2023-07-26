using GenericAndDelicate;


public delegate void MyDelegate(string message);   //declaring a delecate outside the class
class program
{
    //static ArithmeticException arithmeticException;


   /* static void Swap<T>(ref T a, ref T b)
    {
        T temp;
        temp= a;
        a= b;
      b= temp;
    }*/

    static void InvokeDelegate(MyDelegate del)
    {
        del("hello world"); //delegate as a parameter
    }
    public static void Main(string[] args)
    {

        /*3 steps for delegate
         * declare a delegate
         * set a target method
         * invoke a delegate
          */

        /*     MyDelegate delobj1,delobj2;
             delobj1= DelegateUse.Method1;
              // delobj1("Sathya");  //can use the Invoke() or ().
             delobj2 = Del1.Method2;
             //  delobj2.Invoke("6369247198");

             InvokeDelegate(delobj1);
             InvokeDelegate(delobj2);       */

        MyDelegate del1 = DelegateUse.Method1;
        del1.Invoke("sath");
        MyDelegate del2 = Del1.Method2;
        del2.Invoke("yan");
        MyDelegate del = del1 + del2;
        Console.WriteLine("After : ");
        del("Hii");


          







 //Generic - method,field,class
         /*  int n1 = 10, n2 = 20;
        char c1 = 'a', c2 = 'b';
        Swap<int>(ref n1, ref n2);
        Swap<char>(ref c1, ref c2);
        Console.WriteLine("a= {0} b={1}", n1, n2);
        Console.WriteLine("c= {0} d={1}", c1, c2);   */


        /* GenUse<ArithmeticException> ae = new GenUse<ArithmeticException>(arithmeticException);

         Console.Write(ae.disp().Message);*/

        /* GenUse<int> intarr = new GenUse<int>(5);

          for(int i = 0; i < 5; i++)
          {
              intarr.setarr(i,(i+1)*4);
          }
           for(int i = 0; i < 5; i++)
          {
              Console.WriteLine(intarr.getarr(i));
          }

          GenUse<char> chararr = new GenUse<char>(5);
          for (int i = 0; i < 5; i++)
          {
              chararr.setarr(i, Convert.ToChar(i+97));
          }
          for (int i = 0; i < 5; i++)
          {
              Console.WriteLine(chararr.getarr(i));
          }*/

        /*GenUse<int> guint = new GenUse<int>(100);
        GenUse<double> gdouble= new GenUse<double>(10.12343);
        GenUse<string> gstring = new GenUse<string>("sathyan");

        Console
            .WriteLine("integer :" +guint.Num);

        Console
            .WriteLine("Double :" + gdouble.Num);

        Console
            .WriteLine("String :" + gstring.Num);*/
    }
   
}