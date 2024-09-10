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
            owner.move.MoveReset();//リセット処理
        }

        public override void OnUpdate(Player owner)
        {
            if(!owner.move.MoveControl())//動けなくなったら位置決めの後に遷移(そうでない場合は自由に動かせる)
            {
                owner.ChangeState(stateAfterPositioning);
            }
        }

        public override void OnExit(Player owner, PlayerStateBase nextState)
        {
           
        }
    }
}
