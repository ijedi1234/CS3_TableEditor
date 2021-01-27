using System;
using System.Collections.Generic;
using System.Text;

namespace CS3_TableEditor.CS3Tables.Header {
    public class HeaderPrefixRecord {

        protected ReadBytesConverter rbc;
        public short TableID { get; set; }
        public int NumHeaders { get; set; }

        public HeaderPrefixRecord(List<byte> fileData) {
            rbc = new ReadBytesConverter();
            TableID = rbc.ReadShort(fileData, 0);
            NumHeaders = rbc.ReadInt(fileData, sizeof(short));
        }

        public List<byte> ToBytes() {
            List<byte> bytes = new List<byte>();
            bytes.AddRange(WriteBytesConverter.NumericToBytes(TableID));
            bytes.AddRange(WriteBytesConverter.NumericToBytes(NumHeaders));
            return bytes;
        }

    }
}
