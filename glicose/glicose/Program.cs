﻿using System;
using System.Globalization;
namespace revisao_logica_de_programacao
{
    class Program
    {
        static void Main(string[] args)
        {
            double glicose;
            glicose = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (glicose <= 100.0)
            {
                Console.WriteLine("Normal");
            }
            else if (glicose <= 140.0)
            {
                Console.WriteLine("Elevado");
            }
            else
            {
                Console.WriteLine("Diabetes");
            }
            Console.ReadLine();
        }
    }
}