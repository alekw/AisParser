﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AisParser
{
    public enum NavigationalAidType
    {
        NotSpecified,
        ReferencePoint,
        Racon,
        FixedStuctureOffShore,
        Spare,
        LightWithoutSectors,
        LightWithSectors,
        LeadingLightFront,
        LeadingLigthRear,
        BeaconCardinalN,
        BeaconCardinalE,
        BeaconCardinalS,
        BeaconCardinalW,
        BeaconPortHand,
        BeaconStarboardHand,
        BeaconPreferredChannelPortHand,
        BeaconPreferredChannelStarboardHand,
        BeaconIsolatedDanger,
        BeaconSafeWater,
        BeaconSpecialMark,
        CardinalMarkN,
        CardinalMarkE,
        CardinalMarkS,
        CardinalMarkW,
        PortHandMark,
        StarboardHandMark,
        PreferredChannelPortHand,
        PreferredChannelStarboardHand,
        IsolatedDanger,
        SafeWater,
        SpecialMark,
        LightVessel
    }
}
