using System;
using System.Collections.Generic;
using System.Text;

namespace CS3_TableEditor.CS3Tables.Magic.StatusEffects {
    public abstract class StatusEffect {

        public const int SIZE = 14;
        public const int FIELD_EFFECTS_PER_ROW = 5;
        private const int ARG1_BEGIN_BYTE = 2;
        private const int ARG2_BEGIN_BYTE = 6;
        private const int ARG3_BEGIN_BYTE = 10;

        protected ReadBytesConverter rbc; //Using a separate version since size is accounted for.
        protected List<byte> data;

        private int uniqueID;

        public abstract void SetID(short value);
        public abstract short GetID();
        public abstract string GetIDString();

        public int UniqueID {
            get { return uniqueID; }
        }

        public int Argument1 {
            get {
                return BitConverter.ToInt32(data.GetRange(2, 4).ToArray());
            }
            set {
                byte[] bytes = BitConverter.GetBytes(value);
                for(int i = 0; i < 4; i++)
                    data[i + ARG1_BEGIN_BYTE] = bytes[i];
            }
        }

        public int Argument2 {
            get {
                return BitConverter.ToInt32(data.GetRange(6, 4).ToArray());
            }
            set {
                byte[] bytes = BitConverter.GetBytes(value);
                for (int i = 0; i < 4; i++)
                    data[i + ARG2_BEGIN_BYTE] = bytes[i];
            }
        }
        public int Argument3 {
            get {
                return BitConverter.ToInt32(data.GetRange(10, 4).ToArray());
            }
            set {
                byte[] bytes = BitConverter.GetBytes(value);
                for (int i = 0; i < 4; i++)
                    data[i + ARG3_BEGIN_BYTE] = bytes[i];
            }
        }

        public StatusEffect() {
            rbc = new ReadBytesConverter();
            data = new List<byte>();
            uniqueID = new Random().Next();
            for (int i = 0; i < SIZE; i++) data.Add(0);
        }

        public StatusEffect(List<byte> statusEffectData) {
            rbc = new ReadBytesConverter();
            data = statusEffectData;
            uniqueID = new Random().Next();
        }

        public List<byte> ToBytes() {
            List<byte> bytes = new List<byte>();
            bytes.AddRange(data);
            return bytes;
        }

    }
}
