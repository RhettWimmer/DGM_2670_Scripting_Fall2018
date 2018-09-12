using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "MovePatternNotGrounded")]

    private bool doubleJump;

public class NotGroundedMove : MovePattern {

    public override void Invoke(CharacterController controller,Transform transform)
    {
        Move(transform);
        Move(controller);
    }
    
    
    
}
