using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingTween : MonoBehaviour
{
    [SerializeField] GameObject mainMenu;

    [SerializeField] GameObject mainMenuOpenTweenPosition;
    [SerializeField] GameObject mainMenuCloseTweenPosition;

    [SerializeField] GameObject settingMenuOpenTweenPosition;
    [SerializeField] GameObject settingMenuCloseTweenPosition;

    [SerializeField] float tweenTime = 1f;

    public void OpenTween()
    {
        LeanTween.move(gameObject, settingMenuOpenTweenPosition.transform.position, tweenTime);
        LeanTween.move(mainMenu, mainMenuCloseTweenPosition.transform.position, tweenTime);
    }

    public void CloseTween()
    {
        LeanTween.move(gameObject, settingMenuCloseTweenPosition.transform.position, tweenTime);
        LeanTween.move(mainMenu, mainMenuOpenTweenPosition.transform.position, tweenTime);
    }
}
