using CS3_TableEditor.CS3Tables.Header;
using CS3_TableEditor.CS3Tables.Name;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CS3_TableEditor.CS3Tables {
    public class NameTable : CS3Table {

        public override string TABLE_NAME {
            get { return "t_name.tbl"; }
        }

        public Dictionary<short, string> PLAYABLE_OWNER_ID_STRING_PAIRS {
            get {
                short[] partyMemberIDs = (short[])Enum.GetValues(typeof(OwnerType));
                Dictionary<short, string> map = nameTableDataRecords
                    .Where(i => partyMemberIDs.Contains(i.OwnerID))
                    .ToDictionary(i => i.OwnerID, i => i.OverworldName);
                return map;
            }
        }

        private List<NameTableDataRecord> nameTableDataRecords;

        public NameTable(string tablesDirectory) : base(tablesDirectory) {
            List<byte> fileData = FileDataAfterHeaders;
            ParseNameTableDataRecords(Headers[0], fileData);
        }

        private List<byte> ParseNameTableDataRecords(HeaderRecord header, List<byte> fileData) {
            nameTableDataRecords = new List<NameTableDataRecord>();
            for (int i = 0; i < header.InitialSize; i++) {
                NameTableDataRecord nameTableDataRecord = new NameTableDataRecord(fileData);
                nameTableDataRecords.Add(nameTableDataRecord);
                fileData = fileData.Skip(nameTableDataRecord.Size).ToList();
            }
            header.RecordCount = nameTableDataRecords.Count;
            return fileData;
        }

        public override List<byte> ToBytes() {
            List<byte> bytes = GetHeaderBytes();
            return bytes;
        }

        public List<NameTableDataRecord> GetRecords() { return nameTableDataRecords; }

    }
}
