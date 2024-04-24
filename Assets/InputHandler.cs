using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class InputHandler : MonoBehaviour
{
    // Start is called before the first frame update

    public Vector2 MoveInput { get; private set; }
 

    public void OnMoveInput(InputAction.CallbackContext context)
    {
        MoveInput = context.ReadValue<Vector2>();
    }
}
