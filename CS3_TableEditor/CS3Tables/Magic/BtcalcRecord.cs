using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CS3_TableEditor.CS3Tables.Magic {
    public class BtcalcRecord : TableRecord {

        public override int Size {
            get {
                return base.Size + strangeField.Count;
            }
        }

        private List<byte> strangeField = new List<byte>();

        public override List<byte> ToBytes() {
            List<byte> bytes = new List<byte>();
            bytes.AddRange(strangeField);
            bytes.InsertRange(0, ToBytes((short)bytes.Count));
            return bytes;
        }

        public BtcalcRecord(List<byte> fileData) : base(fileData, false) {
            strangeField = fileData.Skip(Size).Take(0xA - 2).ToList();
        }

    }
}
