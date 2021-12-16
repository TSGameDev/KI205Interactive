using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Object Information", menuName = "Interactions/Interative Objects", order = 1)]
public class InformationSO : ScriptableObject
{
    public string titleText = "New Title";
    public Sprite objectPicture = null;
    [Multiline]
    public string information = "This is the information to be displayed about the object the user interacted with.";
}
