using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MiniGameOneManager : Manager<MiniGameOneManager>
{
    protected override bool IsPersistent => false;

    int currentScore = 0;

    MiniGameOneUIManager miniGameOneUIManager;

    void Start()
    {
        miniGameOneUIManager = MiniGameOneUIManager.Instance;   
    }

    public void GameStart()
    {
        Time.timeScale = 1f;
        miniGameOneUIManager.UpdateScore(0);
    }
    public void GameOver()
    {
        miniGameOneUIManager.SetRestart();
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void AddScore(int score)
    { 
        currentScore += score;
        miniGameOneUIManager.UpdateScore(currentScore);
    }

}
