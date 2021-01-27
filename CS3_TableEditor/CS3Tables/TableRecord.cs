using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CS3_TableEditor.CS3Tables {
    public abstract class TableRecord {

        public virtual int Size {
            get {
                return rbc.GetByteLengthOfString(tableRowType) + rbc.GetNullTerminatorCount()
                    + rbc.GetBytesRead() * sizeof(byte)
                    + rbc.GetShortsRead() * sizeof(short)
                    + rbc.GetIntsRead() * sizeof(int)
                    + rbc.GetLongsRead() * sizeof(long)
                    + rbc.GetFloatsRead() * sizeof(float);
            }
        }

        public int InitialSize { get; }

        private string tableRowType = "";
        protected ReadBytesConverter rbc;

        public TableRecord(List<byte> fileData, bool isHeader) {
            rbc = new ReadBytesConverter();
            tableRowType = rbc.GetNullTerminatedString(fileData, Size);
            //This is the size, but it will be recalculated during the write stage. Its bytes are derived by subclasses
            if(isHeader)
                InitialSize = rbc.ReadInt(fileData, Size);
            else
                InitialSize = rbc.ReadShort(fileData, Size);
        }

        public List<byte> ToBytes(int size) {
            List<byte> bytes = WriteBytesConverter.NullTerminatedStringToBytes(tableRowType);
            bytes.AddRange(WriteBytesConverter.NumericToBytes(size));
            return bytes;
        }

        public List<byte> ToBytes(short size) {
            List<byte> bytes = WriteBytesConverter.NullTerminatedStringToBytes(tableRowType);
            bytes.AddRange(WriteBytesConverter.NumericToBytes(size));
            return bytes;
        }

        public abstract List<byte> ToBytes();

        public string GetRowType() { return tableRowType; }

    }
}
