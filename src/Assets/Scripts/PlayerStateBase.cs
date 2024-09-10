using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerStateBase : MonoBehaviour
{
    public virtual void OnEnter(){ }//‚»‚Ìó‘Ô‚ÌÅ‰‚É‚â‚éˆ—
    public virtual void OnUpdate() { }//‚»‚Ìó‘Ô‚Å–ˆƒtƒŒ[ƒ€‚â‚éˆ—
    public virtual void OnExit() { }//‚»‚Ìó‘Ô‚ÌÅŒã‚É‚â‚éˆ—
}
