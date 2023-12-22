using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Chohesion
{
    public class SequentialCohesion
    {
        public byte[] Transform(string input)
        {
            var compressed = Compress(input);
            return Encrypt(compressed);
        }

        private byte[] Compress(string input)
        {
            byte[] byteArray = System.Text.Encoding.Unicode.GetBytes(input);
            return byteArray;
        }
        private byte[] Encrypt(byte[] input) {

            byte[] encryptByteArray = new byte[] { };
            return encryptByteArray;
        }
    }
}
