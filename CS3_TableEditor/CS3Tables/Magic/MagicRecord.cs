using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Data;
using CS3_TableEditor.CS3Tables.Magic.StatusEffects;

namespace CS3_TableEditor.CS3Tables.Magic {
    public class MagicRecord : TableRecord {

        public override int Size {
            get {
                return base.Size + rbc.GetByteLengthOfString(AnimationName) + rbc.GetByteLengthOfString(Name) +
                    rbc.GetByteLengthOfString(Description) + StatusEffects.Count * StatusEffect.SIZE
                    + rbc.GetByteLengthOfString(TargetingType);
            }
        }

        public short ID { get; set; }
        public OwnerType OwnerID { get; set; }
        public string TargetingType { get; set; } = "";
        public ActionIntentType ActionIntent { get; set; }
        public ElementType Element { get; set; }
        public bool ForAltAttackMode {
            get { return forAltAttackMode == 1; }
            set { if (value == false) forAltAttackMode = 0; else forAltAttackMode = 1; }
        }
        public TargetSelectionType SelectionType { get; set; }
        public float MaxRangeRadius { get; set; }
        public byte SelectionRadius { get; set; }
        public List<RegStatusEffect> StatusEffects { get; set; } = new List<RegStatusEffect>();
        public byte CastTime { get; set; }
        public byte Delay { get; set; }
        public short Cost { get; set; }
        public byte Unbalance { get; set; }
        public BreakGrade BreakDamage { get; set; }
        public byte LevelUnlocked { get; set; }
        public short MenuSortOrder { get; set; }
        public string AnimationName { get; set; } = "";
        public string Name { get; set; } = "";
        public string Description { get {
                if (Description1stLine == "") return Description2ndLine;
                else return Description1stLine + "\n  " + Description2ndLine; 
            } }
        public string Description1stLine { get; set; } = "";
        public string Description2ndLine { get; set; } = "";

        public MagicboRecord MagicboRecord { get; set; }

        private MagicType type;
        private byte forAltAttackMode;
        private int unusedField2;
        private SignatureType signatureType;

        public MagicRecord(List<byte> fileData) : base(fileData, false) {
            ID = rbc.ReadShort(fileData, Size);
            OwnerID = (OwnerType)rbc.ReadShort(fileData, Size);
            TargetingType = rbc.GetNullTerminatedString(fileData, Size);
            type = (MagicType)rbc.ReadByte(fileData, Size);
            ActionIntent = (ActionIntentType)rbc.ReadByte(fileData, Size);
            Element = (ElementType)rbc.ReadByte(fileData, Size);
            forAltAttackMode = rbc.ReadByte(fileData, Size);
            SelectionType = (TargetSelectionType)rbc.ReadByte(fileData, Size);
            MaxRangeRadius = rbc.ReadFloat(fileData, Size);
            SelectionRadius = rbc.ReadByte(fileData, Size);
            unusedField2 = rbc.ReadInt(fileData, Size);
            signatureType = (SignatureType)rbc.ReadLong(fileData, Size);
            ParseFieldEffects(fileData);
            CastTime = rbc.ReadByte(fileData, Size);
            Delay = rbc.ReadByte(fileData, Size);
            Cost = rbc.ReadShort(fileData, Size);
            Unbalance = rbc.ReadByte(fileData, Size);
            BreakDamage = (BreakGrade)rbc.ReadShort(fileData, Size);
            LevelUnlocked = rbc.ReadByte(fileData, Size);
            MenuSortOrder = rbc.ReadShort(fileData, Size);
            AnimationName = rbc.GetNullTerminatedString(fileData, Size);
            Name = rbc.GetNullTerminatedString(fileData, Size);
            string description = rbc.GetNullTerminatedString(fileData, Size);
            Description1stLine = description.Substring(0, Math.Max(description.IndexOf('\n'), 0));
            Description2ndLine = description.Substring(Math.Max(description.IndexOf('\n'), 0));
            Description2ndLine = Description2ndLine.Replace("\n  ", "");
        }

        private void ParseFieldEffects(List<byte> fileData) {
            for (int i = 0; i < StatusEffect.FIELD_EFFECTS_PER_ROW; i++) {
                RegStatusEffect fieldEffect;
                List<byte> scopedFileData = fileData.Skip(Size).ToList();
                List<byte> reducedFileData = scopedFileData.Take(StatusEffect.SIZE).ToList();
                fieldEffect = new RegStatusEffect(reducedFileData);
                StatusEffects.Add(fieldEffect);
            }
        }

        public override List<byte> ToBytes() {
            List<byte> bytes = new List<byte>();
            bytes.AddRange(WriteBytesConverter.NumericToBytes(ID));
            bytes.AddRange(WriteBytesConverter.NumericToBytes((short)OwnerID));
            bytes.AddRange(WriteBytesConverter.NullTerminatedStringToBytes(TargetingType));
            bytes.Add((byte)type); bytes.Add((byte)ActionIntent); bytes.Add((byte)Element);
            bytes.Add(forAltAttackMode); bytes.Add((byte)SelectionType);
            bytes.AddRange(WriteBytesConverter.NumericToBytes(MaxRangeRadius)); bytes.Add(SelectionRadius);
            bytes.AddRange(WriteBytesConverter.NumericToBytes(unusedField2));
            bytes.AddRange(WriteBytesConverter.NumericToBytes((long)signatureType));
            foreach (RegStatusEffect statusEffect in StatusEffects) bytes.AddRange(statusEffect.ToBytes());
            bytes.Add(CastTime); bytes.Add(Delay); bytes.AddRange(WriteBytesConverter.NumericToBytes(Cost));
            bytes.Add(Unbalance); bytes.AddRange(WriteBytesConverter.NumericToBytes((short)BreakDamage));
            bytes.Add(LevelUnlocked); bytes.AddRange(WriteBytesConverter.NumericToBytes(MenuSortOrder));
            bytes.AddRange(WriteBytesConverter.NullTerminatedStringToBytes(AnimationName));
            bytes.AddRange(WriteBytesConverter.NullTerminatedStringToBytes(Name));
            bytes.AddRange(WriteBytesConverter.NullTerminatedStringToBytes(Description));
            bytes.InsertRange(0, ToBytes((short)bytes.Count));
            return bytes;
        }

        public MagicType GetMagicType() { return type; }
        public bool IsForAltAttackMode() { return forAltAttackMode == 1; }

    }
}

/* Some targeting flag info
 * E - Targets Enemies
P - Targets Players
M - Caster can be targeted
R - KO'd characters can be targeted
O - Caster can attack within their MOV circle without moving
C - unknown, seems to have something to do with healing
I - Immobile (seems to do nothing)
Q - Art (seems to do nothing)
Z - Game will not generate description first line
N - Forces attack to be a one type of targeting
*/

/*
 * -E: Target enemies
-P: Target allies
-M: Target user
-B: In battle use
-C: Out of battle use
-R: Revive/Can target dead ally
-I: Can't miss
-Q: Quartz
-N: Normal attack (Move if target is out of range)
-D: Move into max range if out of range, stay still otherwise
 */
