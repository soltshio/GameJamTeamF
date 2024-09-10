using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public@partial class Player
{
    //ó‘Ô‘JˆÚ‚ğŠÇ—
    private static readonly StatePositioning statePositioning = new StatePositioning();//ˆÊ’uŒˆ‚ß
    private static readonly StateAfterPositioning stateAfterPositioning = new StateAfterPositioning();//ˆÊ’uŒˆ‚ß‚ÌŒã

    private PlayerStateBase currentState;

    //Start()‚©‚çŒÄ‚Ô
    private void OnStart()
    {
        currentState = statePositioning;
        currentState.OnEnter(this,null);
    }

    //Update()‚©‚çŒÄ‚Ô
    private void OnUpdate()
    {
        currentState.OnUpdate(this);
    }

    //ó‘Ô‚ğ‘JˆÚ‚³‚¹‚é‚ÉŒÄ‚Ô
    private void ChangeState(PlayerStateBase nextState)
    {
        currentState.OnExit(this, nextState);
        nextState.OnEnter(this,currentState);
        currentState = nextState;
    }
}
