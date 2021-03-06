﻿using System.Collections;
using System.Collections.Generic;

public class AttackConstants
{
    /// AttackLevel to Pushback Force
    public static readonly int[] AttackLevelPushback = { 5, 5, 5, 5, 5 };

    /// AttackLevel to Hit / Block stun time (ms)
    public static readonly int[] AttackLevelHitStun = { 150, 250, 350, 500, 700 };

    /// AttackLevel to HitStop in (ms)
    public static readonly int[] AttackLevelHitStop = { 116, 116, 133, 150, 166 };

    /// AttackLevel to Counter Hit HitStop in (ms)
    // public static readonly int[] AttackLevelCHHitStop = { 116, 116, 133.3, 150, 166.6 };
    public static readonly int CHHitstopModifier = 2;

    /// {X, Y} Force in ForceMode
    public static readonly int[] LightLaunchForce = { 1, 15 }; // 200 500

    /// {X, Y} Force in ForceMode
    public static readonly int[] DunkForce = { 2, -15 }; // 200 500
}
