using System.Collections.Generic;

namespace Lab9
{
    public static class Lab9
    {
        public static List<int> MergeLists(List<int> sortedList1, List<int> sortedList2)
        {
            List<int> combinedList = new List<int>(sortedList1.Count + sortedList2.Count);

            int i = 0;
            int j = 0;

            while (i < sortedList1.Count && j < sortedList2.Count)
            {
                if (sortedList1[i] < sortedList2[j])
                {
                    combinedList.Add(sortedList1[i]);
                    i++;
                }
                else
                {
                    combinedList.Add(sortedList2[j]);
                    j++;
                }
            }

            if (i < sortedList1.Count)
            {
                while (i < sortedList1.Count)

                {
                    combinedList.Add(sortedList1[i]);
                    i++;
                }
            }
            if (j < sortedList2.Count)
            {
                while (j < sortedList2.Count)

                {
                    combinedList.Add(sortedList2[j]);
                    j++;
                }
            }

            return combinedList;
        }

        public static Dictionary<string, int> CombineListsToDictionary(List<string> keys, List<int> values)
        {
            int length = keys.Count > values.Count ? values.Count : keys.Count;

            Dictionary<string, int> combinedDictionary = new Dictionary<string, int>(length);

            for (int i = 0; i < length; i++)
            {
                combinedDictionary.TryAdd(keys[i], values[i]);
            }

            return combinedDictionary;
        }

        public static Dictionary<string, decimal> MergeDictionaries(Dictionary<string, int> numerators, Dictionary<string, int> denominators)
        {
            Dictionary<string, decimal> mergedDicionary = new Dictionary<string, decimal>();

            if (numerators.Count == 0 || denominators.Count == 0)
            {
                return mergedDicionary;
            }

            foreach (var pair in denominators)
            {
                if (numerators.ContainsKey(pair.Key) == true && pair.Value != 0)
                {
                    decimal result = numerators[pair.Key] / (decimal)pair.Value;
                    if (result < 0)
                    {
                        result *= -1;
                    }

                    mergedDicionary.Add(pair.Key, result);
                }
            }

            return mergedDicionary;
        }
    }
}