using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MushroomHearAction", menuName = "ScriptableObject/Scripts/Mushroom/Actions/MushroomHearAction")]
public class MushroomHearAction : MushroomActionUpdate
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
