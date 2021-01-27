using System;
using System.Collections.Generic;
using System.Text;

namespace CS3_TableEditor.CS3Tables.Magic.StatusEffects {
    public enum BraveOrderEffectType {
        NULL = 0x0,
        DAMAGE_UP = 0x12c,
        DAMAGE_REDUCTION = 0x12f,
        DELAY_REDUCTION = 0x130,
        CASTING_TIME = 0x131,
        BREAK_DAMAGE_UP = 0x132,
        CRITICAL_RATE_UP = 0x133,
        EVADE_RATE_UP = 0x134,
        ABSORB_MAGIC_CHANCE = 0x138,
        ABSOLUTE_REFLECT = 0x139,
        EP_COST_REDUCTION = 0x13a
    }
}
