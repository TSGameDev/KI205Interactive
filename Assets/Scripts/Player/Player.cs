using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Cinemachine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    #region Private Variables

    InputMaster inputMaster;
    CharacterController characterController;
    GM gameMaster;
    AudioManager audioManager;
    AudioSource audioSource;
    TitleTween titleTween;
    MainMenuTween mainMenuTween;
    InteractionListTween interactionListTween;
    InteractionBoxTween interactionBoxTween;

    float currentStepTime = 0;
    float stepTime = 0.6f;

    #endregion

    #region Get-Setters

    Vector2 inputMovement;
    public Vector2 InputMovement { set { inputMovement = value;  } }

    #endregion

    #region Serialized/Public Variables

    [SerializeField] float speed = 10f;
    [SerializeField] Camera cameraa;
    [SerializeField] AudioClip[] footsteps;
    [SerializeField] CinemachineVirtualCamera virtualCamera;
    [SerializeField] CinemachineVirtualCamera gameCamera;


    public UnityAction interaction;

    #endregion

    private void Awake()
    {
        characterController = GetComponent<CharacterController>();
        gameMaster = FindObjectOfType<GM>();
        audioSource = GetComponent<AudioSource>();
        audioManager = FindObjectOfType<AudioManager>();
        titleTween = FindObjectOfType<TitleTween>();
        mainMenuTween = FindObjectOfType<MainMenuTween>();
        interactionListTween = FindObjectOfType<InteractionListTween>();
        inputMaster = GetComponent<InputMaster>();
        interactionBoxTween = FindObjectOfType<InteractionBoxTween>();

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        Movement();
        Gravity();
    }

    void Movement()
    {
        float x = inputMovement.x;
        float z = inputMovement.y;
        Vector3 movement = cameraa.transform.right * x + cameraa.transform.forward * z;
        
        if(movement.magnitude >= 0.1f)
        {
            characterController.Move(movement * speed * Time.deltaTime);

            if (currentStepTime >= stepTime)
            {
                currentStepTime = 0;
                audioManager.PlayWithClipVariation(audioSource, footsteps);
            }

            currentStepTime += 1 * Time.deltaTime;
        }
    }

    void Gravity()
    {
        if(!characterController.isGrounded)
        {
            characterController.Move(Physics.gravity * Time.deltaTime);
        }
    }

    void ChangeToUI()
    {
        //change the cursor so its visable and not locked
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        //stop the camera from moving around when using the ui
        virtualCamera.enabled = false;
        
        //active the main menu tweens
        titleTween.OpenTween();
        mainMenuTween.OpenTween();
        interactionListTween.OpenTween();

        //disable the tour controls and active the UI controls
        inputMaster.playerControls.TourActions.Disable();
        inputMaster.playerControls.UI.Enable();
        
        //change the gamestate to UI
        gameMaster.gamestate = GameState.UI;
    }

    void ChangeToTour()
    {
        //Change the cursor to be locked and invisable
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        
        //allow the camera to move
        virtualCamera.enabled = true;
        
        //close the main menu through tweens
        titleTween.CloseTween();
        mainMenuTween.CloseTween();
        interactionListTween.CloseTween();
        
        //active the tour controls and disable the UI controls
        inputMaster.playerControls.TourActions.Enable();
        inputMaster.playerControls.UI.Disable();
        
        //change the game state to the tour state
        gameMaster.gamestate = GameState.Tour;
    }

    void ExitGame()
    {
        //change the gamestate to tour from the 2D game state
        gameMaster.gamestate = GameState.Tour;

        //change the camera back to the tour camera through cinemachine virtual camera priority
        gameCamera.Priority = 0;
        virtualCamera.Priority = 1;
        
        //active the tour controls and disable the 2D game controls
        inputMaster.playerControls.TourActions.Enable();
        inputMaster.playerControls._2DGame.Disable();
    }

    public void ChangeTo2D()
    {
        //change the game state to the 2D Game state
        gameMaster.gamestate = GameState.Game;
        
        //change to the 2D game camera from the tour camera through cinemachine virtural camera priority
        gameCamera.Priority = 1;
        virtualCamera.Priority = 0;
        
        // disable the tour controls and active the 2D game contorls
        inputMaster.playerControls.TourActions.Disable();
        inputMaster.playerControls._2DGame.Enable();
        
        //close the interaction ui through its tween to free up screen space when playing the 2D game
        interactionBoxTween.CloseTween();
    }

    public void GameStateChange()
    {
        //a switch which changes the game state from tour to UI, UI to tour and Game to tour. This is the main the escape button functionality.
        switch (gameMaster.gamestate)
        {
            case GameState.Tour:
                Debug.Log("Tour Case");
                ChangeToUI();
                return;

            case GameState.UI:
                Debug.Log("UI Case");
                ChangeToTour();
                return;

            case GameState.Game:
                ExitGame();
                return;
        }
    }

}
