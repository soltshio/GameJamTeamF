using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class Player
{
    //位置決めの後
    public class StateAfterPositioning : PlayerStateBase
    {
        public override void OnEnter(Player owner, PlayerStateBase prevState)
        {
            owner.putFoot.Put();//足を置く
        }

        public override void OnUpdate(Player owner)
        {

        }

        public override void OnExit(Player owner, PlayerStateBase nextState)
        {

        }
    }
}
