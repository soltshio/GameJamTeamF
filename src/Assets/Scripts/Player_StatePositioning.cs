using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class Player
{
    //ˆÊ’uŒˆ‚ß
    public class StatePositioning:PlayerStateBase
    {
        public override void OnEnter(Player owner, PlayerStateBase prevState)
        {
            owner.moveTime.ResetMoveTime();
            owner.putFoot.SwitchFoot();//‘«‚ð“ü‚ê‘Ö‚¦‚é
        }

        public override void OnUpdate(Player owner)
        {
            owner.move.MoveControl();

            if(!owner.moveTime.CanMove())//“®‚¯‚È‚­‚È‚Á‚½‚çˆÊ’uŒˆ‚ß‚ÌŒã‚É‘JˆÚ
            {
                owner.ChangeState(stateAfterPositioning);
            }
        }

        public override void OnExit(Player owner, PlayerStateBase nextState)
        {
           
        }
    }
}
