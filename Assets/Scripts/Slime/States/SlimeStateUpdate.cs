using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SlimeStateUpdate : ScriptableObject
{
    public SlimeActionUpdate[] action;
    public SlimeStateUpdate[] nextState;


    public abstract SlimeStateUpdate Run(GameObject owner, float time);
}
