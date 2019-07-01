﻿using System.Diagnostics;
using System;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            uint[] array = new uint[0];
            bool bPass = Lab7.PlayGame(array);

            Debug.Assert(!bPass);

            array = new uint[1] { 0 };
            bPass = Lab7.PlayGame(array);

            Debug.Assert(!bPass);

            array = new uint[2] { 1, 0 };
            bPass = Lab7.PlayGame(array);

            Debug.Assert(bPass);

            array = new uint[4] { 2, 5, 1, 0 };
            bPass = Lab7.PlayGame(array);

            Debug.Assert(bPass);

            array = new uint[9] { 4, 3, 4, 4, 1, 5, 7, 1, 0 };
            bPass = Lab7.PlayGame(array);

            Debug.Assert(bPass);

            array = new uint[10] { 6, 1, 5, 2, 4, 8, 2, 1, 4, 0 };
            bPass = Lab7.PlayGame(array);

            Debug.Assert(!bPass);

            array = new uint[12] { 3, 6, 2, 4, 4, 6, 1, 1, 4, 5, 1, 0 };
            bPass = Lab7.PlayGame(array);

            Debug.Assert(bPass);

            array = new uint[0];
            bPass = Lab7.PlayGame(array); // false

            Debug.Assert(!bPass);

            array = new uint[3] { 3, 2, 0 };
            bPass = Lab7.PlayGame(array); // false

            Debug.Assert(!bPass);

            array = new uint[3] { 2, 2, 0 };
            bPass = Lab7.PlayGame(array); // true

            Debug.Assert(bPass);

            array = new uint[3] { 1, 1, 0 };
            bPass = Lab7.PlayGame(array); // true

            Debug.Assert(bPass);

            array = new uint[7] { 3, 1, 4, 2, 8, 6, 0 };
            bPass = Lab7.PlayGame(array); // true

            Debug.Assert(bPass);

            array = new uint[3] { 5, 4, 1 };
            bPass = Lab7.PlayGame(array);

            Debug.Assert(!bPass);

            array = new uint[] { 3, 1, 1, 1, 5, 6, 7, 1, 1, 1, 7, 0 };
            bPass = Lab7.PlayGame(array);

            Debug.Assert(bPass);

            Console.WriteLine("he");
        }
    }
}