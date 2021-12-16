using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionScript : MonoBehaviour
{
    [SerializeField] InformationSO objectInformation;

    InfoBoxTween infoBoxTween;
    InteractionBoxTween interactionBoxTween;

    private void Awake()
    {
        infoBoxTween = FindObjectOfType<InfoBoxTween>();
        interactionBoxTween = FindObjectOfType<InteractionBoxTween>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            interactionBoxTween.OpenTween();
            Player player = other.GetComponent<Player>();
            player.interaction = infoBoxTween.OpenTween;

            infoBoxTween.UpdateGUI(objectInformation.titleText, objectInformation.information, objectInformation.objectPicture);
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
