using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Cinemachine;

public class Player : MonoBehaviour
{
    CharacterController characterController;
    GM gameMaster;

    Vector2 inputMovement;
    public Vector2 InputMovement { set { inputMovement = value;  } }

    [SerializeField] float speed = 10f;
    [SerializeField] Camera cameraa;

    private void Awake()
    {
        characterController = GetComponent<CharacterController>();
        gameMaster = FindObjectOfType<GM>();

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        Movement();
    }

    void Movement()
    {
        float x = inputMovement.x;
        float z = inputMovement.y;

        Vector3 movement = cameraa.transform.right * x + cameraa.transform.forward * z;
        
        movement.y = 0;

        characterController.Move(movement * speed * Time.deltaTime);
    }

    public void GameStateChange()
    {
        switch (gameMaster.gamestate)
        {
            case GameState.Tour:
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                gameMaster.gamestate = GameState.UI;
                break;

            case GameState.UI:
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
                gameMaster.gamestate = GameState.Tour;
                break;

            case GameState.Game:
                gameMaster.gamestate = GameState.Tour;
                break;
        }
    }
}
