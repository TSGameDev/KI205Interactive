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

    public void GameStateChange()
    {
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

    void ChangeToUI()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        virtualCamera.enabled = false;
        titleTween.OpenTween();
        mainMenuTween.OpenTween();
        interactionListTween.OpenTween();
        inputMaster.playerControls.TourActions.Disable();
        inputMaster.playerControls.UI.Enable();
        gameMaster.gamestate = GameState.UI;
        Debug.Log("Now In UI");
    }

    void ChangeToTour()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        virtualCamera.enabled = true;
        titleTween.CloseTween();
        mainMenuTween.CloseTween();
        interactionListTween.CloseTween();
        inputMaster.playerControls.TourActions.Enable();
        inputMaster.playerControls.UI.Disable();
        gameMaster.gamestate = GameState.Tour;
        Debug.Log("Now In Tour");
    }

    void ExitGame()
    {
        gameMaster.gamestate = GameState.Tour;
        gameCamera.Priority = 0;
        virtualCamera.Priority = 1;
        inputMaster.playerControls.TourActions.Enable();
        inputMaster.playerControls._2DGame.Disable();
    }

    public void ChangeTo2D()
    {
        gameMaster.gamestate = GameState.Game;
        gameCamera.Priority = 1;
        virtualCamera.Priority = 0;
        inputMaster.playerControls.TourActions.Disable();
        inputMaster.playerControls._2DGame.Enable();
        interactionBoxTween.CloseTween();
    }
}
