using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    #region Serialized Variables

    [Header("Player Variables")]
    [SerializeField] GameObject GameEnvironment;
    [SerializeField] GameObject playerStartPos;
    [SerializeField] LayerMask gameEnvironmentLayer;
    [SerializeField] float speed = 5f;
    [SerializeField] float jumpForce = 5f;

    [Header("Collectables")]
    [SerializeField] TextMeshProUGUI scoreTxt;
    [SerializeField] GameObject[] coins;

    [Header("Sounds")]
    [SerializeField] AudioManager audioManager;
    [SerializeField] AudioClip stepClip;
    [SerializeField] AudioClip jumpClip;
    [SerializeField] AudioClip deathClip;
    #endregion

    #region Private Variables

    Rigidbody2D Rigidbody2D;
    BoxCollider2D BoxCollider2D;
    AudioSource audioSource;
    int score = 0;

    float currentStepTime = 0.0f;
    float stepTime = 0.6f;

    const float boxcastYoffset = 0.09f;
    const float boxcastSizeX = 0.15f;
    const float boxcastSizeY = 0.02f;
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
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        currentStepTime += 1 * Time.deltaTime;
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

            if(currentStepTime >= stepTime)
            {
                currentStepTime = 0;
                audioManager.PlayClipWithVariation(audioSource, stepClip);
            }
        }
        else if(axis < -Mathf.Epsilon)
        {
            GameEnvironment.transform.position -= new Vector3((speed * Time.deltaTime), 0, 0);

            if (currentStepTime >= stepTime)
            {
                currentStepTime = 0;
                audioManager.PlayClipWithVariation(audioSource, stepClip);
            }
        }
    }

    /// <summary>
    /// Makes the character jump or fall throught he terrain to give verticallity to the movement. 
    /// </summary>
    /// <param name="axis">The value of the vector2 that represents the WS button presses</param>
    public void playerFallorJump(float axis)
    {
        if (axis > Mathf.Epsilon)
        {
            Vector2 boxOrigin = new Vector2(transform.position.x, transform.position.y - boxcastYoffset);
            Vector2 boxSize = new Vector2(boxcastSizeX, boxcastSizeY);
            if (Physics2D.BoxCast(boxOrigin, boxSize, 0f, Vector2.down, ~gameEnvironmentLayer))
            {
                Rigidbody2D.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
                audioManager.PlayClipWithVariation(audioSource, jumpClip);
            }
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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("2D KillZone"))
        {
            //resets the character and environment position
            gameObject.transform.position = playerStartPos.transform.position;
            GameEnvironment.transform.localPosition = new Vector3(0, 0, 0);
            
            foreach(GameObject coin in coins)
            {
                coin.SetActive(true);
            }
            
            score = 0;
            scoreTxt.text = $"Score: {score}";

            audioManager.PlayClipWithVariation(audioSource, deathClip);
        }

        if(collision.gameObject.CompareTag("2D Collectable"))
        {
            score++;
            collision.gameObject.SetActive(false);
            scoreTxt.text = $"Score: {score}";
        }
    }

    private void OnDrawGizmos()
    {
        Vector2 boxOrigin = new Vector2(transform.position.x, transform.position.y - boxcastYoffset);
        Vector2 boxSize = new Vector2(boxcastSizeX, boxcastSizeY);
        Gizmos.DrawWireCube(boxOrigin, boxSize);
    }

}
