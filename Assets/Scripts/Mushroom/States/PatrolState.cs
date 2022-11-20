using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PatrolState", menuName = "ScriptableObject/Scripts/Mushroom/States/PatrolState")]

public class PatrolState : MushroomStateUpdate
{
    public Vector3[] WayPoints; //Array for patrol locations
    private int nextWayPoint;



    public override MushroomStateUpdate Run(GameObject owner, float time)
    {
        GameObject obj = owner.GetComponent<PlayerRef>().player;
        owner.GetComponent<Animator>().Play("Jump"); //Acces animator and play animation
        owner.GetComponent<UnityEngine.AI.NavMeshAgent>().SetDestination(WayPoints[nextWayPoint]);
        float distance = Vector3.Distance(owner.transform.position, WayPoints[nextWayPoint]);
        if (distance < 3.0f)
        {
            nextWayPoint = (nextWayPoint + 1) % WayPoints.Length;


        }
        if (!action[0].Check(owner, time)) //Check state
        {
            return nextState[0];

        }
        return this;
    }
}

