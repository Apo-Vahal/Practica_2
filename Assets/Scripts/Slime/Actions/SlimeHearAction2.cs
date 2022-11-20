using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SlimeHearAction2", menuName = "ScriptableObject/Scripts/Slime/Actions/SlimeHearAction2")]

public class SlimeHearAction2 : SlimeActionUpdate
{
    public override bool Check(GameObject owner, float time)
    {
        RaycastHit[] info =
         Physics.SphereCastAll(owner.transform.position, 30, Vector3.up); //Distance for the AI to detectd player to start states

        foreach (RaycastHit col in info)
        {
            if (col.collider.gameObject.GetComponent<PlayerController>())
            {
                return true;
            }


        }
        return false;
    }
}
