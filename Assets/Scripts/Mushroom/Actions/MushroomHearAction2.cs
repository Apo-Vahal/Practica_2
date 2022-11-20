using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MushroomHearAction2", menuName = "ScriptableObject/Scripts/Mushroom/Actions/MushroomHearAction2")]

public class MushroomHearAction2 : MushroomActionUpdate
{
    public override bool Check(GameObject owner, float time)
    {
        RaycastHit[] info =
         Physics.SphereCastAll(owner.transform.position, 10, Vector3.up);

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
