﻿using System;
using Tabuleiro;

namespace Xadrez_Console
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Posicao P;

            P = new Posicao(3, 4);

            Console.WriteLine($"Posição : {P}");
        }
    }
}