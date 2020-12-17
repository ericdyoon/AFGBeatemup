﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Interface for battle actions a character can perform
/// </summary>
public interface IBattleInputActions
{
    // Universal Movement
    void Dash();
    void AirDash(bool direction);
    void BackDash();
    void Run();
    void Skid();
    void Walk();
    void Jump();

    // Universal Actions
    void Throw(bool direction);


    // Normals
    void N5(Button button);

    // Command Normals

    // Specials
    void S236(Button button);
}