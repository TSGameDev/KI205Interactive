using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputMaster : MonoBehaviour
{
    static PlayerControlers playerControls;
    Player player;

    private void Awake()
    {
        playerControls = new PlayerControlers();
        player = GetComponent<Player>();

        playerControls.TourActions.Enable();
        playerControls.UI.Disable();
        playerControls._2DGame.Disable();

        playerControls.TourActions.Movement.performed += ctx => player.InputMovement = ctx.ReadValue<Vector2>();
        playerControls.TourActions.Movement.canceled += ctx => player.InputMovement = ctx.ReadValue<Vector2>();

        playerControls.TourActions.Escape.performed += _ => player.GameStateChange();

        playerControls.TourActions.Interaction.performed += _ => player.interaction();
    }

    private void OnEnable()
    {
        playerControls.Enable();
    }

    private void OnDisable()
    {
        playerControls.Disable();
    }
}
