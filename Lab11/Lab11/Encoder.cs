using System.IO;

namespace Lab11
{
    public static class Encoder
    {
        public static bool TryEncode(Stream input, Stream output)
        {
            if (input.Length == 0)
            {
                return false;
            }

            int previous = -1;
            uint count = 0;
            for (int i = 0; i < input.Length; ++i)
            {
                int value = input.ReadByte();
                if (previous == -1)
                {
                    previous = value;
                    count++;
                    continue;
                }
                if (count == 255)
                {
                    output.WriteByte((byte)count);
                    output.WriteByte((byte)previous);
                    count = 1;
                    continue;
                }
                if (value != previous)
                {
                    output.WriteByte((byte)count);
                    output.WriteByte((byte)previous);
                    previous = value;
                    count = 1;
                    continue;
                }
                count++;
            }
            output.WriteByte((byte)count);
            output.WriteByte((byte)previous);
            output.Seek(0, SeekOrigin.Begin);
            input.Seek(0, SeekOrigin.Begin);
            return true;
        }

        public static bool TryDecode(Stream input, Stream output)
        {
            if (input.Length == 0)
            {
                return false;
            }

            for (int i = 0; i < input.Length; i++)
            {
                int count = input.ReadByte();
                int value = input.ReadByte();

                for (int j = 0; j < count; j++)
                {
                    output.WriteByte((byte)value);
                }
            }
            output.Seek(0, SeekOrigin.Begin);
            input.Seek(0, SeekOrigin.Begin);
            return true;
        }
    }
}