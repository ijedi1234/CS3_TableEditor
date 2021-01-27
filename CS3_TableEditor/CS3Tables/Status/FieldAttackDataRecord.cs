using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CS3_TableEditor.CS3Tables.Status {
    public class FieldAttackDataRecord : TableRecord {

        public override int Size {
            get {
                return base.Size + strangeField1.Count + strangeField2.Count;
            }
        }

        public OwnerType OwnerID { get; set; }
        private byte unknownByte;
        private float unknownFloat1;
        private float unknownFloat2;
        private float unknownFloat3;
        private float unknownFloat4;
        private float unknownFloat5;
        private List<byte> strangeField1 = new List<byte>();
        private List<byte> strangeField2 = new List<byte>();

        public FieldAttackDataRecord(List<byte> fileData) : base(fileData, false) {
            OwnerID = (OwnerType)rbc.ReadShort(fileData, Size);
            unknownByte = rbc.ReadByte(fileData, Size);
            unknownFloat1 = rbc.ReadFloat(fileData, Size);
            unknownFloat2 = rbc.ReadFloat(fileData, Size);
            unknownFloat3 = rbc.ReadFloat(fileData, Size);
            unknownFloat4 = rbc.ReadFloat(fileData, Size);
            strangeField1 = fileData.Skip(Size).Take(0x7).ToList();
            unknownFloat5 = rbc.ReadFloat(fileData, Size);
            strangeField2 = fileData.Skip(Size).Take(0x3).ToList();
        }

        public override List<byte> ToBytes() {
            List<byte> bytes = new List<byte>();
            bytes.AddRange(WriteBytesConverter.NumericToBytes((short)OwnerID));
            bytes.InsertRange(0, ToBytes((short)bytes.Count));
            return bytes;
        }

        new public string ToString() {
            string result = "";
            foreach (byte item in strangeField2) result += item.ToString("X2");
            return result;
        }

    }
}
