using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "NotGroundedMove")]
public class NotGroundedMove : MovePattern {
    
    private bool doubleJump;

    public override void Invoke(CharacterController controller,Transform transform)
    {
        Move(transform);
        Move(controller);
    }  
}
