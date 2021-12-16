using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionBoxTween : MonoBehaviour
{
    [SerializeField] float tweenTime = 1f;

    public void OpenTween()
    {
        LeanTween.scale(gameObject, Vector3.one, tweenTime);
    }

    public void CloseTween()
    {
        LeanTween.scale(gameObject, Vector3.zero, tweenTime);
    }
}
