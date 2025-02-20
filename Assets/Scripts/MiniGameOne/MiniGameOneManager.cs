using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGameOneManager : Manager<MiniGameOneManager>
{
    protected override bool IsPersistent => false;

    public int currentScore = 0;
    public int bestScore = 0;

    MiniGameOneUIManager miniGameOneUIManager;
    protected override void Awake()
    {
        base.Awake();
        bestScore = GameManager.Instance.playerData.MiniGameBestScore[0];
    }
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
        miniGameOneUIManager.AtGameOver();
    }
    public void RestartGame()
    {
        GameManager.Instance.MoveScene(2);
    }
    public void AddScore(int score)
    { 
        currentScore += score;
        miniGameOneUIManager.UpdateScore(currentScore);
    }

}
