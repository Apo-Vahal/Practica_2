using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomStateMachine : MonoBehaviour
{
    public MushroomStateUpdate startingState;
    private MushroomStateUpdate currentState;
    void Start()
    {
        currentState = startingState;
    }

    void Update()
    {
        RunStateMachine();
    }

    private void RunStateMachine()
    {
        if (currentState == null)
        {
            return;
        }

        MushroomStateUpdate nextState = currentState.Run(gameObject, Time.deltaTime);

        if (nextState != null)
        {
            SwitchToNextState(nextState);
        }
    }

    private void SwitchToNextState(MushroomStateUpdate next)
    {
        currentState = next;
    }
}
