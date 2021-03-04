using System;

namespace ISummeerija
{
    class Program
    {
        static void Main(string[] args)
        {
         ISummeerija summeerija1 = new LiitevSummeerija();
            summeerija1.Alusta();
            summeerija1.Lisa(5);
            summeerija1.Lisa(4);
            summeerija1.KysiSumma();
            summeerija1.Alusta();
            summeerija1.Lisa(10);
            summeerija1.Lisa(-5);
            Console.WriteLine(summeerija1.KysiSumma());
        }
    }
}
