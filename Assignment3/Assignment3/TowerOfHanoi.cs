using System.Collections.Generic;

namespace Assignment3
{
    public static class TowerOfHanoi
    {

        public static int GetNumberOfSteps(int numDiscs)
        {
            if (numDiscs < 0)
            {
                return -1;
            }

            int steps = 1;
            for (int i = 0; i < numDiscs; i++)
            {
                steps *= 2;
            }

            return steps - 1;
        }

        public static List<List<int>[]> SolveTowerOfHanoi(int numDiscs)
        {
            if (numDiscs <= 0)
            {
                return new List<List<int>[]>();
            }

            List<List<int>[]> list = new List<List<int>[]>();
            List<int> first = new List<int>(numDiscs);
            List<int> second = new List<int>(numDiscs);
            List<int> third = new List<int>(numDiscs);

            for (int i = numDiscs; i > 0; i--)
            {
                first.Add(i);
            }

            List<int>[] array = new List<int>[3];

            array[0] = first;
            array[1] = second;
            array[2] = third;

            list.Add(array);

            Move(list, numDiscs, 0, 1, 2);

            return list;
        }

        public static void Move(List<List<int>[]> list, int n, int from, int by, int to)
        {
            if (n == 0)
            {
                return;
            }
            Move(list, n - 1, from, to, by);

            List<int>[] newList = new List<int>[3];
            List<int> first = new List<int>(list[list.Count - 1][0]);
            List<int> second = new List<int>(list[list.Count - 1][1]);
            List<int> third = new List<int>(list[list.Count - 1][2]);

            newList[0] = first;
            newList[1] = second;
            newList[2] = third;

            List<int> fromList = newList[from];
            int number = fromList[fromList.Count - 1];
            fromList.Remove(number);

            List<int> toList = newList[to];
            toList.Add(number);

            list.Add(newList);

            Move(list, n - 1, by, from, to);

        }


    }
}