using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM: MonoBehaviour
{
    GM instance = null;

    #region Public Variables

    public GameState gamestate = GameState.Tour;

    #endregion

    private void Awake()
    {
        //singlton
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(this);

        //starting game state
        gamestate = GameState.Tour;
    }
}

//Enum to track the game state so buttons can have multiple functionality.
public enum GameState
{
    Tour,
    UI,
    Game,
}
