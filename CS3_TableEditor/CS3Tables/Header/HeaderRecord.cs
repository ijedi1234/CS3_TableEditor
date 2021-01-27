using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Buffers.Binary;

namespace CS3_TableEditor.CS3Tables.Header {
    public class HeaderRecord : TableRecord {

        public int RecordCount { get; set; }

        public HeaderRecord(List<byte> fileData) : base(fileData, true) {
            RecordCount = 0;
        }

        public override List<byte> ToBytes() {
            List<byte> bytes = ToBytes(RecordCount);
            return bytes;
        }

    }
}
