using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[CreateAssetMenu(fileName = "SlimeIdleState", menuName = "ScriptableObject/Scripts/Slime/States/SlimeIdleState")]
public class SlimeIdleState : SlimeStateUpdate
{
    public override SlimeStateUpdate Run(GameObject owner, float time)
    {
        GameObject obj = owner.GetComponent<PlayerRef>().player; //Script to check player
        owner.GetComponent<Animator>().Play("Attack"); //Acces animator and play animation
        owner.GetComponent<NavMeshAgent>().SetDestination(obj.transform.position);

        if (action[0].Check(owner, time)) //Check state
        {
            return nextState[0];
        }
        return this;
    }
}
