using System;
using System.Collections.Generic;
using System.Text;

namespace CS3_TableEditor.CS3Tables.Magic.StatusEffects {
    public enum RegStatusEffectType {
        NULL = 0x0,
        PHYSICAL_ATTACK = 0x1,
        MAGICAL_ATTACK = 0x2,
        THIRD_ATTACK = 0x3, //Don't know what this is
        FOURTH_ATTACK = 0x4, //Don't know what this is
        HP_DAMAGE = 0x5,
        HP_QUANTITY_SETTER = 0x6,
        // 0x7 to 0x9 are valid but do nothing
        POISON = 0xa,
        SEAL = 0xb,
        MUTE = 0xc,
        BLIND = 0xd,
        SLEEP = 0xe,
        BURN = 0xf,
        FREEZE = 0x10,
        PETRIFY = 0x11,
        FAINT = 0x12,
        CONFUSE = 0x13,
        DEATHBLOW = 0x14,
        NIGHTMARE = 0x15,
        DELAY = 0x16,
        VANISH = 0x17,
        LINK_BREAK = 0x18,
        IMPEDE = 0x19,
        BALANCE_DOWN = 0x1a,
        // 0x1b is valid but does nothing
        WEAKENED = 0x1c,
        RANDOM_EFFECT = 0x1d,
        STR_DEBUFF = 0x1e,
        DEF_DEBUFF = 0x1f,
        ATS_DEBUFF = 0x20,
        ADF_DEBUFF = 0x21,
        SPD_DEBUFF = 0x22,
        MOV_DEBUFF = 0x23,
        // 0x24 is invalid
        RND_DEBUFF = 0x25,
        // 0x26 to 0x27 are valid but do nothing
        SCORCH = 0x28, // Pink fire
        ALL_DEBUFF = 0x29,
        ALL_CANCEL_QUIET = 0x2a,
        ALL_CANCEL = 0x2b,
        // 0x2c to 0x31 are valid but do nothing
        POISON_CURE = 0x32,
        SEAL_CURE = 0x33,
        MUTE_CURE = 0x34,
        BLIND_CURE = 0x35,
        SLEEP_CURE = 0x36,
        BURN_CURE = 0x37,
        FREEZE_CURE = 0x38,
        PETRIFY_CURE = 0x39,
        FAINT_CURE = 0x3a,
        CONFUSE_CURE = 0x3b,
        NIGHTMARE_CURE = 0x3c,
        // 0x3d to 0x40 are valid but do nothing
        STR_BUFF = 0x41,
        DEF_BUFF = 0x42,
        ATS_BUFF = 0x43,
        ADF_BUFF = 0x44,
        SPD_BUFF = 0x45,
        MOV_BUFF = 0x46,
        INSIGHT = 0x47,
        // 0x48 is valid but does nothing
        ACCELERATE = 0x49,
        // 0x41 is valid but does nothing
        ALL_CURE = 0x4b,
        STAT_DOWN_CURE = 0x4c,
        AILMENTS_STAT_DOWN_CURE = 0x4d,
        ALL_BUFF = 0x4e,
        // 0x4f seems to have something to do with hp recovery.
        // 0x50 to 0x54 are valid but do nothing
        BRANDISH_LAURA = 0x55,
        BRANDISH_KURT = 0x56,
        EXCHANGE = 0x57,
        HIDE = 0x58,
        // 0x59 is valid but does nothing
        CHARM = 0x5a,
        // 0x5b to 0x5c are valid but do nothing
        ENHANCE = 0x5d,
        // 0x5e to 0x63 are valid but do nothing
        HP_QUANTITY_RESTORE = 0x64,
        EP_QUANTITY_RESTORE = 0x65,
        CP_QUANTITY_RESTORE = 0x66,
        HP_PERCENT_RESTORE = 0x67,
        EP_PERCENT_RESTORE = 0x68,
        CP_PERCENT_RESTORE = 0x69,
        HP_QUANTITY_RESTORE_AND_REVIVE = 0x6a,
        HP_PERCENT_RESTORE_AND_REVIVE = 0x6b,
        HP_TIERED_RESTORE = 0x6c,
        HP_ABSORB1 = 0x6d,
        EP_ABSORB = 0x6e,
        CP_ABSORB = 0x6f,
        HP_ABSORB2 = 0x70,
        HP_PULSE_RESTORE = 0x71,
        // 0x72 is valid but does nothing
        CP_PULSE_RESTORE = 0x73,
        HP_TIERED_RESTORE_AND_REVIVE = 0x74,
        HP_PERCENT_RESTORE_NOMSG = 0x75,
        HP_EP_QUANTITY_RESTORE = 0x76,
        HP_CP_QUANTITY_RESTORE = 0x77,
        EP_CP_QUANTITY_RESTORE = 0x78,
        HP_EP_CP_QUANTITY_RESTORE = 0x79,
        NEAR_DEATH_HALF_CHANCE = 0x7a,
        HP_PERCENT_RESTORE_ALL_CURE = 0x7b,
        HP_PERCENT_CP_QUANTITY_RESTORE = 0x7c,
        BP_QUANTITY_RESTORE = 0x7d,
        // 0x7e to 0x85 - unknown are valid but do nothing
        // unknown - 0x95 to 0x96 - unknown are valid but do nothing
        // unknown - 0xa4 to 0xa9 are valid but do nothing
        PERFECT_GUARD = 0xaa,
        CRAFT_GUARD = 0xab,
        PHYSICAL_REFLECT = 0xac,
        MAGICAL_REFLECT = 0xad,
        ABSOLUTE_REFLECT = 0xae,
        // 0xaf to - unknown are valid but do nothing
        // b4 b5 do nothing
        // unknown - 0xc8 to 0xc9 are valid but do nothing
        DIVINE_EFFECT = 0xc0,
        STEALTH = 0xca,
        ANALYZE = 0xcb,
        // 0xcc is valid but does nothing
        HP_EP_CP_FULL_RESTORE_AND_REVIVE = 0xcd,
        CRITICAL_RATE_PERCENT_UP = 0xce,
        DROP_RATE_PERCENT_UP = 0xcf,
        CP_RATE_PERCENT_UP = 0xd0,
        AUTO_CP_RATE_PERCENT_UP = 0xd1,
        ITEM_HP_PERCENT_RESTORE_AND_REVIVE = 0xd2,
        // 0xd3 to 0xd4 are valid but do nothing
        ITEM_ARTS_TIME_CUT = 0xd5,
        ITEM_ARTS_COST_CUT = 0xd6,
        // 0xd7 is valid but removes the visual effect of brave orders
        REMOVE_FROM_AT_BAR = 0xd8,
        // 0xd9 to 0xda are valid but do nothing
        HP_PULSE_RESTORE_SCRAFT = 0xdb,
        // 0xdc to 0xdd are valid but do nothing
        RANDOM_STATUS_EFFECT = 0xde,
        CHRONO_BURST = 0xdf,
        INSTANT_FLEE = 0xe0,
        // 0xe1 is valid but does nothing
        UNLEASH = 0xe2,
        // 0xe3 to 0xe4 - unknown are valid but do nothing
        SUCTION = 0x1f5
    }
}
