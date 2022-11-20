using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "TicState", menuName = "ScriptableObject/Scripts/Slime/States/TicState")]

public class TicState : SlimeStateUpdate
{
    public override SlimeStateUpdate Run(GameObject owner, float time)
    {
        GameObject obj = owner.GetComponent<PlayerRef>().player; //Script to check player
        owner.GetComponent<Animator>().Play("Attack"); //Acces animator and play animation


        if (action[0].Check(owner, time)) //Check state
        {
            return nextState[0];
        }
        return this;
    }
}
