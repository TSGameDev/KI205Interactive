using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuTween : MonoBehaviour
{
    [SerializeField] float tweenTime = 0.4f;

    [SerializeField] GameObject returnButton;
    [SerializeField] GameObject settingsButton;
    [SerializeField] GameObject creditsButton;
    [SerializeField] GameObject exitButton;

    public void OpenTween()
    {
        LeanTween.scale(gameObject, Vector3.one, tweenTime ).setOnComplete(() => 
        {
            LeanTween.scale(returnButton, Vector3.one, tweenTime).setOnComplete(() =>
            {
                LeanTween.scale(settingsButton, Vector3.one, tweenTime).setOnComplete(() =>
                {
                    LeanTween.scale(creditsButton, Vector3.one, tweenTime).setOnComplete(() => 
                    {
                        LeanTween.scale(exitButton, Vector3.one, tweenTime);
                    });
                });
            });
        });
    }

    public void CloseTween()
    {
        LeanTween.scale(exitButton, Vector3.zero, tweenTime).setOnComplete(() =>
        {
            LeanTween.scale(creditsButton, Vector3.zero, tweenTime).setOnComplete(() =>
            {
                LeanTween.scale(settingsButton, Vector3.zero, tweenTime).setOnComplete(() =>
                {
                    LeanTween.scale(returnButton, Vector3.zero, tweenTime).setOnComplete(() =>
                    {
                        LeanTween.scale(gameObject, Vector3.zero, tweenTime);
                    });
                });
            });
        });
    }
}
