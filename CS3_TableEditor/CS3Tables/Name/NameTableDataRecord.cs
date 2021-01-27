using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CS3_TableEditor.CS3Tables.Name {
    public class NameTableDataRecord : TableRecord {

        public override int Size {
            get {
                return base.Size + rbc.GetByteLengthOfString(OverworldName) + rbc.GetByteLengthOfString(CName)
                    + rbc.GetByteLengthOfString(AnimationName) + rbc.GetByteLengthOfString(FaceCName)
                    + rbc.GetByteLengthOfString(FaceAnimationName) + rbc.GetByteLengthOfString(Name) + strangeField.Count;
            }
        }

        public short OwnerID { get; set; }
        public string OverworldName { get; set; } = "";
        public string CName { get; set; } = "";
        public string AnimationName { get; set; } = "";
        public string FaceCName { get; set; } = "";
        public string FaceAnimationName { get; set; } = "";
        public string Name { get; set; } = "";
        private List<byte> strangeField = new List<byte>();

        public NameTableDataRecord(List<byte> fileData) : base(fileData, false) {
            OwnerID = rbc.ReadShort(fileData, Size);
            OverworldName = rbc.GetNullTerminatedString(fileData, Size);
            CName = rbc.GetNullTerminatedString(fileData, Size);
            AnimationName = rbc.GetNullTerminatedString(fileData, Size);
            FaceCName = rbc.GetNullTerminatedString(fileData, Size);
            FaceAnimationName = rbc.GetNullTerminatedString(fileData, Size);
            Name = rbc.GetNullTerminatedString(fileData, Size);
            strangeField = fileData.Skip(Size).Take(0x13).ToList();
        }

        public override List<byte> ToBytes() {
            List<byte> bytes = new List<byte>();
            bytes.AddRange(WriteBytesConverter.NumericToBytes(OwnerID));
            bytes.AddRange(WriteBytesConverter.NullTerminatedStringToBytes(OverworldName));
            bytes.AddRange(WriteBytesConverter.NullTerminatedStringToBytes(CName));
            bytes.AddRange(WriteBytesConverter.NullTerminatedStringToBytes(AnimationName));
            bytes.AddRange(WriteBytesConverter.NullTerminatedStringToBytes(FaceCName));
            bytes.AddRange(WriteBytesConverter.NullTerminatedStringToBytes(FaceAnimationName));
            bytes.AddRange(WriteBytesConverter.NullTerminatedStringToBytes(Name));
            bytes.AddRange(strangeField);
            bytes.InsertRange(0, ToBytes((short)bytes.Count));
            return bytes;
        }

        new public string ToString() {
            string result = "";
            foreach (byte item in strangeField) result += item.ToString("X2") + " ";
            return result;
        }

    }
}
