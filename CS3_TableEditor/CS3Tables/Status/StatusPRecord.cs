using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using CS3_TableEditor.CS3Tables.Name;

namespace CS3_TableEditor.CS3Tables.Status {
    public class StatusPRecord : TableRecord {

        public override int Size {
            get {
                return base.Size + rbc.GetByteLengthOfString(PName) + rbc.GetByteLengthOfString(cName)
                    + rbc.GetByteLengthOfString(aniFilename) + strangeField.Count + rbc.GetByteLengthOfString(flags)
                    + rbc.GetByteLengthOfString(OwnerName)
                    + rbc.GetByteLengthOfString(recordSuffix);
            }
        }

        public short OwnerID { get; set; }
        public string OwnerIDNameTableString {
            get {
                NameTableDataRecord nameRecord = nameTable.GetRecords().Where(i => i.OwnerID >= 0).FirstOrDefault(i => i.OwnerID == OwnerID);
                if (nameRecord == null) return null;
                return nameRecord.OverworldName;
            }
        }
        public string PName { get; set; } = "";
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
        public string OwnerName { get; set; } = "";
        private string recordSuffix = "";

        private NameTable nameTable;

        public StatusPRecord(List<byte> fileData, NameTable nameTable) : base(fileData, false) {
            this.nameTable = nameTable;
            OwnerID = rbc.ReadShort(fileData, Size);
            PName = rbc.GetNullTerminatedString(fileData, Size);
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
            OwnerName = rbc.GetNullTerminatedString(fileData, Size);
            recordSuffix = rbc.GetNullTerminatedString(fileData, Size);
        }

        public override List<byte> ToBytes() {
            List<byte> bytes = new List<byte>();
            bytes.AddRange(WriteBytesConverter.NumericToBytes(OwnerID));
            bytes.AddRange(WriteBytesConverter.NullTerminatedStringToBytes(PName));
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
            bytes.AddRange(WriteBytesConverter.NullTerminatedStringToBytes(OwnerName));
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
