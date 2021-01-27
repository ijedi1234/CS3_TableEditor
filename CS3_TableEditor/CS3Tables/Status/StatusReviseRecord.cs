using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CS3_TableEditor.CS3Tables.Status {
    public class StatusReviseRecord : TableRecord {

        public override int Size {
            get {
                return base.Size;
            }
        }

        public short ID { get; set; }
        public short HPMultiplier { get; set; }
        public short STRMultiplier { get; set; }
        public short DEFMultiplier { get; set; }
        public short ATSMultiplier { get; set; }
        public short ADFMultiplier { get; set; }
        public short SPDMultiplier { get; set; }
        public short BreakMultiplier { get; set; }

        public StatusReviseRecord(List<byte> fileData) : base(fileData, false) {
            ID = rbc.ReadShort(fileData, Size);
            HPMultiplier = rbc.ReadShort(fileData, Size);
            STRMultiplier = rbc.ReadShort(fileData, Size);
            DEFMultiplier = rbc.ReadShort(fileData, Size);
            ATSMultiplier = rbc.ReadShort(fileData, Size);
            ADFMultiplier = rbc.ReadShort(fileData, Size);
            SPDMultiplier = rbc.ReadShort(fileData, Size);
            BreakMultiplier = rbc.ReadShort(fileData, Size);
        }

        public override List<byte> ToBytes() {
            List<byte> bytes = new List<byte>();
            bytes.AddRange(WriteBytesConverter.NumericToBytes(ID));
            bytes.AddRange(WriteBytesConverter.NumericToBytes(STRMultiplier));
            bytes.AddRange(WriteBytesConverter.NumericToBytes(DEFMultiplier));
            bytes.AddRange(WriteBytesConverter.NumericToBytes(ATSMultiplier));
            bytes.AddRange(WriteBytesConverter.NumericToBytes(ADFMultiplier));
            bytes.AddRange(WriteBytesConverter.NumericToBytes(SPDMultiplier));
            bytes.AddRange(WriteBytesConverter.NumericToBytes(BreakMultiplier));
            bytes.InsertRange(0, ToBytes((short)bytes.Count));
            return bytes;
        }

    }
}
