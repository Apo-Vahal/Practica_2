using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MushroomStateUpdate : ScriptableObject
{
    public MushroomActionUpdate[] action;
    public MushroomStateUpdate[] nextState;


    public abstract MushroomStateUpdate Run(GameObject owner, float time);
}
