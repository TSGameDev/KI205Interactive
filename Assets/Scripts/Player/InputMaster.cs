using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputMaster : MonoBehaviour
{

    #region Public Variables

    public PlayerControlers playerControls;

    #endregion

    #region Private Variables

    Player player;

    #endregion

    #region Serialzed Variables

    [SerializeField] GameController gameController;

    #endregion

    private void Awake()
    {
        playerControls = new PlayerControlers();
        player = GetComponent<Player>();

        #region Tour Actions

        playerControls.TourActions.Movement.performed += ctx => player.InputMovement = ctx.ReadValue<Vector2>();
        playerControls.TourActions.Movement.canceled += ctx => player.InputMovement = ctx.ReadValue<Vector2>();

        playerControls.TourActions.Escape.started += _ => player.GameStateChange();

        playerControls.TourActions.Interaction.performed += _ => player.interaction();

        #endregion


        #region 2D Game Actions

        playerControls._2DGame.Movement.performed += ctx => gameController.HorizontalMovement = ctx.ReadValue<Vector2>().x;
        playerControls._2DGame.Movement.canceled += ctx => gameController.HorizontalMovement = ctx.ReadValue<Vector2>().x;

        playerControls._2DGame.Movement.performed += ctx => gameController.playerFallorJump(ctx.ReadValue<Vector2>().y);

        #endregion


    }

    private void OnEnable()
    {
        //disables all action maps on startup, other than one needed, to stop double function calls
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
