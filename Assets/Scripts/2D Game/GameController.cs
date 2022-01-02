using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameController : MonoBehaviour
{
    [SerializeField] GameObject GameEnvironment;
    [SerializeField] float speed = 5f;
    [SerializeField] float jumpForce = 5f;
    [SerializeField] GameObject playerStartPos;

    Rigidbody2D Rigidbody2D;
    BoxCollider2D BoxCollider2D;
    bool isAir = false;

    private void Awake()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
        BoxCollider2D = GetComponent<BoxCollider2D>();
    }

    float horizontalMovement;
    public float HorizontalMovement
    {
        set
        {
            horizontalMovement = value;
        }
    }


    private void FixedUpdate()
    {
        EnvironmentalMove(horizontalMovement);
    }

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

    public void playerFallorJump(float axis)
    {
        if(!isAir)
        {
            if (axis > Mathf.Epsilon)
            {
                Rigidbody2D.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
                isAir = true;
            }
            else if (axis < -Mathf.Epsilon)
            {
                BoxCollider2D.enabled = false;
            }
            else
            {
                BoxCollider2D.enabled = true;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("2D Environment"))
        {
            isAir = false;
        }

        if(collision.gameObject.CompareTag("2D KillZone"))
        {
            gameObject.transform.position = playerStartPos.transform.position;
            GameEnvironment.transform.localPosition = new Vector3(0, 0, 0);
        }
    }
}
