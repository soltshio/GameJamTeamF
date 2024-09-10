using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerStateBase
{
    public virtual void OnEnter(Player owner, PlayerStateBase prevState) { }//‚»‚Ìó‘Ô‚ÌÅ‰‚É‚â‚éˆ—
    public virtual void OnUpdate(Player owner) { }//‚»‚Ìó‘Ô‚Å–ˆƒtƒŒ[ƒ€‚â‚éˆ—
    public virtual void OnExit(Player owner, PlayerStateBase nextState) { }//‚»‚Ìó‘Ô‚ÌÅŒã‚É‚â‚éˆ—
}
