using System;

namespace ValuesAndReference
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            string b = "hello";
            Entity c = new Entity();
            c.number = 1;
            c.text = "text";
            int[] d = new int[] { 1 };
            string[] e = new string[] { "yo" };

            MakeChangesWithNoReturn(a, b, c, d, e);

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c.number);
            Console.WriteLine(c.text);
            Console.WriteLine(d[0]);
            Console.WriteLine(e[0]);
        }

        public class Entity
        {
            public string text;
            public int number;
        }

        public static void MakeChangesWithNoReturn(int a, string b, Entity c, int[] d, string[] e)
        {
            a = 2;
            b = "bye";
            c.number = 2;
            c.text = "changed text";
            d[0] = 2;
            e[0] = "yoyo";
        }
    }
}
