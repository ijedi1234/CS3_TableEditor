using CS3_TableEditor.CS3Tables;
using CS3_TableEditor.CS3Tables.Magic;
using CS3_TableEditor.ListViewItems.Magic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS3_TableEditor.Forms {
    public partial class MagicTableForm : Form {

        private MagicTable magicTable;

        public MagicTableForm(MagicTable magicTable) {
            InitializeComponent();
            this.magicTable = magicTable;
        }

        private void MagicCraftsBtn_Click(object sender, EventArgs e) {
            ListViewItemCraft.SetupHeaders(TMagicList);
            List<MagicRecord> magicTableRecords = magicTable.GetCrafts(false);
            foreach (MagicRecord record in magicTableRecords) {
                ListViewItem rowItem = new ListViewItemCraft(record);
                TMagicList.Items.Add(rowItem);
            }
        }

        private void MagicDivineCraftsBtn_Click(object sender, EventArgs e) {
            ListViewItemDivineCraft.SetupHeaders(TMagicList);
            List<MagicRecord> magicTableRecords = magicTable.GetCrafts(true);
            foreach (MagicRecord record in magicTableRecords) {
                ListViewItem rowItem = new ListViewItemDivineCraft(record);
                TMagicList.Items.Add(rowItem);
            }
        }

        private void MagicArtsBtn_Click(object sender, EventArgs e) {
            ListViewItemArt.SetupHeaders(TMagicList);
            List<MagicRecord> magicTableRecords = magicTable.GetArts(false);
            foreach (MagicRecord record in magicTableRecords) {
                ListViewItem rowItem = new ListViewItemArt(record);
                TMagicList.Items.Add(rowItem);
            }
        }

        private void MagicDivineArtsBtn_Click(object sender, EventArgs e) {
            ListViewItemDivineArt.SetupHeaders(TMagicList);
            List<MagicRecord> magicTableRecords = magicTable.GetArts(true);
            foreach (MagicRecord record in magicTableRecords) {
                ListViewItem rowItem = new ListViewItemDivineArt(record);
                TMagicList.Items.Add(rowItem);
            }
        }

        private void MagicSCraftBtn_Click(object sender, EventArgs e) {
            ListViewItemSCraft.SetupHeaders(TMagicList);
            List<MagicRecord> magicTableRecords = magicTable.GetSCrafts();
            foreach (MagicRecord record in magicTableRecords) {
                ListViewItem rowItem = new ListViewItemSCraft(record);
                TMagicList.Items.Add(rowItem);
            }
        }

        private void MagicLinkAbilitiesBtn_Click(object sender, EventArgs e) {
            ListViewItemLinkAbility.SetupHeaders(TMagicList);
            List<MagicRecord> magicTableRecords = magicTable.GetLinkAbilities();
            foreach (MagicRecord record in magicTableRecords) {
                ListViewItem rowItem = new ListViewItemLinkAbility(record);
                TMagicList.Items.Add(rowItem);
            }
        }

        private void MagicLinkAttacksBtn_Click(object sender, EventArgs e) {
            ListViewItemLinkAttack.SetupHeaders(TMagicList);
            List<MagicRecord> magicTableRecords = magicTable.GetLinkAttacks();
            foreach (MagicRecord record in magicTableRecords) {
                ListViewItem rowItem = new ListViewItemLinkAttack(record);
                TMagicList.Items.Add(rowItem);
            }
        }
        private void MagicDivineLinkAttacksBtn_Click(object sender, EventArgs e) {
            ListViewItemDivineLinkAttack.SetupHeaders(TMagicList);
            List<MagicRecord> magicTableRecords = magicTable.GetDivineLinkAttacks();
            foreach (MagicRecord record in magicTableRecords) {
                ListViewItem rowItem = new ListViewItemDivineLinkAttack(record);
                TMagicList.Items.Add(rowItem);
            }
        }
        private void MagicBraveOrdersBtn_Click(object sender, EventArgs e) {
            ListViewItemBraveOrder.SetupHeaders(TMagicList);
            List<MagicRecord> magicTableRecords = magicTable.GetBraveOrders();
            foreach (MagicRecord record in magicTableRecords) {
                ListViewItem rowItem = new ListViewItemBraveOrder(record);
                TMagicList.Items.Add(rowItem);
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e) {
            magicTable.Save();
        }

        private void TMagicBox_Enter(object sender, EventArgs e) {

        }

        private void GeneralInfo_Click(object sender, EventArgs e) {
            ListViewItemMagic selectedItem = null;
            foreach (ListViewItemMagic item in TMagicList.Items) {
                if (item.Selected) { selectedItem = item; break; }
            }
            if (selectedItem == null) return;
            MagicRecord magicRecord = magicTable.GetMagicRecords().First(i => selectedItem.CompareKey(i.ID, i.ForAltAttackMode));
            MagicRecordForm form = new MagicRecordForm(magicRecord);
            form.ShowDialog();
            selectedItem.UpdateListViewItem(magicRecord);
        }

        private void OpenStatusEffectsBtn_Click(object sender, EventArgs e) {
            ListViewItemMagic selectedItem = null;
            foreach (ListViewItemMagic item in TMagicList.Items) {
                if (item.Selected) { selectedItem = item; break; }
            }
            if (selectedItem == null) return;
            MagicRecord magicRecord = magicTable.GetMagicRecords().First(i => selectedItem.CompareKey(i.ID, i.ForAltAttackMode));
            MagicStatusEffectsForm form = new MagicStatusEffectsForm(magicRecord);
            form.ShowDialog();
            selectedItem.UpdateListViewItem(magicRecord);
        }
    }

}
