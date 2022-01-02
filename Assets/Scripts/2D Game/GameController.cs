using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameController : MonoBehaviour
{
    [SerializeField] GameObject GameEnvironment;
    [SerializeField] float speed = 5f;

    float horizontalMovement;
    public float HorizontalMovement
    {
        set
        {
            horizontalMovement = value;
        }
    }

    float verticleMovement;
    public float VerticleMovement
    {
        set
        {
            verticleMovement = value;
        }
    }


    private void Update()
    {
        EnvironmentalMove(horizontalMovement);
        playerFallorJump(verticleMovement);
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
        if (axis > Mathf.Epsilon)
        {
            //jump up
        }
        else if(axis < -Mathf.Epsilon)
        {
            //fall through ground
        }
    }

}
