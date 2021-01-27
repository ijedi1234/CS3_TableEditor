using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using CS3_TableEditor.CS3Tables.Magic.StatusEffects;

namespace CS3_TableEditor.CS3Tables.Magic {
    public class MagicboRecord : TableRecord {

        public override int Size {
            get {
                return base.Size + BraveOrderEffects.Count * StatusEffect.SIZE;
            }
        }

        public short ID { get; set; }
        public List<BraveOrderEffect> BraveOrderEffects { get; set; } = new List<BraveOrderEffect>();
        public short BraveOrderTurnLength { get; set; }

        public MagicboRecord(List<byte> fileData) : base(fileData, false) {
            ID = rbc.ReadShort(fileData, Size);
            ParseFieldEffects(fileData);
            BraveOrderTurnLength = rbc.ReadShort(fileData, Size);
        }

        private void ParseFieldEffects(List<byte> fileData) {
            for (int i = 0; i < StatusEffect.FIELD_EFFECTS_PER_ROW; i++) {
                BraveOrderEffect boEffect;
                List<byte> scopedFileData = fileData.Skip(Size).ToList();
                List<byte> reducedFileData = scopedFileData.Take(StatusEffect.SIZE).ToList();
                boEffect = new BraveOrderEffect(reducedFileData);
                BraveOrderEffects.Add(boEffect);
            }
        }

        public override List<byte> ToBytes() {
            List<byte> bytes = new List<byte>();
            bytes.AddRange(WriteBytesConverter.NumericToBytes(ID));
            foreach (BraveOrderEffect statusEffect in BraveOrderEffects) bytes.AddRange(statusEffect.ToBytes());
            bytes.AddRange(WriteBytesConverter.NumericToBytes(BraveOrderTurnLength));
            bytes.InsertRange(0, ToBytes((short)bytes.Count));
            return bytes;
        }

    }
}
