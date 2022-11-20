using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[CreateAssetMenu(fileName = "MushroomIdleState", menuName = "ScriptableObject/Scripts/Mushroom/States/MushroomIdleState")]
public class MushroomIdleState : MushroomStateUpdate
{
    public override MushroomStateUpdate Run(GameObject owner, float time)
    {
        owner.GetComponent<Animation>().Play("Idle"); //Acces animator and play animation
        GameObject obj = owner.GetComponent<PlayerRef>().player; //Acceder a la referencia del jugador
        owner.GetComponent<NavMeshAgent>().SetDestination(owner.transform.position); //Posición

        if (action[0].Check(owner, time)) //Check state
        {
            return nextState[0];
        }
        return this;
    }
}
