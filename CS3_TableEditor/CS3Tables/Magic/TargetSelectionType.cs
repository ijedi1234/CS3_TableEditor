using System;
using System.Collections.Generic;
using System.Text;

namespace CS3_TableEditor.CS3Tables.Magic {
    public enum TargetSelectionType {
        NULL = 0,
        ONE_NO_MOVEMENT = 0xa,
        ONE_MOVEMENT = 0xb,
        ONE_CIRCLE_NO_MOVEMENT = 0xc,
        ONE_CIRCLE_SET = 0xd,
        FREE_CIRCLE_TARGET_REQ = 0xe,
        FREE_CIRCLE_NO_TRGT_REQ_LINK_CIRCLE = 0xf, //valid selection circle default is the character's link circle
        FREE_CIRCLE_NO_TRGT_REQ_MOV_CIRCLE = 0x10, //valid selection circle default is the character's mov circle
        ONE_CIRCLE_CASTER_LOCK = 0x11,
        FREE_LINE_RESIZABLE = 0x12,
        ONE_LINE_FIXED = 0x13,
        FREE_LINE_FIXED = 0x14,
        ALL = 0x1f,
        ALL_ALTERNATE = 0x20,
        DIVINE_SINGLE = 0x32,
        DIVINE_ALL = 0x33
    }
}
