using CS3_TableEditor.CS3Tables.Header;
using CS3_TableEditor.CS3Tables.Status;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CS3_TableEditor.CS3Tables {
    public class StatusTable : CS3Table {

        public override string TABLE_NAME {
            get { return "t_status.tbl"; }
        }

        private List<StatusPRecord> statusPRecords;
        private List<StatusReviseRecord> statusReviseRecords;
        private List<CharReviseRecord> charReviseRecords;
        private List<GameDifficultyRecord> gameDifficultyRecords;
        private List<FieldAttackDataRecord> fieldAttackDataRecords;

        public StatusTable(string tablesDirectory) : base(tablesDirectory) {
            List<byte> fileData = FileDataAfterHeaders;
            fileData = ParseStatusPRecords(Headers[0], fileData);
            fileData = ParseStatusReviseRecords(Headers[1], fileData);
            fileData = ParseCharReviseRecords(Headers[2], fileData);
            fileData = ParseGameDifficultyRecords(Headers[3], fileData);
            fileData = ParseFieldAttackDataRecords(Headers[4], fileData);
        }

        private List<byte> ParseStatusPRecords(HeaderRecord header, List<byte> fileData) {
            statusPRecords = new List<StatusPRecord>();
            for (int i = 0; i < header.InitialSize; i++) {
                StatusPRecord statusPRecord = new StatusPRecord(fileData);
                statusPRecords.Add(statusPRecord);
                fileData = fileData.Skip(statusPRecord.Size).ToList();
            }
            header.RecordCount = statusPRecords.Count;
            return fileData;
        }

        private List<byte> ParseStatusReviseRecords(HeaderRecord header, List<byte> fileData) {
            statusReviseRecords = new List<StatusReviseRecord>();
            for (int i = 0; i < header.InitialSize; i++) {
                StatusReviseRecord statusReviseRecord = new StatusReviseRecord(fileData);
                statusReviseRecords.Add(statusReviseRecord);
                fileData = fileData.Skip(statusReviseRecord.Size).ToList();
            }
            header.RecordCount = statusReviseRecords.Count;
            return fileData;
        }

        private List<byte> ParseCharReviseRecords(HeaderRecord header, List<byte> fileData) {
            charReviseRecords = new List<CharReviseRecord>();
            for (int i = 0; i < header.InitialSize; i++) {
                CharReviseRecord charReviseRecord = new CharReviseRecord(fileData);
                charReviseRecords.Add(charReviseRecord);
                fileData = fileData.Skip(charReviseRecord.Size).ToList();
            }
            header.RecordCount = charReviseRecords.Count;
            return fileData;
        }

        private List<byte> ParseGameDifficultyRecords(HeaderRecord header, List<byte> fileData) {
            gameDifficultyRecords = new List<GameDifficultyRecord>();
            for (int i = 0; i < header.InitialSize; i++) {
                GameDifficultyRecord gameDifficultyRecord = new GameDifficultyRecord(fileData);
                gameDifficultyRecords.Add(gameDifficultyRecord);
                fileData = fileData.Skip(gameDifficultyRecord.Size).ToList();
            }
            header.RecordCount = gameDifficultyRecords.Count;
            return fileData;
        }

        private List<byte> ParseFieldAttackDataRecords(HeaderRecord header, List<byte> fileData) {
            fieldAttackDataRecords = new List<FieldAttackDataRecord>();
            for (int i = 0; i < header.InitialSize; i++) {
                FieldAttackDataRecord fieldAttackDataRecord = new FieldAttackDataRecord(fileData);
                fieldAttackDataRecords.Add(fieldAttackDataRecord);
                fileData = fileData.Skip(fieldAttackDataRecord.Size).ToList();
            }
            header.RecordCount = fieldAttackDataRecords.Count;
            return fileData;
        }

        public override List<byte> ToBytes() {
            List<byte> bytes = GetHeaderBytes();
            return bytes;
        }

    }
}
