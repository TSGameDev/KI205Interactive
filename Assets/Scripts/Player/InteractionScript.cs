using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionScript : MonoBehaviour
{
    [SerializeField] InformationSO objectInformation;
    [SerializeField] bool ChangeTo2D = false;

    InfoBoxTween infoBoxTween;
    InteractionBoxTween interactionBoxTween;

    private void Awake()
    {
        infoBoxTween = FindObjectOfType<InfoBoxTween>();
        interactionBoxTween = FindObjectOfType<InteractionBoxTween>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Player player = other.GetComponent<Player>();
        
        if (other.CompareTag("Player") && !ChangeTo2D)
        {
            interactionBoxTween.OpenTween();
            player.interaction = infoBoxTween.OpenTween;

            infoBoxTween.UpdateGUI(objectInformation.titleText, objectInformation.information, objectInformation.objectPicture);
        }

        if (ChangeTo2D)
        {
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
