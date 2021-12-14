using MaqaLibrary;
using System;

namespace Calculation

{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator Count = new Calculator();//toplama
            Count.Countt(3,7);

            Calculator Count2 = new Calculator();//cixma
            Count2.Countt2(4, 5);

            Calculator Count3 = new Calculator();//bolme
            Console.WriteLine(Count3.Countt3(10,5));

            Calculator Count4 = new Calculator();//Vurma
            Console.WriteLine(Count4.Countt4(3,8));


        }
    }
}
