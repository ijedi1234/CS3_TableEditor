using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CS3_TableEditor.CS3Tables.Status {
    public class CharReviseRecord : TableRecord {

        public override int Size {
            get {
                return base.Size + rbc.GetByteLengthOfString(charName) + strangeField.Count;
            }
        }

        private string charName = "";
        private List<byte> strangeField = new List<byte>();

        public CharReviseRecord(List<byte> fileData) : base(fileData, false) {
            charName = rbc.GetNullTerminatedString(fileData, Size);
            strangeField = fileData.Skip(Size).Take(0xe).ToList();
        }

        public override List<byte> ToBytes() {
            List<byte> bytes = new List<byte>();
            bytes.AddRange(WriteBytesConverter.NullTerminatedStringToBytes(charName));
            bytes.AddRange(strangeField);
            bytes.InsertRange(0, ToBytes((short)bytes.Count));
            return bytes;
        }

        new public string ToString() {
            string result = "";
            foreach (byte item in strangeField) result += item.ToString("X2");
            return result;
        }

    }
}
