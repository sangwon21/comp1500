﻿namespace Lab7
{
    public static class Lab7
    {
        public static bool PlayGame(uint[] array)
        {
            if (array.Length == 0 || array.Length == 1)
            {
                return false;
            }
            return HelpGame(array, (long)array[0], 0, 2);
        }

        public static bool HelpGame(uint[] array, long currentIndex, long previousIndex, int plusMinus)
        {
            if (currentIndex <= 0 || currentIndex >= array.Length)
            {
                return false;
            }

            if (array[currentIndex] == 0)
            {
                return true;
            }

            if (plusMinus == 0 && array[currentIndex] == array[previousIndex])
            {
                return HelpGame(array, currentIndex + (long)array[currentIndex], currentIndex, 0);
            }

            if (plusMinus == 1 && array[currentIndex] == array[previousIndex])
            {
                return HelpGame(array, currentIndex - (long)array[currentIndex], currentIndex, 1);
            }


            return HelpGame(array, currentIndex + (long)array[currentIndex], currentIndex, 0) || HelpGame(array, currentIndex - (long)array[currentIndex], currentIndex, 1);
        }
    }
}