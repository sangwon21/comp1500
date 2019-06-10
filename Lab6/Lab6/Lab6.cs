namespace Lab6
{
    public static class Lab6
    {
        public static int[,] Rotate90Degrees(int[,] vector)
        {
            int row = vector.GetLength(0);
            int column = vector.GetLength(1);

            int[,] newVector = new int[column, row];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    newVector[j, (row - 1) - i] = vector[i, j];
                }
            }

            return newVector;
        }
    }
}