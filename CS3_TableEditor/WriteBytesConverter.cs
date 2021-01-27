using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CS3_TableEditor {
    public class WriteBytesConverter {

        public static List<byte> NullTerminatedStringToBytes(string str) {
            List<byte> bytes = Encoding.UTF8.GetBytes(str).ToList();
            bytes.Add(0);
            return bytes;
        }

        public static List<byte> NumericToBytes(short value) {
            return BitConverter.GetBytes(value).ToList();
        }

        public static List<byte> NumericToBytes(int value) {
            return BitConverter.GetBytes(value).ToList();
        }

        public static List<byte> NumericToBytes(long value) {
            return BitConverter.GetBytes(value).ToList();
        }

        public static List<byte> NumericToBytes(float value) {
            return BitConverter.GetBytes(value).ToList();
        }

    }
}
