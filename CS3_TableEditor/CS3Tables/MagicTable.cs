using CS3_TableEditor.CS3Tables.Magic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;
using CS3_TableEditor.CS3Tables.Header;

namespace CS3_TableEditor.CS3Tables {
    public class MagicTable : CS3Table {

        public override string TABLE_NAME {
            get { return "t_magic.tbl"; }
        }

        private NameTable nameTable;

        private List<MagicRecord> magicRecords;
        private List<MagicboRecord> magicboRecords;
        private List<BtcalcRecord> btcalcRecords;

        public MagicTable(string tablesDirectory, NameTable nameTable) : base(tablesDirectory) {
            this.nameTable = nameTable;
            List<byte> fileData = FileDataAfterHeaders;
            fileData = ParseMagicRecords(Headers[0], fileData);
            fileData = ParseMagicboRecords(Headers[1], fileData);
            ParseBtcalcRecords(Headers[2], fileData);
        }

        private List<byte> ParseMagicRecords(HeaderRecord header, List<byte> fileData) {
            magicRecords = new List<MagicRecord>();
            for (int i = 0; i < header.InitialSize; i++) {
                MagicRecord magicRecord = new MagicRecord(fileData, nameTable);
                magicRecords.Add(magicRecord);
                fileData = fileData.Skip(magicRecord.Size).ToList();
            }
            header.RecordCount = magicRecords.Count;
            return fileData;
        }

        private List<byte> ParseMagicboRecords(HeaderRecord header, List<byte> fileData) {
            magicboRecords = new List<MagicboRecord>();
            for (int i = 0; i < header.InitialSize; i++) {
                MagicboRecord magicboRecord = new MagicboRecord(fileData);
                magicboRecords.Add(magicboRecord);
                magicRecords.FirstOrDefault(i => i.ID == magicboRecord.ID).MagicboRecord = magicboRecord;
                fileData = fileData.Skip(magicboRecord.Size).ToList();
            }
            header.RecordCount = magicboRecords.Count;
            return fileData;
        }

        private List<byte> ParseBtcalcRecords(HeaderRecord header, List<byte> fileData) {
            btcalcRecords = new List<BtcalcRecord>();
            for (int i = 0; i < header.InitialSize; i++) {
                BtcalcRecord btcalcRecord = new BtcalcRecord(fileData);
                btcalcRecords.Add(btcalcRecord);
                fileData = fileData.Skip(btcalcRecord.Size).ToList();
            }
            header.RecordCount = btcalcRecords.Count;
            return fileData;
        }

        public override List<byte> ToBytes() {
            List<byte> bytes = GetHeaderBytes();
            foreach (MagicRecord record in magicRecords) bytes.AddRange(record.ToBytes());
            foreach (MagicboRecord record in magicboRecords) bytes.AddRange(record.ToBytes());
            foreach (BtcalcRecord record in btcalcRecords) bytes.AddRange(record.ToBytes());
            return bytes;
        }

        public List<MagicRecord> GetCrafts(bool divine) {
            List<MagicRecord> list = magicRecords.Where(i => i.GetMagicType() == MagicType.CRAFT).ToList();
            if(divine) list = list.Where(i => 
            i.SelectionType == TargetSelectionType.DIVINE_SINGLE || i.SelectionType == TargetSelectionType.DIVINE_ALL).ToList();
            else list = list.Where(i =>
            !(i.SelectionType == TargetSelectionType.DIVINE_SINGLE || i.SelectionType == TargetSelectionType.DIVINE_ALL)).ToList();
            return list;
        }

        public List<MagicRecord> GetArts(bool divine) {
            List<MagicRecord> list = null;
            if(divine) list = magicRecords.Where(i => i.GetMagicType() == MagicType.DIVINE_ART).ToList();
            else list = magicRecords.Where(i => i.GetMagicType() == MagicType.FOOT_ART).ToList();
            return list;
        }

        public List<MagicRecord> GetSCrafts() {
            List<MagicRecord> list = magicRecords.Where(i => i.GetMagicType() == MagicType.SCRAFT).ToList();
            return list;
        }

        public List<MagicRecord> GetLinkAbilities() {
            List<MagicRecord> list = magicRecords.Where(i => i.GetMagicType() == MagicType.LINK_ABILITY).ToList();
            return list;
        }

        public List<MagicRecord> GetLinkAttacks() {
            List<MagicRecord> list = magicRecords.Where(i => i.GetMagicType() == MagicType.LINK_ATTACK).ToList();
            return list;
        }

        public List<MagicRecord> GetDivineLinkAttacks() {
            List<MagicRecord> list = magicRecords.Where(i => i.GetMagicType() == MagicType.LINK_DIVINE_ATTACK).ToList();
            return list;
        }

        public List<MagicRecord> GetBraveOrders() {
            List<MagicRecord> list = magicRecords.Where(i => i.GetMagicType() == MagicType.BRAVE_ORDER).ToList();
            return list;
        }

        public List<MagicRecord> GetMagicRecords() { return magicRecords; }

    }
}
