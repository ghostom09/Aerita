using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player_Input : MonoBehaviour
{
    [SerializeField] private Player player;
    public void OnMove(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            player.move.movement = context.ReadValue<Vector2>();
        }else if (context.canceled)
        {
            player.move.movement = Vector2.zero;
        }
    }
    public void OnJump(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            player.move.isJumpPressed = true;
        }else if (context.canceled)
        {
            player.move.jumpHeld = false;
            player.move.isJumpPressed = false;
        }
    }
}
