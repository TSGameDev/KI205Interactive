using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameController : MonoBehaviour
{
    #region Serialized Variables

    [SerializeField] GameObject GameEnvironment;
    [SerializeField] float speed = 5f;
    [SerializeField] float jumpForce = 5f;
    [SerializeField] GameObject playerStartPos;

    #endregion

    #region Private Variables

    Rigidbody2D Rigidbody2D;
    BoxCollider2D BoxCollider2D;
    bool isAir = false;

    #endregion

    #region Get-Setters

    float horizontalMovement;
    public float HorizontalMovement
    {
        set
        {
            horizontalMovement = value;
        }
    }

    #endregion

    private void Awake()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
        BoxCollider2D = GetComponent<BoxCollider2D>();
    }

    private void FixedUpdate()
    {
        EnvironmentalMove(horizontalMovement);
    }

    /// <summary>
    /// Moves the environment of the 2D game to mimick the movement of a 2d character. This was a work around for the world-space canvas.
    /// </summary>
    /// <param name="axis">The value of the vector2 that represents the AD button presses</param>
    public void EnvironmentalMove(float axis)
    {
        if(axis > Mathf.Epsilon)
        {
            GameEnvironment.transform.position += new Vector3((speed * Time.deltaTime), 0, 0);
        }
        else if(axis < -Mathf.Epsilon)
        {
            GameEnvironment.transform.position -= new Vector3((speed * Time.deltaTime), 0, 0);
        }
    }

    /// <summary>
    /// Makes the character jump or fall throught he terrain to give verticallity to the movement. 
    /// </summary>
    /// <param name="axis">The value of the vector2 that represents the WS button presses</param>
    public void playerFallorJump(float axis)
    {
        if(!isAir)
        {
            if (axis > Mathf.Epsilon)
            {
                //makes the character jump and stops multiple jumps
                Rigidbody2D.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
                isAir = true;
            }
            else if (axis < -Mathf.Epsilon)
            {
                //turns of the colliders to allow the player to fall through terrain
                BoxCollider2D.enabled = false;
            }
            else
            {
                //if there is no input, makes sure the collier is active
                BoxCollider2D.enabled = true;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("2D Environment"))
        {
            //makes the character notice they are no longer in the air therefore allowed to jump
            isAir = false;
        }

        if(collision.gameObject.CompareTag("2D KillZone"))
        {
            //resets the character and environment position
            gameObject.transform.position = playerStartPos.transform.position;
            GameEnvironment.transform.localPosition = new Vector3(0, 0, 0);
        }
    }
}
