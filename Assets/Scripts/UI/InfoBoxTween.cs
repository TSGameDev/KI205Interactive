using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class InfoBoxTween : MonoBehaviour
{
    [SerializeField] float tweenTime = 1f;
    [SerializeField] GameObject infoboxClosePoint;
    [SerializeField] GameObject infoboxOpenPoint;

    [SerializeField] TextMeshProUGUI title;
    [SerializeField] TextMeshProUGUI information;
    [SerializeField] Image objectPicture;

    public void OpenTween()
    {
        LeanTween.move(gameObject, infoboxOpenPoint.transform.position, tweenTime);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void CloseTween()
    {
        LeanTween.move(gameObject, infoboxClosePoint.transform.position, tweenTime);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void UpdateGUI(string Title, string Information, Sprite ObjectPicture)
    {
        title.text = Title;
        information.text = Information;
        objectPicture.sprite = ObjectPicture;
    }
}
