using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputMaster : MonoBehaviour
{
    public PlayerControlers playerControls;
    Player player;

    private void Awake()
    {
        playerControls = new PlayerControlers();
        player = GetComponent<Player>();

        playerControls.TourActions.Movement.performed += ctx => player.InputMovement = ctx.ReadValue<Vector2>();
        playerControls.TourActions.Movement.canceled += ctx => player.InputMovement = ctx.ReadValue<Vector2>();

        playerControls.TourActions.Escape.started += _ => player.GameStateChange();

        playerControls.TourActions.Interaction.performed += _ => player.interaction();

        playerControls.UI.Escape.started += _ => player.GameStateChange();
    }

    private void OnEnable()
    {
        playerControls.Enable();
        playerControls.TourActions.Enable();
        playerControls.UI.Disable();
        playerControls._2DGame.Disable();
    }

    private void OnDisable()
    {
        playerControls.Disable();
    }
}
