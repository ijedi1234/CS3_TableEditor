using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CS3_TableEditor.CS3Tables.Header {
    public class HeaderRecordCollection {

        public const int HEADER_PREFIX_SIZE = 6;

        private HeaderPrefixRecord headerPrefix;
        private List<HeaderRecord> headers;

        public HeaderRecordCollection(List<byte> fileData) {
            headerPrefix = new HeaderPrefixRecord(fileData);
            fileData = fileData.Skip(HEADER_PREFIX_SIZE).ToList();
            headers = new List<HeaderRecord>();
            for (int i = 0; i < headerPrefix.NumHeaders; i++) {
                HeaderRecord header = new HeaderRecord(fileData);
                headers.Add(header);
                fileData = fileData.Skip(header.Size).ToList();
            }
        }

        public List<byte> ToBytes() {
            List<byte> bytes = headerPrefix.ToBytes();
            foreach (HeaderRecord header in headers) bytes.AddRange(header.ToBytes());
            return bytes;
        }

        public List<HeaderRecord> GetHeaders() { return headers; }

    }
}
