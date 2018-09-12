using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters;
using UnityEngine;
using UnityEngine.EventSystems;

public class Dual : MovePattern
{

  [CreateAssetMenu(fileName = "Dual")]
  public override void Invoke(CharacterController controller, Transform transform)
  {
    private bool doubleJump;
    
    if (controller.isGrounded)
    {
      Move(transform);
      doubleJump = true;
    }

    if(doubleJump)
  {
    moveDirection.y = MoveY.Value;
    doubleJump = false;
  }
   
    Move(controller);
  }
}
