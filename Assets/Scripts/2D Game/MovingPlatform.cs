using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    #region Serialized Variables

    [SerializeField] Transform pos1, pos2;
    [SerializeField] float speed;
    [SerializeField] Transform startPos;

    #endregion

    #region Private Variables

    Vector3 nextPos;

    #endregion

    private void Start()
    {
        nextPos = startPos.localPosition;
    }

    private void Update()
    {
        if(transform.localPosition == pos1.localPosition)
        {
            nextPos = pos2.localPosition;
        }
        if(transform.localPosition == pos2.localPosition)
        {
            nextPos = pos1.localPosition;
        }

        transform.localPosition = Vector3.MoveTowards(transform.localPosition, nextPos, speed * Time.deltaTime);
    }
}
