using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Manager<GameManager>
{
    public PlayerData playerData;

    protected override void Awake()
    {
        base.Awake();

        //tryLoad playerData;
        //else 
        playerData = new PlayerData();

    }

    public void MoveScene(int SceneIndex)
    {
        playerData.lastSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(SceneIndex);
    }
}
