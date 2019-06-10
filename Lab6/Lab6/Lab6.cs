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

        public static void TransformArray(int[,] data, EMode mode)
        {
            int row = data.GetLength(0);
            int column = data.GetLength(1);

            if (mode == EMode.HorizontalMirror)
            {
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < column / 2; j++)
                    {
                        int tmp = data[i, (column - 1) - j];
                        data[i, (column - 1) - j] = data[i, j];
                        data[i, j] = tmp;

                    }
                }
            }

            else if (mode == EMode.VerticalMirror)
            {
                for (int i = 0; i < row / 2; i++)
                {
                    for (int j = 0; j < column; j++)
                    {
                        int tmp = data[(row - 1) - i, j];
                        data[(row - 1) - i, j] = data[i, j];
                        data[i, j] = tmp;

                    }
                }
            }
        }

    }
}