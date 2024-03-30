using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    PlayerInput input;
    [HideInInspector]
    public Vector2 move;
    [HideInInspector]
    public Vector2 look;
    public bool aimPos;

    private void Awake() {
        input = new PlayerInput(); //New instance of input actions
        
        //Input in Player
        input.Player.Movement.performed += x => move = x.ReadValue<Vector2>();
        input.Player.Look.performed += x => look = x.ReadValue<Vector2>();

        //Input in Actions
        input.Actions.Jump.performed += x => Jump();
    }

    private void Jump() {
        Debug.Log("I'm Jumping");
    }

    #region Enable/Disable
    private void OnEnable() {
        input.Enable();
    }

    private void OnDisable() {
        input.Disable();
    }

    #endregion
}
