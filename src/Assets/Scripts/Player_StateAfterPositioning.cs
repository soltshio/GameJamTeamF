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
            //現在の足の当たり判定を見る(当たってたらゲームオーバー)
        }

        public override void OnUpdate(Player owner)
        {
            //画面スクロール
            //画面スクロールし終わったら位置決めに移動
        }

        public override void OnExit(Player owner, PlayerStateBase nextState)
        {
            owner.putFoot.SwitchFoot();//現在動かしている足を入れ替える
        }
    }
}
