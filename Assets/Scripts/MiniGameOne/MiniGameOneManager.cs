using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MiniGameOneManager : Manager<MiniGameOneManager>
{
    protected override bool IsPersistent => false;

    private int currentScore = 0;

    MiniGameOneUIManager miniGameOneUIManager;
   

    protected override void Awake()
    {
        base.Awake();
    }
    private void Start()
    {
        miniGameOneUIManager = MiniGameOneUIManager.Instance;
        miniGameOneUIManager.UpdateScore(0);
    }
    public void GameOver()
    {
        Debug.Log("Game Over");
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
