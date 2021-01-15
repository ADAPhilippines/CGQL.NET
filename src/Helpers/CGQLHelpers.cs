using System;
using System.Linq;

namespace CGQL.NET.Server.GraphQL
{
    public static class CGQLHelpers
    {
        public static byte[] HexStringToByteArray(string hash)
        {
            byte[] buffer = new byte[hash.Length / 2];
            for(int x = 0; x < hash.Length; x += 2)
            {
                buffer[x / 2] =  Convert.ToByte(hash.Substring(x, 2), 16);
            }
            return buffer;
        }

        public static string ByteArrayToHexString(byte[] buffer)
        {
            return string.Concat(buffer.Select(b => b.ToString("x2")));
        }
    }
}