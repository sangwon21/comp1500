namespace Lab7
{
    public static class Lab7
    {
        public static bool PlayGame(uint[] array)
        {
            if (array.Length <= 1)
            {
                return false;
            }

            bool[] bArray = new bool[array.Length];

            return HelpGame(array, (int)array[0], bArray);
        }

        public static bool HelpGame(uint[] array, int currentIndex, bool[] bArray)
        {
            if (currentIndex <= 0 || currentIndex >= array.Length)
            {
                return false;
            }

            if (currentIndex == (long)array.Length - 1)
            {
                return true;
            }

            if (bArray[currentIndex] == true)
            {
                return false;
            }

            bArray[currentIndex] = true;


            return HelpGame(array, currentIndex + (int)array[currentIndex], bArray) || HelpGame(array, currentIndex - (int)array[currentIndex], bArray);
        }
    }
}