using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class Player
{
    //位置決め
    public class StatePositioning:PlayerStateBase
    {
        public override void OnEnter(Player owner, PlayerStateBase prevState)
        {
            owner.moveTime.ResetMoveTime();
            owner.putFoot.SwitchFoot();//足を入れ替える
        }

        public override void OnUpdate(Player owner)
        {
            owner.move.MoveControl();

            if(!owner.moveTime.CanMove())//動けなくなったら位置決めの後に遷移
            {
                owner.ChangeState(stateAfterPositioning);
            }
        }

        public override void OnExit(Player owner, PlayerStateBase nextState)
        {
           
        }
    }
}
