using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionScript : MonoBehaviour
{
    #region Serialized Variables

    [SerializeField] InformationSO objectInformation;
    [SerializeField] bool ChangeTo2D = false;

    #endregion

    #region Private Variables

    InfoBoxTween infoBoxTween;
    InteractionBoxTween interactionBoxTween;

    #endregion

    private void Awake()
    {
        infoBoxTween = FindObjectOfType<InfoBoxTween>();
        interactionBoxTween = FindObjectOfType<InteractionBoxTween>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !ChangeTo2D)
        {
            //if the player collides and the interaction volume isn't for changing to 2D Game. Gets the play as a variable,
            //actives the interaction tween and sets up the delegate to tween in the information UI alongside changing the information UI text to the correct this interaction volumes text
            Player player = other.GetComponent<Player>();
            interactionBoxTween.OpenTween();
            player.interaction = infoBoxTween.OpenTween;

            infoBoxTween.UpdateGUI(objectInformation.titleText, objectInformation.information, objectInformation.objectPicture);
        }
        else if (other.CompareTag("Player") && ChangeTo2D)
        {
            //if the player collides and the interaction volume is for chagning to 2D Game.
            //Get the player as a variable, active the interactiont tween and set up the interaction delegate for chagning to the 2D Game.
            Player player = other.GetComponent<Player>();
            interactionBoxTween.OpenTween();
            player.interaction = player.ChangeTo2D;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            interactionBoxTween.CloseTween();
        }
    }
}
