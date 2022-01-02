using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputMaster : MonoBehaviour
{
    public PlayerControlers playerControls;
    Player player;
    [SerializeField] GameController gameController;

    private void Awake()
    {
        playerControls = new PlayerControlers();
        player = GetComponent<Player>();

        playerControls.TourActions.Movement.performed += ctx => player.InputMovement = ctx.ReadValue<Vector2>();
        playerControls.TourActions.Movement.canceled += ctx => player.InputMovement = ctx.ReadValue<Vector2>();

        playerControls.TourActions.Escape.started += _ => player.GameStateChange();

        playerControls.TourActions.Interaction.performed += _ => player.interaction();

        playerControls._2DGame.Movement.performed += ctx => gameController.HorizontalMovement = ctx.ReadValue<Vector2>().x;
        playerControls._2DGame.Movement.canceled += ctx => gameController.HorizontalMovement = ctx.ReadValue<Vector2>().x;

        playerControls._2DGame.Movement.performed += ctx => gameController.playerFallorJump(ctx.ReadValue<Vector2>().y);
        //playerControls._2DGame.Movement.canceled += ctx => gameController.playerFallorJump(ctx.ReadValue<Vector2>().y);
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
