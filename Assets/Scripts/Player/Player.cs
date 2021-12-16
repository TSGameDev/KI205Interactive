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
                ChangeToUI();
                break;

            case GameState.UI:
                ChangeToTour();
                break;

            case GameState.Game:
                ExitGame();
                break;
        }
    }

    void ChangeToUI()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        gameMaster.gamestate = GameState.UI;
        titleTween.OpenTween();
        mainMenuTween.OpenTween();
        interactionListTween.OpenTween();
        inputMaster.playerControls.TourActions.Disable();
        inputMaster.playerControls.UI.Enable();
    }

    void ChangeToTour()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        gameMaster.gamestate = GameState.Tour;
        titleTween.CloseTween();
        mainMenuTween.CloseTween();
        interactionListTween.CloseTween();
        inputMaster.playerControls.TourActions.Enable();
        inputMaster.playerControls.UI.Disable();
    }

    void ExitGame()
    {
        gameMaster.gamestate = GameState.Tour;
    }
}
