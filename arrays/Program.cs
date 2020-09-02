using System;

namespace arrays
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string[] linguagens = new string[4];
            linguagens[0] = "c#";
            linguagens[1] = "JS";
            linguagens[2] = "java";
            linguagens[3] = "cobol";

            Console.WriteLine("linguagem de programacao: 0 " + linguagens[0]);
            Console.WriteLine("linguagem de programacao: 1 " + linguagens[1]);
            Console.WriteLine("linguagem de programacao: 2 " + linguagens[2]);
            Console.WriteLine("linguagem de programacao: 3 " + linguagens[3]);


        }
    }
}
