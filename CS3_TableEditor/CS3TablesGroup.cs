using CS3_TableEditor.CS3Tables;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Text;
using System.Linq;

namespace CS3_TableEditor {
    public class CS3TablesGroup {

        private string tablesDirectory;

        public NameTable Name { get; }
        public StatusTable Status { get; }
        public MagicTable Magic { get; }

        public CS3TablesGroup() {
            tablesDirectory = ConfigurationManager.AppSettings["CS3TablesLocation"] + Path.DirectorySeparatorChar;
            Name = new NameTable(tablesDirectory);
            Status = new StatusTable(tablesDirectory, Name);
            //var nameR = Name.GetRecords().Where(i => i.OwnerID >= 0).OrderBy(i => i.OwnerID).ToList();
            //var statusR = Status.GetStatusPRecords().ToList();
            Magic = new MagicTable(tablesDirectory, Name);
        }

        public void SaveAll() {
            byte[] fileAsBytes = Magic.ToBytes().ToArray();
            string fileLocation = tablesDirectory + Path.DirectorySeparatorChar + Magic.TABLE_NAME;
            if (File.Exists(fileLocation)) File.Delete(fileLocation);
            File.WriteAllBytes(fileLocation, fileAsBytes);
        }

    }
}
