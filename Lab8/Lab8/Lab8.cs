using System;
using System.Text;

namespace Lab8
{
    public static class Lab8
    {
        public static string PrettifyList(string s)
        {
            if (s == null)
            {
                return null;
            }
            s = s.Trim();

            if (s.Length == 0)
            {
                return null;
            }

            StringBuilder builder = new StringBuilder(s.Length * 2);

            uint firstIndex = 1;

            string[] firstList = s.Split('|');

            for (uint i = 0; i < firstList.Length; i++)
            {
                builder.Append(firstIndex + ") ");
                if (firstList[i].Contains('_') == false)
                {
                    builder.AppendLine(firstList[i]);
                }
                else
                {
                    string[] secondList = firstList[i].Split('_');
                    char secondIndex = 'a';
                    builder.AppendLine(secondList[0]);

                    for (uint j = 1; j < secondList.Length; j++)
                    {
                        builder.Append("    " + secondIndex + ") ");
                        if (secondList[j].Contains('/'))
                        {
                            string[] thirdList = secondList[j].Split('/');
                            builder.AppendLine(thirdList[0]);
                            for (uint k = 1; k < thirdList.Length; k++)
                            {
                                builder.AppendLine("        " + "- " + thirdList[k]);
                            }
                        }
                        else
                        {
                            builder.AppendLine(secondList[j]);
                        }
                        secondIndex++;
                    }
                }
                firstIndex++;
            }

            return builder.ToString();
        }
    }
}
