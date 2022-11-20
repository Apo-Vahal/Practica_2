using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MushroomActionUpdate : ScriptableObject
{
    public abstract bool Check(GameObject owner, float time);
}
