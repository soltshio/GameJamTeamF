using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerStateBase
{
    public virtual void OnEnter(Player owner, PlayerStateBase prevState) { }//その状態の最初にやる処理
    public virtual void OnUpdate(Player owner) { }//その状態で毎フレームやる処理
    public virtual void OnExit(Player owner, PlayerStateBase nextState) { }//その状態の最後にやる処理
}
