using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CS3_TableEditor.CS3Tables.Status {
    public class GameDifficultyRecord : TableRecord {

        public override int Size {
            get {
                return base.Size;
            }
        }

        public short ID { get; set; }
        public short UnknownShort { get; set; }

        public GameDifficultyRecord(List<byte> fileData) : base(fileData, false) {
            ID = rbc.ReadShort(fileData, Size);
            UnknownShort = rbc.ReadShort(fileData, Size);
        }

        public override List<byte> ToBytes() {
            List<byte> bytes = new List<byte>();
            bytes.AddRange(WriteBytesConverter.NumericToBytes(ID));
            bytes.AddRange(WriteBytesConverter.NumericToBytes(UnknownShort));
            bytes.InsertRange(0, ToBytes((short)bytes.Count));
            return bytes;
        }

    }
}
