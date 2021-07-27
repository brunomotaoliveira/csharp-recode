using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    class Program {
        static void Main(string[] args) {
            //Tipos de dados
            int meuInteiro = 20;
            char meuChar = 'a';
            string minhaString = "palavra";

            float meuFloat = 10.5f; //f para float
            double meuDouble = 20.5;
            decimal meuDecimal = 20.5m; //m para decimal

            bool meuBool = true; //valor booleano true ou false

            int i = 3;
            Console.WriteLine(i);
            Console.WriteLine(i++);
            Console.WriteLine(i);

            int a = 1 + 2 + 3;
            int b =6;
            Console.WriteLine(a == b);

            char c1 = 'a';
            char c2 = 'A';
            Console.WriteLine(c1 == c2);
            Console.WriteLine(c1 == char.ToLower(c2));

            string S1 = "hello!";
            string s2 = "HeLLo!";

            string s3 = "Hello!";
            Console.WriteLine(S1 == s3);

        }
    }
}