using System;
using System.Collections.Generic;
using System.Text;

namespace CS3_TableEditor.CS3Tables.Magic.StatusEffects {
    public class RegStatusEffect : StatusEffect {

        public RegStatusEffectType Id {
            get {
                short id = BitConverter.ToInt16(data.GetRange(0, 2).ToArray());
                return (RegStatusEffectType)id;
            }
            set {
                byte[] bytes = BitConverter.GetBytes((short)value);
                data[0] = bytes[0]; data[1] = bytes[1];
            }
        }

        public RegStatusEffect(List<byte> statusEffectData) : base(statusEffectData) { }

    }
}
