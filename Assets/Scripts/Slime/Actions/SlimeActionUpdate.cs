using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SlimeActionUpdate : ScriptableObject
{
    public abstract bool Check(GameObject owner, float time);
}
