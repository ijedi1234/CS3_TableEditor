using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CS3_TableEditor.CS3Tables.Status {
    public class StatusPRecord : TableRecord {

        public override int Size {
            get {
                return base.Size + rbc.GetByteLengthOfString(pName) + rbc.GetByteLengthOfString(cName)
                    + rbc.GetByteLengthOfString(aniFilename) + strangeField.Count + rbc.GetByteLengthOfString(flags)
                    + rbc.GetByteLengthOfString(ownerName)
                    + rbc.GetByteLengthOfString(recordSuffix);
            }
        }

        private OwnerType ownerID;
        private string pName = "";
        private string cName = "";
        private string aniFilename = "";
        private float unknownFloat1;
        private float unknownFloat2;
        private float unknownFloat3;
        private float unknownFloat4;
        private float unknownFloat5;
        private float unknownFloat6;
        private float unknownFloat7;
        private List<byte> strangeField = new List<byte>();
        private string flags = "";
        private string ownerName = "";
        private string recordSuffix = "";

        public StatusPRecord(List<byte> fileData) : base(fileData, false) {
            ownerID = (OwnerType)rbc.ReadShort(fileData, Size);
            pName = rbc.GetNullTerminatedString(fileData, Size);
            cName = rbc.GetNullTerminatedString(fileData, Size);
            aniFilename = rbc.GetNullTerminatedString(fileData, Size);
            unknownFloat1 = rbc.ReadFloat(fileData, Size);
            unknownFloat2 = rbc.ReadFloat(fileData, Size);
            unknownFloat3 = rbc.ReadFloat(fileData, Size);
            unknownFloat4 = rbc.ReadFloat(fileData, Size);
            unknownFloat5 = rbc.ReadFloat(fileData, Size);
            unknownFloat6 = rbc.ReadFloat(fileData, Size);
            unknownFloat7 = rbc.ReadFloat(fileData, Size);
            strangeField = fileData.Skip(Size).Take(0xA9).ToList();
            flags = rbc.GetNullTerminatedString(fileData, Size);
            ownerName = rbc.GetNullTerminatedString(fileData, Size);
            recordSuffix = rbc.GetNullTerminatedString(fileData, Size);
        }

        public override List<byte> ToBytes() {
            List<byte> bytes = new List<byte>();
            bytes.AddRange(WriteBytesConverter.NumericToBytes((short)ownerID));
            bytes.AddRange(WriteBytesConverter.NullTerminatedStringToBytes(pName));
            bytes.AddRange(WriteBytesConverter.NullTerminatedStringToBytes(cName));
            bytes.AddRange(WriteBytesConverter.NullTerminatedStringToBytes(aniFilename));
            bytes.AddRange(WriteBytesConverter.NumericToBytes(unknownFloat1));
            bytes.AddRange(WriteBytesConverter.NumericToBytes(unknownFloat2));
            bytes.AddRange(WriteBytesConverter.NumericToBytes(unknownFloat3));
            bytes.AddRange(WriteBytesConverter.NumericToBytes(unknownFloat4));
            bytes.AddRange(WriteBytesConverter.NumericToBytes(unknownFloat5));
            bytes.AddRange(WriteBytesConverter.NumericToBytes(unknownFloat6));
            bytes.AddRange(WriteBytesConverter.NumericToBytes(unknownFloat7));
            bytes.AddRange(strangeField);
            bytes.AddRange(WriteBytesConverter.NullTerminatedStringToBytes(flags));
            bytes.AddRange(WriteBytesConverter.NullTerminatedStringToBytes(ownerName));
            bytes.AddRange(WriteBytesConverter.NullTerminatedStringToBytes(recordSuffix));
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
