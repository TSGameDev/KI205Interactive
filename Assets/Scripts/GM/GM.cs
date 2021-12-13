using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM: MonoBehaviour
{
    GM instance = null;
    public GameState gamestate = GameState.Tour;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(this);
    }
}

public enum GameState
{
    Tour,
    UI,
    Game,
}
