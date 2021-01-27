using CS3_TableEditor.CS3Tables.Header;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CS3_TableEditor.CS3Tables {
    public abstract class CS3Table {

        public abstract string TABLE_NAME {
            get;
        }

        public List<HeaderRecord> Headers { get { return headerCollection.GetHeaders(); } }
        public List<byte> FileDataAfterHeaders { get; }

        private string tableLocation;
        private List<byte> fileData;
        private HeaderRecordCollection headerCollection;

        public CS3Table(string tablesDirectory) {
            tableLocation = tablesDirectory + Path.DirectorySeparatorChar + TABLE_NAME;
            fileData = File.ReadAllBytes(tableLocation).ToList();
            headerCollection = new HeaderRecordCollection(fileData);
            int fullHeaderSize = headerCollection.ToBytes().Count;
            FileDataAfterHeaders = fileData.Skip(fullHeaderSize).ToList();
        }

        public void Save() {
            byte[] fileAsBytes = ToBytes().ToArray();
            if (File.Exists(tableLocation)) File.Delete(tableLocation);
            File.WriteAllBytes(tableLocation, fileAsBytes);
        }

        public List<byte> GetHeaderBytes() {
            return headerCollection.ToBytes();
        }

        public abstract List<byte> ToBytes();

    }
}
