﻿using System.Collections;
using System.Collections.Generic;

public class Attack
{
    public int Damage { get; private set; }
    public int Level { get; private set; }
    /// Example: P1-5B
    public string Id { get; private set; }
    public PlayerStateManager playerState;

    public Attack(string attackId, int attackLevel, int attackDamage, PlayerStateManager _playerState)
    {
        Id = attackId;
        Level = attackLevel;
        Damage = attackDamage;
        playerState = _playerState;
    }

    /// A force number
    public int GetPushback()
    {
        return AttackConstants.AttackLevelPushback[Level];
    }

    /// histun is in ms
    public int GetHitstun()
    {
        return AttackConstants.AttackLevelHitStun[Level];
    }

    /// hitstop is in ms
    public int GetHitStop()
    {
        return AttackConstants.AttackLevelHitStop[Level];
    }

    /// return 1 for P1Side, -1 for P2Side
    public int GetPushBackDirection()
    {
        if(playerState.GetIsP1Side())
        {
            return 1;
        }
        else
        {
            return -1;
        }
    }
}
