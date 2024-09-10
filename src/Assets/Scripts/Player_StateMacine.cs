using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public　partial class Player
{
    //状態遷移を管理
    private static readonly StatePositioning statePositioning = new StatePositioning();//位置決め
    private static readonly StateAfterPositioning stateAfterPositioning = new StateAfterPositioning();//位置決めの後

    private PlayerStateBase currentState;

    //Start()から呼ぶ
    private void OnStart()
    {
        currentState = statePositioning;
        currentState.OnEnter(this,null);
    }

    //Update()から呼ぶ
    private void OnUpdate()
    {
        currentState.OnUpdate(this);
    }

    //状態を遷移させる時に呼ぶ
    private void ChangeState(PlayerStateBase nextState)
    {
        currentState.OnExit(this, nextState);
        nextState.OnEnter(this,currentState);
        currentState = nextState;
    }
}
