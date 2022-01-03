using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Object Information", menuName = "Interactions/Interative Objects", order = 1)]
public class InformationSO : ScriptableObject
{
    //Text variable for the title.
    public string titleText = "New Title";

    //sprite variable to hold the real-life photo of the object.
    public Sprite objectPicture = null;
    
    //text variable for the information about the object, uses the multiline funcationality to make it easier to write in the inspector.
    [Multiline]
    public string information = "This is the information to be displayed about the object the user interacted with.";
}
