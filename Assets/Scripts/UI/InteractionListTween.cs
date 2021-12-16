using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionListTween : MonoBehaviour
{
    [SerializeField] GameObject openTweenPosition;
    [SerializeField] GameObject closeTweenPosition;
    [SerializeField] float tweenTime = 1f;

    public void OpenTween()
    {
        LeanTween.move(gameObject, openTweenPosition.transform.position, tweenTime);
    }

    public void CloseTween()
    {
        LeanTween.move(gameObject, closeTweenPosition.transform.position, tweenTime);
    }
}
