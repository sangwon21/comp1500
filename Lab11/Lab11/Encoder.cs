using System.IO;

namespace Lab11
{
    public static class Encoder
    {
        public static bool TryEncode(Stream input, Stream output)
        {
            if(input.Length == 0)
            {
                return false;
            }

            int previous = -1;
            uint count = 0;
            for(int i= 0; i < input.Length; i++)
            {
                int value = input.ReadByte();
                if(previous == -1)
                {
                    previous = value;
                    count++;
                    continue;
                }
                if(value != previous)
                {
                    output.WriteByte((byte)previous);
                    output.WriteByte((byte)count);
                    previous = value;
                    count = 0;
                    continue;
                }
                count++;
            }
            return false;
        }

        public static bool TryDecode(Stream input, Stream output)
        {
            return false;
        }
    }
}