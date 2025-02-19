using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MiniGameOneUIManager : Manager<MiniGameOneUIManager>
{
    protected override bool IsPersistent => false;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI restartText;

    protected override void Awake()
    {
        base.Awake();
    }
  
    void Start()
    {
        if (restartText == null) Debug.LogError("restart text is null");
        if (scoreText == null) Debug.LogError("score text is null");
        
        restartText.gameObject.SetActive(false);
    }

    public void SetRestart()
    {
        restartText.gameObject.SetActive(true);
    }

    public void UpdateScore(int score)
    {
        scoreText.text = score.ToString();
    }
}
