using CS3_TableEditor.CS3Tables;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Text;

namespace CS3_TableEditor {
    public class CS3TablesGroup {

        private string tablesDirectory;

        private MagicTable magic;
        private StatusTable status;

        public CS3TablesGroup() {
            tablesDirectory = ConfigurationManager.AppSettings["CS3TablesLocation"] + Path.DirectorySeparatorChar;
            status = new StatusTable(tablesDirectory);
            magic = new MagicTable(tablesDirectory);
        }

        public void SaveAll() {
            byte[] fileAsBytes = magic.ToBytes().ToArray();
            string fileLocation = tablesDirectory + Path.DirectorySeparatorChar + magic.TABLE_NAME;
            if (File.Exists(fileLocation)) File.Delete(fileLocation);
            File.WriteAllBytes(fileLocation, fileAsBytes);
        }

        public MagicTable GetMagicTable() { return magic; }

    }
}
