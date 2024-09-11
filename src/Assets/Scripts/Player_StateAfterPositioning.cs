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
            owner.cameraScroll.ScrollTrigger();//trueにする
        }

        public override void OnUpdate(Player owner)
        {
            //画面スクロール
            owner.cameraScroll.Scroll();

            if (!owner.cameraScroll.ScrollNow)//スクロールしなくなったら位置決めに遷移
            {
                owner.ChangeState(statePositioning);
            }
        }

        public override void OnExit(Player owner, PlayerStateBase nextState)
        {
            owner.currentFoot.SwitchFoot();//現在動かしている足を入れ替える
            owner.displayFoot.Display();
        }
    }
}
