using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeStateMachine : MonoBehaviour
{
    public SlimeStateUpdate startingState;
    private SlimeStateUpdate currentState;
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

        SlimeStateUpdate nextState = currentState.Run(gameObject, Time.deltaTime);

        if (nextState != null)
        {
            SwitchToNextState(nextState);
        }
    }

    private void SwitchToNextState(SlimeStateUpdate next)
    {
        currentState = next;
    }
}
