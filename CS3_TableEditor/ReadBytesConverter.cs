using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CS3_TableEditor {
    public class ReadBytesConverter {

        private int nullTerminators = 0;
        private int bytesRead = 0;
        private int shortsRead = 0;
        private int intsRead = 0;
        private int longsRead = 0;
        private int floatsRead = 0;

        public int GetByteLengthOfString(string str) {
            return Encoding.UTF8.GetBytes(str).Length;
        }

        public byte ReadByte(List<byte> fileData, int bytes2skip) {
            byte result = fileData.Skip(bytes2skip).Take(1).First();
            bytesRead++;
            return result;
        }

        public short ReadShort(List<byte> fileData, int bytes2skip) {
            ReadOnlySpan<byte> byteSpan = new ReadOnlySpan<byte>(fileData.Skip(bytes2skip).Take(2).ToArray());
            shortsRead++;
            return BitConverter.ToInt16(byteSpan);
        }

        public int ReadInt(List<byte> fileData, int bytes2skip) {
            ReadOnlySpan<byte> byteSpan = new ReadOnlySpan<byte>(fileData.Skip(bytes2skip).Take(4).ToArray());
            intsRead++;
            return BitConverter.ToInt32(byteSpan);
        }

        public long ReadLong(List<byte> fileData, int bytes2skip) {
            ReadOnlySpan<byte> byteSpan = new ReadOnlySpan<byte>(fileData.Skip(bytes2skip).Take(8).ToArray());
            longsRead++;
            return BitConverter.ToInt64(byteSpan);
        }

        public float ReadFloat(List<byte> fileData, int bytes2skip) {
            ReadOnlySpan<byte> byteSpan = new ReadOnlySpan<byte>(fileData.Skip(bytes2skip).Take(8).ToArray());
            floatsRead++;
            return BitConverter.ToSingle(byteSpan);
        }

        public string GetNullTerminatedString(List<byte> fileData, int bytes2skip) {
            List<byte> workingFileData = fileData.Skip(bytes2skip).ToList();
            int nullTerminatorIndex = workingFileData.IndexOf(0);
            string item = Encoding.UTF8.GetString(workingFileData.GetRange(0, nullTerminatorIndex).ToArray());
            nullTerminators++;
            return item;
        }

        public int GetNullTerminatorCount() { return nullTerminators; }

        public int GetBytesRead() { return bytesRead; }

        public int GetShortsRead() { return shortsRead; }

        public int GetIntsRead() { return intsRead; }

        public int GetLongsRead() { return longsRead; }
        public int GetFloatsRead() { return floatsRead; }
    }
}
