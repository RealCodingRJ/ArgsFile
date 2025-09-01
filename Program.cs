using System;
using System.Collections;

namespace intro
{
    class Program
    {
        public static void GenerateArrays(string[] args)
        {

            ArrayList languages = [];

            languages.Add("--cs");

            foreach (var a in languages)
            {

                if (args[1].Equals(a))
                {

                    File.Create(args[2]);

                }


            }

        }

        static void Main(string[] args)
        {
            GenerateArrays(args);

        }

    }

}